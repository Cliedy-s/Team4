﻿using AxxenClient.Util;
using log4net.Core;
using Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AxxenClient
{
    public enum MachineType { Molding, Inspect_Measure }
    public class Item_inspectPair {
        public string Itemcode { get; set; }
        public string Inspectcode { get; set; }
        public int USLx1000 { get; set; }
        public int LSLx1000 { get; set; }
        public Item_inspectPair(string itemcode, string inspectcode, decimal USL, decimal LSL)
        {
            Itemcode = itemcode;
            Inspectcode = inspectcode;
            USLx1000 = Convert.ToInt32(USL * 1000);
            LSLx1000 = Convert.ToInt32(LSL * 1000);
        }
    }
    public class Item_MoldPair
    {
        public string Itemcode { get; set; }
        public string Moldcode { get; set; }
        public int Line_Per_Qty { get; set; }
        public Item_MoldPair(string itemcode, string moldcode, int line_Per_Qty)
        {
            Itemcode = itemcode;
            Moldcode = moldcode;
            Line_Per_Qty = line_Per_Qty;
        }
    }
    class Machine
    {
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("Machine", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }

        System.Timers.Timer timer;
        //string writefolder = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile)+ConfigurationManager.AppSettings["WriteFolder"];
        string writefolder = @"C:" + ConfigurationManager.AppSettings["WriteFolder"];

        int interval = int.Parse(ConfigurationManager.AppSettings["LogCreateMillisecond"]);
        int machineID = 0;
        int iCnt = 0;
        int toqty = 0;
        int totalqty = 0;
        int stackqty = 0;

        string workorderno = string.Empty;
        string userid = string.Empty;
        string wccode = string.Empty;
        string processcode = string.Empty;

        public Action<MachineType> stopevent { get; set; }
        public Action<int, int, int, int> runevent { get; set; }

        public Machine(int machineID, string workorderno, string userid, string wccode, Action<MachineType> stopevent = null, Action<int, int, int, int> runevent = null)
        {
            if (!Directory.Exists(writefolder))
                Directory.CreateDirectory(writefolder);

            this.stopevent = stopevent;
            this.runevent = runevent;
            this.workorderno = workorderno;
            this.userid = userid;
            this.wccode = wccode;
            this.machineID = machineID;
            if (!Directory.Exists(writefolder))
                Directory.CreateDirectory(writefolder);
        }
        /// <summary>
        /// 성형 기계시작
        /// </summary>
        public void MachineStart(int toqty, Item_MoldPair pair)
        {
            this.toqty = toqty;
            this.totalqty = toqty;

            Log.WriteInfo("성형 시작...");
            timer = new System.Timers.Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += (sender, eventargs) => { Mold_Elapsed(pair); };
            timer.AutoReset = true;
        }
        /// <summary>
        /// 품질측정 기계시작
        /// </summary>
        public void MachineStart(string processcode, List<Item_inspectPair> item_inspectcodes)
        {
            this.processcode = processcode;
            this.stopevent = stopevent;

            Log.WriteInfo("품질측정 시작...");
            timer = new System.Timers.Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += (sender, eventargs) => { Inspect_Measure_Elapsed( item_inspectcodes); };
            timer.AutoReset = true;
        }
        public void MachineStop(MachineType work, string moldcode = null)
        {
            stopevent?.Invoke(work);
            timer.Stop();
            timer.Dispose();
            string msg = string.Empty;
            switch (work)
            {
                case MachineType.Molding:
                    msg = "성형";
                    MoldService service = new MoldService();
                    service.InsertUpdateEndMoldWork(userid, moldcode, workorderno, prdcnt, iCnt);
                    break;
                case MachineType.Inspect_Measure:
                    msg = "품질측정";
                    break;
            }
            Log.WriteInfo(msg+" 로그 기록 종료...");
        }

        int prdcnt = 0;
        /// <summary>
        /// 성형기계
        /// </summary>
        /// <param name="pair"></param>
        private void Mold_Elapsed(Item_MoldPair pair)
        {
            iCnt++;
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            int badcnt = rnd.Next(0, 3);
            int outqty = pair.Line_Per_Qty;
            prdcnt = outqty - badcnt;

            stackqty += prdcnt; 
            
            StreamWriter sw = null;
            toqty = toqty - prdcnt;
            if(toqty < 0) { outqty = outqty + toqty; prdcnt = prdcnt + toqty; }
            runevent?.Invoke(stackqty, totalqty, prdcnt, outqty);
            try
            {
                DateTime now = DateTime.Now;
                sw = new StreamWriter($"{writefolder}\\{now.ToString("yyyyMMddHHmmss")}MoldingLog_{machineID}_{iCnt}.log", false);
                string msg = $"{now.ToString("yyyyMMdd HH:mm:ss")}/Machine_{machineID}/{workorderno}/{userid}/{wccode}/{pair.Moldcode}/{pair.Itemcode}/{outqty}/{badcnt}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                Log.WriteError("오류 : ", ee);
            }
            if (toqty < 0) { MachineStop(MachineType.Molding, pair.Moldcode); }
        }
        int measurecnt = 0;
        /// <summary>
        /// 품질측정기계
        /// </summary>
        /// <param name="item_inspectcodes"></param>
        private void Inspect_Measure_Elapsed(List<Item_inspectPair> item_inspectcodes)
        {
            iCnt++;
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            StreamWriter sw = null;
            runevent?.Invoke(measurecnt, item_inspectcodes.Count, 0, 0);

            try
            {
                Item_inspectPair pair = item_inspectcodes.ElementAt(measurecnt++);
                DateTime now = DateTime.Now;
                sw = new StreamWriter($"{writefolder}\\{now.ToString("yyyyMMddHHmmss")}Inspect_MeasureLog_{machineID}_{iCnt}.log", false);
                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}/Machine_{machineID}/{workorderno}/{userid}/{wccode}/{processcode}/{pair.Inspectcode}/{pair.Itemcode}/{rnd.Next(pair.LSLx1000, pair.USLx1000) / 1000m}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch(ArgumentOutOfRangeException)
            { // 해당 번째 inspect가 존재하지 않을 때
                MachineStop(MachineType.Inspect_Measure);
                return;
            }
            catch (Exception ee)
            {
                Log.WriteError("오류 : ", ee);
            }
        }
    }
}
