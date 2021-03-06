﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class Wo_ReqDAC : DACParent
    {
        public List<Wo_Req_ItemVO> GetAllWoReq() //PPS_SCH_001 그리드뷰 사용
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllWoReq";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Wo_Req_ItemVO> list = Helper.DataReaderMapToList<Wo_Req_ItemVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 생산의뢰마감처리
        /// </summary>
        /// <param name="woNo">생산의뢰번호</param>
        /// <returns></returns>
        public bool UpdateWoReq(string woNo)
        {
            int result =0;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "update Wo_Req set Req_Status ='마감' where Wo_Req_No = @Wo_Req_No ";
                comm.Parameters.AddWithValue("@Wo_Req_No", woNo);

                comm.Connection.Open();
                result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return (result > 0);
            }
        }

        /// <summary>
        /// 작업지시정보조회
        /// </summary>
        /// <returns></returns>
        public List<WorkOrder_WC_ItemVO> GetWorkOrder()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "select Prd_Date, wo.Wo_Req_No, wo.Req_Seq,wo.Wo_Status,wo.Workorderno,wo.Item_Code,Item_Name,Wc_Name,Plan_Qty,wo.In_Qty_Main,wo.Out_Qty_Main,wo.Prd_Qty,wo.Remark from WorkOrder wo INNER JOIN Item_Master im ON wo.Item_Code = im.Item_Code INNER JOIN WorkCenter_Master wm ON wo.Wc_Code = wm.Wc_Code ";
                //where wo.Item_Code=@Item_Code
                //comm.Parameters.AddWithValue("@Item_Code", code);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkOrder_WC_ItemVO> list = Helper.DataReaderMapToList<WorkOrder_WC_ItemVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }//PPS_SCH_001_Sub그리드뷰

        /// <summary>
        /// 일별실적조회
        /// </summary>
        /// <returns></returns>
        public List<WO_WC_Production_ItemVO> GetWO_WC_Production_Items() //PPS_SCH_003 그리드뷰 사용
        {
            List<WO_WC_Production_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "GetWO_WC_Production_Items";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    list = Helper.DataReaderMapToList<WO_WC_Production_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

        /// <summary>
        /// 작업장조회
        /// </summary>
        /// <returns></returns>
        public List<WorkOrder_J_WC_ItmeVO> GetWorkCenterName()
        {
            List<WorkOrder_J_WC_ItmeVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "select Wc_Code, Wc_Name from WorkCenter_Master where Process_Code = 'PC10002'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<WorkOrder_J_WC_ItmeVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

        /// <summary>
        /// 작업지시상세조회
        /// </summary>
        /// <returns></returns>
        public List<Wo_Req_WO_WC_ItemVO> GetWoReqOrder()
        {
            List<Wo_Req_WO_WC_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "GetWoReqOrder";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    list = Helper.DataReaderMapToList<Wo_Req_WO_WC_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }//PPS_SCH_002그리드뷰

        /// <summary>
        /// 작업지시마감처리
        /// </summary>
        /// <param name="wono">작업지시번호</param>
        /// <returns></returns>
        public bool UpdateWoReqOrder(string wono, string code, string woreqno)
        {
            int result = 0;
            using (SqlCommand comm = new SqlCommand())
            {
                if (code == "PC10005")
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.Connection.Open();
                    SqlTransaction trans = comm.Connection.BeginTransaction();
                    try
                    {
                        comm.Transaction = trans;
                        comm.CommandType = CommandType.Text;
                        comm.CommandText = "update WorkOrder set Wo_Status = '작업지시마감' where Workorderno = @Workorderno ";
                        comm.Parameters.AddWithValue("@Workorderno", wono);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "update Wo_Req set Req_Status ='완료' where Wo_Req_No=@Wo_Req_No";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@Wo_Req_No", woreqno);
                        comm.ExecuteNonQuery();

                        trans.Commit();
                        comm.Connection.Close();

                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        comm.Connection.Close();
                        return false;
                    }
                }
                else
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.Connection.Open();
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "update WorkOrder set Wo_Status = '작업지시마감' where Workorderno = @Workorderno ";
                    comm.Parameters.AddWithValue("@Workorderno", wono);
                    result = comm.ExecuteNonQuery();
                }
                return result > 0;
            }
        }

        /// <summary>
        /// 작업지시마감취소
        /// </summary>
        /// <param name="wono"></param>
        /// <returns></returns>
        public bool CancleWoReqOrder(string wono)
        {
            int result = 0;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "update WorkOrder set Wo_Status = '현장마감' where Workorderno = @Workorderno ";
                comm.Parameters.AddWithValue("@Workorderno", wono);

                comm.Connection.Open();
                result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return (result > 0);
            }
        }

        /// <summary>
        /// 작업지시상태조회
        /// </summary>
        /// <returns></returns>
        public List<WorkOrderVO> GetWoStatus()
        {
            List<WorkOrderVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "select distinct Wo_Status from WorkOrder where Wo_Status = '현장마감' or Wo_Status ='작업지시마감' ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

        //pop
        /// <summary>
        /// 생산의뢰 목록 가져오기
        /// </summary>
        /// <returns></returns>
        public List<Wo_Req_ItemUnitVO> GetAllWoReqUnit(string woorder) 
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"select W.[Wo_Req_No], w.[Req_Seq], i.[Item_Code],i.Item_Name, i.Item_Unit, [Req_Qty], [Prd_Plan_Date], [Cust_Name], [Project_Name], [Sale_Emp], [Req_Status], w.Ins_Date
from Wo_Req w 
	Inner join Item_Master i on w.Item_Code = i.Item_Code 
	WHERE Req_Seq not in (select distinct Req_Seq from workorder where Wo_Order ='5')
	order by w.Req_Seq DESC; 
";
                comm.Parameters.AddWithValue("@woorder", woorder);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Wo_Req_ItemUnitVO> list = Helper.DataReaderMapToList<Wo_Req_ItemUnitVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

    }
}
