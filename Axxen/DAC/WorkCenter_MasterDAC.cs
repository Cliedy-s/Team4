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
    public class WorkCenter_MasterDAC : DACParent
    {
        /// <summary>
        /// 모든 작업장정보를 가져오는 메소드
        /// </summary>
        /// <returns></returns>
        public List<WorkCenter_MasterVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT[Wc_Code]
      ,[Wc_Name]
      ,[Wc_Group]
      ,[Process_Code]
      ,[Auto_Wo_YN]
      ,[Auto_Start_YN]
      ,[ERP_IF_YN]
      ,[Wo_Status]
      ,[Nop_Auto_YN]
      ,[Nop_Check_Time]
      ,[Last_Cnt_Time]
      ,[Gas_UseYN]
      ,[Prd_Req_Type]
      ,[Pallet_YN]
      ,[Item_Code]
      ,[Prd_Unit]
      ,[Mold_Setup_YN]
      ,[In_Qty_Auto_YN]
      ,[Wo_Ini_Char]
      ,[Use_YN]
      ,[Remark]
        FROM[dbo].[WorkCenter_Master]; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkCenter_MasterVO> list = Helper.DataReaderMapToList<WorkCenter_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<WorkCenter_MasterVO> GetCombo1()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select Wc_Code,Wc_Name From WorkCenter_Master where Use_YN='Y'";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkCenter_MasterVO> list = Helper.DataReaderMapToList<WorkCenter_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        
    }
}
