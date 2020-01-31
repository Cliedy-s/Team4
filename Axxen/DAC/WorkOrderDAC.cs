using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class WorkOrderDAC : DACParent
    {
        public List<WorkOrder_J_WC_ItmeVO> GetAll_WorkOrder_Item_WC() //PRM_PRF_001 그리드뷰 사용
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAll_WorkOrder_Item_WC";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkOrder_J_WC_ItmeVO> list = Helper.DataReaderMapToList<WorkOrder_J_WC_ItmeVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        public List<WorkOrder_J_WC_ItmeVO> GetDatePicker_WorkOrder_Item_WC(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_001 DateTimePicker 사용
        {
            List<WorkOrder_J_WC_ItmeVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select ROW_NUMBER() OVER(ORDER BY wo.Wo_Status) Num,Prd_Date, wo.Wo_Status,wo.Workorderno,wo.Item_Code,Item_Name,Wc_Name,Process_name, wo.In_Qty_Main,wo.Out_Qty_Main,wo.Prd_Qty " +
                             $"from WorkOrder wo INNER JOIN Item_Master im  ON wo.Item_Code=im.Item_Code " +
                             $"INNER JOIN WorkCenter_Master wm ON wo.Wc_Code=wm.Wc_Code " +
                             $"INNER JOIN Process_Master pm ON wm.Process_code= pm.Process_code " +
                             $"where Prd_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<WorkOrder_J_WC_ItmeVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
        public List<Goods_In_History_J_Pallet_BoxingVO> GetGoodsIH_PalletM_Boxing(string Workorderno) //PRM_PRF_002 그리드뷰 사용
        {
            List<Goods_In_History_J_Pallet_BoxingVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "GetGoodsIH_PalletM_Boxing";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Workorderno", Workorderno);
                    list = Helper.DataReaderMapToList<Goods_In_History_J_Pallet_BoxingVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }


        public bool UPDATE_Prd_Qty(string Prd_Qty, string Num, string Wo_Status, string Workorderno, string Item_Code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = $"WITH PRM_PRF_001_1(Num,Prd_Date,Wo_Status,Workorderno,Item_Code,Item_Name,Wc_Name,Process_name,In_Qty_Main,Out_Qty_Main,Prd_Qty) " +
                    $"AS(select ROW_NUMBER() OVER(ORDER BY wo.Wo_Status) Num, Prd_Date, wo.Wo_Status, wo.Workorderno, wo.Item_Code, Item_Name, Wc_Name, Process_name, wo.In_Qty_Main, wo.Out_Qty_Main, wo.Prd_Qty " +
                    $"from WorkOrder wo INNER JOIN Item_Master im  ON wo.Item_Code = im.Item_Code " +
                    $"INNER JOIN WorkCenter_Master wm ON wo.Wc_Code = wm.Wc_Code " +
                    $"INNER JOIN Process_Master pm ON wm.Process_code = pm.Process_code) " +
                    $"UPDATE PRM_PRF_001_1 SET Prd_Qty=@Prd_Qty WHERE Num=@Num and Wo_Status=@Wo_Status and Workorderno=@Workorderno and Item_Code=@Item_Code";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Prd_Qty", Prd_Qty);
                cmd.Parameters.AddWithValue("@Num", Num);
                cmd.Parameters.AddWithValue("@Wo_Status", Wo_Status);
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);
                cmd.Parameters.AddWithValue("@Item_Code", Item_Code);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return result > 0;
            }
        }

        public bool UPDATE_Grade_Detail_Name(string Workorderno,string Pallet_No, string Grade_Detail_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = $"UPDATE Pallet_Master SET Grade_Detail_Name=@Grade_Detail_Name where Workorderno = @Workorderno AND Pallet_No=@Pallet_No";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Grade_Detail_Name", Grade_Detail_Name);
                cmd.Parameters.AddWithValue("@Pallet_No", Pallet_No);
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return result > 0;
            }
        }

        public bool UpdatePalletUse(List<string> chkPalletNo) //팔렛트 마감
        {
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("UPDATE Pallet_Master SET Use_YN='Y' where Pallet_No = @Pallet_No AND Use_YN<>'Y' ", conn))
                {                    
                    try
                    {
                        cmd.Transaction = tran;
                        for (int i = 0; i < chkPalletNo.Count; i++)
                        {              
                           //cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Pallet_No", chkPalletNo[i]);
                            int iResult = cmd.ExecuteNonQuery();
                            if (iResult < 1)
                                throw new Exception("오류");
                            
                            cmd.Parameters.Clear();
                        }

                        tran.Commit();
                        conn.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }

        public string UpdateWo_Status(List<WorkOrder_J_WC_ItmeVO> list) // 작업지시 마감
        {
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string chksql = "select count(Use_YN) from Pallet_Master where Workorderno = @Workorderno AND Use_YN='N'";
                    using (SqlCommand cmdchk = new SqlCommand(chksql, conn))
                    {
                        cmdchk.Transaction = tran;
                        for (int i = 0; i < list.Count; i++)
                        {
                            //cmd.CommandType = CommandType.Text;
                            cmdchk.Parameters.AddWithValue("@Workorderno", list[i].Workorderno);
                            int iResult = Convert.ToInt32(cmdchk.ExecuteScalar());
                            if (iResult > 0)
                                throw new Exception("선택한 작업지시 목록에 속한 모든 팔렛트를 마감되어야 합니다.");

                            cmdchk.Parameters.Clear();
                        }
                    }
                    //------------------------------------------------------------- 
                    string Stsql = @"WITH PRM_PRF_002(Num,Prd_Date,Wo_Status,Workorderno,Item_Code,Item_Name,Wc_Name,Process_name,In_Qty_Main,Out_Qty_Main,Prd_Qty)
                            AS(select ROW_NUMBER() OVER(ORDER BY wo.Wo_Status) Num, Prd_Date, wo.Wo_Status, wo.Workorderno, wo.Item_Code, Item_Name, Wc_Name, Process_name, wo.In_Qty_Main, wo.Out_Qty_Main, wo.Prd_Qty
                            from WorkOrder wo INNER JOIN Item_Master im  ON wo.Item_Code = im.Item_Code
                            INNER JOIN WorkCenter_Master wm ON wo.Wc_Code = wm.Wc_Code 
                            INNER JOIN Process_Master pm ON wm.Process_code = pm.Process_code) 
                            UPDATE PRM_PRF_002 SET Wo_Status='현장마감' WHERE Wo_Status<>'현장마감' and Workorderno=@Workorderno and Item_Code=@Item_Code;";
                    using (SqlCommand cmd = new SqlCommand(Stsql, conn))
                    {                            
                        cmd.Transaction = tran;
                        for (int i = 0; i < list.Count; i++)
                        {
                            //cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Workorderno", list[i].Workorderno);
                            cmd.Parameters.AddWithValue("@Item_Code", list[i].Item_Code);

                            int iResult = cmd.ExecuteNonQuery();
                            if (iResult < 1)
                                throw new Exception("선택하신 작업지시상태 목록 중에 이미 마감처리된 목록이 있습니다.");

                            cmd.Parameters.Clear();
                        }

                        tran.Commit();                            
                        return "OK";
                    }
                }
                catch (Exception err)
                {
                    tran.Rollback();
                    return err.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
        //pop
        /// <summary>
        /// 작업장으로 작업지시현황 가져오기
        /// </summary>
        /// <param name="woinichar"></param>
        /// <returns></returns>
        public List<WorkOrderVO> GetAllWorkOrder_AlloHisDetail_Item_Wc(string woinichar)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
@"SELECT wo.[Workorderno] 
		,wo.[Wc_Code] 
		,wo.[Wo_Status] 
        ,wo.[Plan_Date]
		,ahd.[User_ID] 
		,im.[Item_Code] 
		,im.[Item_Name] 
		,wo.[Prd_Unit] 
		,wo.[Prd_Qty] 
		,wo.[Prd_Starttime] 
		,wo.[Prd_Endtime] 
		,wcm.[Wo_Ini_Char] 
  FROM [WorkOrder] wo 
    LEFT OUTER JOIN [WorkCenter_Master] as wcm ON wcm.[Wc_Code] = wo.[Wc_Code] 
    LEFT OUTER JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code] 
    LEFT OUTER JOIN [Emp_Allocation_History_Detail] as ahd ON ahd.[Workorderno] = wo.[Workorderno]
   WHERE wo.[Wo_Status]  <> '마감' ;";
 // TODO - 작업장 생성될 시 추가해주기 //WHERE wcm.[Wo_Ini_Char] =@woinichar; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@woinichar", woinichar);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 작업지시등록
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool InsertWorkOrder(WorkOrderNewVO item)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"   INSERT INTO [WorkOrder]
           ([Workorderno]
           ,[Item_Code]
           ,[Wc_Code]
           ,[Plan_Qty]
           ,[Plan_Unit]
           ,[Plan_Date]
           ,[Wo_Status]
           ,[Wo_Order]
           ,[Wo_Req_No]
           ,[Req_Seq]
           ,[Mat_LotNo]
           ,[Ins_Date]
           ,[Ins_Emp])
     VALUES
           (@Workorderno 
           ,@Item_Code 
           ,@Wc_Code 
           ,@Plan_Qty 
           ,@Plan_Unit
           ,getdate()
           ,@Wo_Status
           ,@Wo_Order
           ,@Wo_Req_No
           ,@Req_Seq
           ,@Mat_LotNo
           ,getdate()
           ,@Ins_Emp
);  ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                comm.Parameters.AddWithValue("@Item_Code", item.Item_Code);
                comm.Parameters.AddWithValue("@Wc_Code", item.Wc_Code);
                comm.Parameters.AddWithValue("@Plan_Qty", item.Plan_Qty);
                comm.Parameters.AddWithValue("@Plan_Unit", item.Plan_Unit);
                comm.Parameters.AddWithValue("@Wo_Status", item.Wo_Status);
                comm.Parameters.AddWithValue("@Wo_Order", item.Wo_Order);
                comm.Parameters.AddWithValue("@Wo_Req_No", item.Wo_Req_No);
                comm.Parameters.AddWithValue("@Req_Seq", item.Req_Seq);
                comm.Parameters.AddWithValue("@Mat_LotNo", item.Mat_LotNo);
                comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 작업지시 시작
        /// </summary>
        /// <returns></returns>
        public bool UpdateWorkOrderStart(string workorderno, string prdunit, string username)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  UPDATE [dbo].[WorkOrder]
   SET 
      [Wo_Status] = '시작'
      ,[Prd_Starttime] = getdate()
      ,[Prd_Unit] = @Prd_Unit
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [Workorderno] = @WorkorderNo; 
";
                comm.Parameters.AddWithValue("@Prd_Unit", prdunit);
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@WorkorderNo", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 작업지시 종료
        /// </summary>
        /// <returns></returns>
        public bool UpdateWorkOrderEnd(string workorderno, int outqty, int prdqty, string username )
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  UPDATE [dbo].[WorkOrder]
   SET 
     [Prd_Date] = getdate()
      ,[Wo_Status] = '종료'
      ,[Prd_Endtime] = getdate()
      ,[Out_Qty_Main] = @Out_qty_Main
      ,[Prd_Qty] = @Prd_Qty
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [Workorderno] = @workorderno; 
";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Out_qty_Main", outqty);
                comm.Parameters.AddWithValue("@Prd_Qty", prdqty);
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 옮겨타기
        /// </summary>
        /// <param name="workorderno"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        public bool UpdateTransferQty(string togvcode, string fromgvcode, int qty, string workorderno, string wccode, string username)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
                 @"UpdateTransferQty";
                //                INSERT INTO[dbo].[GV_History]
                //        ([GV_Code]
                //          ,[Workorderno]
                //          ,[Loading_Date]
                //          ,[Loading_time]
                //          ,[Loading_Qty]
                //          ,[Loading_Wc]
                //          ,[Ins_Date]
                //          ,[Ins_Emp]
                //          ,[Up_Date]
                //          ,[Up_Emp])
                //    VALUES
                //          (@togvcode
                //          , @workorderno
                //          , getdate()
                //          , getdate()
                //          , @qty
                //          , @wccode
                //          , getdate()
                //          , @username
                //          , getdate()
                //          , @username)
                // INSERT INTO[dbo].[GV_Current_Status]
                //        ([GV_Code]
                //          ,[Workorderno]
                //          ,[GV_Qty]
                //          ,[GV_Rest_Qty]
                //          ,[Loading_date]
                //          ,[Loading_time]
                //          ,[Loading_Wc]
                //          ,[Ins_Date]
                //          ,[Ins_Emp]
                //          ,[Up_Date]
                //          ,[Up_Emp])
                //    VALUES
                //          (@togvcode
                //          , @workorderno
                //          , @qty
                //          , 100
                //          , getdate()
                //          , getdate()
                //          , @wccode
                //          , getdate()
                //          , @username
                //          , getdate()
                //          , @username)
                //UPDATE[dbo].[GV_History]
                //        SET[Unloading_Qty] = @qty
                //      ,[Unloading_date] = getdate()
                //      ,[Unloading_datetime] = getdate()
                //      ,[Unloading_wc] = @wccode
                //      ,[Target_GV] = @togvcode
                //      ,[Up_Date] = getdate()
                //      ,[Up_Emp] = @username
                //WHERE[GV_Code] = @fromgvcode
                //,[Workorderno] = @workorderno
                //,[Unloading_datetime] = null
                // UPDATE[dbo].[GV_Current_Status]
                //        SET[GV_Qty] = @qty
                //      ,[GV_Rest_Qty] = [GV_Rest_Qty]+1
                //      ,[Unloading_date] = getdate()
                //      ,[Unloading_time] = getdate()
                //      ,[Up_Date] = getdate()
                //      ,[Up_Emp] = @username
                //WHERE[GV_Code] = @fromgvcode
                //,[Workorderno] = @workorderno
                //,[Unloading_time] = null
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@togvcode", togvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@qty", qty);
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@fromgvcode", fromgvcode);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        } // TODO : 프로시저 생성하기
        /// <summary>
        /// 로딩
        /// </summary>
        /// <param name="togvcode"></param>
        /// <param name="fromgvcode"></param>
        /// <param name="qty"></param>
        /// <param name="workorderno"></param>
        /// <param name="wccode"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool InsertLoadQty(string togvcode, int qty, string workorderno, string wccode, string username)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
                 @"InsertLoadQty";
                // INSERT INTO[dbo].[GV_History]
                //        ([GV_Code]
                //          ,[Workorderno]
                //          ,[Loading_Date]
                //          ,[Loading_time]
                //          ,[Loading_Qty]
                //          ,[Loading_Wc]
                //          ,[Ins_Date]
                //          ,[Ins_Emp]
                //          ,[Up_Date]
                //          ,[Up_Emp])
                //    VALUES
                //          (@togvcode
                //          , @workorderno
                //          , getdate()
                //          , getdate()
                //          , @qty
                //          , @wccode
                //          , getdate()
                //          , @username
                //          , getdate()
                //          , @username)
                // INSERT INTO[dbo].[GV_Current_Status]
                //        ([GV_Code]
                //          ,[Workorderno]
                //          ,[GV_Qty]
                //          ,[GV_Rest_Qty]
                //          ,[Loading_date]
                //          ,[Loading_time]
                //          ,[Loading_Wc]
                //          ,[Ins_Date]
                //          ,[Ins_Emp]
                //          ,[Up_Date]
                //          ,[Up_Emp])
                //    VALUES
                //          (@togvcode
                //          , @workorderno
                //          , @qty
                //          , 100
                //          , getdate()
                //          , getdate()
                //          , @wccode
                //          , getdate()
                //          , @username
                //          , getdate()
                //          , @username)
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@togvcode", togvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@qty", qty);
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@username", username);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            } // TODO - 프로시저 만들기
        }
    }

}
