using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using VO;

namespace MachineService
{
    public partial class Service1 : ServiceBase
    {
        Timer timer;
        string orgfolder = ConfigurationManager.AppSettings["OrgFolder"];
        string donefolder = ConfigurationManager.AppSettings["DoneFolder"];
        int interval = int.Parse(ConfigurationManager.AppSettings["ServiceIntervalMilliSecond"]);
        string strconn = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;
        public Service1()
        {
            InitializeComponent();
        }
        //protected override void OnStart(string[] args)
        //{
        //}
        public void OnStart()
        {
            timer = new Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            Program.Log.WriteInfo("Machine 서비스 프로그램 시작...");
        }
        protected override void OnStop()
        {
            timer.Enabled = false;
            Program.Log.WriteInfo("Machine 서비스 프로그램 종료...");
        }
        MoldService mservice = new MoldService();
        Inspect_Measure_HistoryService imservice = new Inspect_Measure_HistoryService();
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Program.Log.WriteInfo("Machine 서비스 타이머 호출 시작");
            int icnt = 0;
            try
            { // orgFolder 안의 파일을 선택(1초 이전에 최종수정된 파일 목록)
                string[] files = Directory.GetFiles(orgfolder);
                foreach (string file in files)
                {
                    string filename = Path.GetFileName(file);

                    DateTime edittime = File.GetLastWriteTime(file);
                    if ((DateTime.Now - edittime).Seconds > 1)
                    {  // 파일 내용을 읽어서 DB에 Insert
                       //20200131 10:50:45/Machine/1/62/104/1
                        string[] arrData = File.ReadAllText(file).Split('/');

                        // 파일 폴더 이동 (orgfolder/file.log -> orgfolder/donefolder/file.log)
                        Console.WriteLine($"move to {file} -> {Path.Combine(donefolder, Path.GetFileName(file))} ");
                        File.Move(file, Path.Combine(donefolder, Path.GetFileName(file)));
                        icnt++;

                        if (arrData.Length >= 8)
                        {
                            try
                            {
                                filename = filename.Substring(14);
                                if (filename.StartsWith("MoldingLog"))
                                {
                                    // 20200212 20:19:33/Machine_0/WK200212145548/master/WC20001/MOLD003/IC0001/10/0
                                    using (SqlCommand comm = new SqlCommand())
                                    {
                                        comm.Connection = new SqlConnection(strconn);
                                        comm.CommandType = CommandType.StoredProcedure;
                                        comm.CommandText = "InsertUpdateMoldWork";
                                        comm.Parameters.AddWithValue("@userid", arrData[3]);
                                        comm.Parameters.AddWithValue("@moldcode", arrData[5]);
                                        comm.Parameters.AddWithValue("@wccode", arrData[4]);
                                        comm.Parameters.AddWithValue("@workorderno", arrData[2]);
                                        comm.Parameters.AddWithValue("@itemcode", arrData[6]);
                                        comm.Parameters.AddWithValue("@outqty", Convert.ToInt32(arrData[7]));
                                        comm.Parameters.AddWithValue("@badqty", Convert.ToInt32(arrData[8]));

                                        comm.CommandType = CommandType.StoredProcedure;
                                        comm.Connection.Open();
                                        int result = comm.ExecuteNonQuery();
                                        comm.Connection.Close();
                                    }
                                }
                                else if (filename.StartsWith("BoxingLog"))
                                {
                                    // 20200212 20:33:36/Machine_0/WK200212145551/master/WC50001/Blank/IC0001/10/4
                                    //  comm.CommandText = "INSERT INTO WorkQtyLog (ProductID, MachineID, Qty, BadQty) VALUES(@ProductID, @MachineID, @Qty, @BadQty); ";
                                }
                                else if (filename.StartsWith("Inspect_MeasureLog"))
                                {
                                    // 20200212 20:54:23/Machine_2/WK200212145551/master/WC50001/processcode/ES50002/IC0001/10
                                    using (SqlCommand comm = new SqlCommand())
                                    {
                                        comm.Connection = new SqlConnection(strconn);
                                        comm.CommandText =
                         @" INSERT INTO Inspect_Measure_History( 
 Item_code, Process_code, Inspect_code, Inspect_date, Inspect_datetime 
 , Inspect_val, Workorderno, Ins_Date	, Ins_Emp, Up_Date, Up_Emp) 
 VALUES(	 
@Item_code, 
@Process_code, 
@Inspect_code, 
getdate() , 
getdate(), 
@Inspect_val,
@Workorderno, 
getdate(),
@Ins_Emp,
getdate() ,
@Up_Emp);  ";

                                        comm.CommandType = CommandType.Text;
                                        comm.Parameters.AddWithValue("@Item_code", arrData[7]);
                                        comm.Parameters.AddWithValue("@Process_code", arrData[5]);
                                        comm.Parameters.AddWithValue("@Inspect_code", arrData[6]);
                                        comm.Parameters.AddWithValue("@Inspect_val", Convert.ToDecimal(arrData[8]));
                                        comm.Parameters.AddWithValue("@Workorderno", arrData[2]);
                                        comm.Parameters.AddWithValue("@Ins_Emp", arrData[3]);
                                        comm.Parameters.AddWithValue("@Up_Emp", arrData[3]);

                                        comm.Connection.Open();
                                        int result = comm.ExecuteNonQuery();
                                        comm.Connection.Close();
                                    }
                                }
                            }
                            catch (Exception ee)
                            {
                                Program.Log.WriteError("오류 : ", ee);
                                continue;
                            }
                        }
                    }
                }
                Program.Log.WriteInfo($"{icnt}개 파일 이동 완료");
            }
            catch (Exception err)
            {
                Program.Log.WriteError("오류 : ", err);
            }
            finally
            {
                Program.Log.WriteInfo($"윈도우 서비스 타이머 호출 종료");
            }
        }
    }
}
