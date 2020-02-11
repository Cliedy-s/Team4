using AxxenClient.Util;
using log4net.Core;
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
    public enum MachineType { Molding, Boxing, Inspect_Measure }
    public class Item_inspectPair {
        public string Itemcode { get; set; }
        public string Inspectcode { get; set; }
        public int USLx1000 { get; set; }
        public int SLx1000 { get; set; }
        public Item_inspectPair(string itemcode, string inspectcode, decimal USL, decimal SL)
        {
            Itemcode = itemcode;
            Inspectcode = inspectcode;
            USLx1000 = Convert.ToInt32(USL * 1000);
            SLx1000 = Convert.ToInt32(SL * 1000);
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
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("WorkerClient", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }

        System.Timers.Timer timer;
        string writefolder = ConfigurationManager.AppSettings["WriteFolder"];
        int interval = int.Parse(ConfigurationManager.AppSettings["LogCreateMillisecond"]);
        int machineID = 0;
        int iCnt = 0;

        public Machine(int machineID)
        {
            this.machineID = machineID;
            if (!Directory.Exists(writefolder))
                Directory.CreateDirectory(writefolder);
        }
        public void MachineStartMold(string workorderno, Item_MoldPair pair)
        {
            Log.WriteInfo("성형 시작...");
            timer = new System.Timers.Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += (sender, eventargs) => { Mold_Elapsed( workorderno, pair); };
            timer.AutoReset = true;
        }
        public void MachineStartBoxing(string workorderno, string itemcode, int shotQty)
        {
            Log.WriteInfo("포장 시작...");
            timer = new System.Timers.Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += (sender, eventargs) => { Boxing_Elapsed(workorderno, itemcode, shotQty); };
            timer.AutoReset = true;
        }
        public void MachineStartInspectMeasure(string workorderno, List<Item_inspectPair> item_inspectcodes)
        {
            Log.WriteInfo("품질측정 시작...");
            timer = new System.Timers.Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += (sender, eventargs) => { Inspect_Measure_Elapsed( workorderno, item_inspectcodes); };
            timer.AutoReset = true;
        }
        public void MachineStop(MachineType work)
        {
            timer.Stop();
            timer.Dispose();
            string msg = string.Empty;
            switch (work)
            {
                case MachineType.Molding:
                    msg = "성형";
                    break;
                case MachineType.Boxing:
                    msg = "포장";
                    break;
                case MachineType.Inspect_Measure:
                    msg = "품질측정";
                    break;
                default:
                    msg = "";
                    break;
            }
            Log.WriteInfo(msg+" 로그 기록 종료...");
        }
        private void Mold_Elapsed(string workorderno, Item_MoldPair pair)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            int badcnt = rnd.Next(0, 5);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter($"{writefolder}\\MoldingLog_{machineID}_{iCnt}.log", false);
                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}/Machine_{machineID}/{workorderno}/{pair.Moldcode}/{pair.Itemcode}/{pair.Line_Per_Qty}/{badcnt}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                iCnt++;
            }
        }
        private void Boxing_Elapsed(string workorderno, string itemcode, int shotQty)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            int badcnt = rnd.Next(0, 5);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter($"{writefolder}\\BoxingLog_{machineID}_{iCnt}.log", false);
                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}/Machine_{machineID}/{workorderno}/Boxing/{itemcode}/{shotQty}/{badcnt}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                iCnt++;
            }
        }

        int cnt = 0;
        private void Inspect_Measure_Elapsed(string workorderno, List<Item_inspectPair> item_inspectcodes)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            StreamWriter sw = null;
            Item_inspectPair pair = item_inspectcodes[cnt++];
            if (pair == null)
            {
                MachineStop(MachineType.Inspect_Measure);
                return;
            }
            try
            {
                sw = new StreamWriter($"{writefolder}\\Inspect_MeasureLog_{machineID}_{iCnt}.log", false);
                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}/Machine_{machineID}/{workorderno}/{pair.Inspectcode}/{pair.Itemcode}/{rnd.Next(pair.USLx1000, pair.SLx1000) / 1000m}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                iCnt++;
            }
        }
    }
}
