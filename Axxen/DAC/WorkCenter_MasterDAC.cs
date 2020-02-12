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
        /// 모든 작업장 + 공정명
        /// </summary>
        /// <returns></returns>
        public List<WorkCenter_Master2VO> GetAll_WorkCenter_Master()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" select Wc_Code,Wc_Name,w.Process_Code,Process_name,Wo_Status,Last_Cnt_Time,Prd_Req_Type,Pallet_YN,Item_Code,Prd_Unit,Mold_Setup_YN,w.Use_YN,w.Remark
from WorkCenter_Master w , Process_Master p
where w.Process_Code = p.Process_Code and p.Use_YN='Y'";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkCenter_Master2VO> list = Helper.DataReaderMapToList<WorkCenter_Master2VO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 작업장 검색
        /// </summary>
        /// <returns></returns>
        public WorkCenter_Master2VO GetAll_WorkCenter_Master(string wccode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" select Wc_Code,Wc_Name,w.Process_Code,Process_name,Wo_Status,Last_Cnt_Time,Prd_Req_Type,Pallet_YN,Item_Code,Prd_Unit,Mold_Setup_YN,w.Use_YN,w.Remark
from WorkCenter_Master w , Process_Master p
where w.Process_Code = p.Process_Code and p.Use_YN='Y' and w.Wc_Code = @wccode AND w.Use_YN = 'Y'; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", wccode);    

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkCenter_Master2VO> list = Helper.DataReaderMapToList<WorkCenter_Master2VO>(reader);
                comm.Connection.Close();

                return list==null ? null: list[0];
            }
        }

        /// <summary>
        /// 작업장사용유무
        /// </summary>
        /// <param name="code"></param>
        /// <param name="use"></param>
        /// <returns></returns>
        public bool UsedWorkCenter_Master2VO(string code, string use)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = $"update WorkCenter_Master set Use_YN=@Use_YN where Wc_Code=@Wc_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Wc_Code", code);
                comm.Parameters.AddWithValue("@Use_YN", use);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }
        }


        /// <summary>
        /// 작업장추가
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool InsertWorkservice(WorkCenter_Master2VO item)
        {
            try
            {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = $"insert into WorkCenter_Master(Wc_Code,Wc_Name,Process_Code,Remark,Ins_Date,Ins_Emp) values(@Wc_Code,@Wc_Name,@Process_Code,@Remark,'{DateTime.Now.ToShortDateString()}',@Ins_Emp)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Wc_Code", item.Wc_Code);
                comm.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                comm.Parameters.AddWithValue("@Process_Code", item.Process_Code);
                comm.Parameters.AddWithValue("@Remark", item.Remark);
                    comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

                    comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }

            }
            catch 
            {

              
                throw;
            }
        }
       
        /// <summary>
        /// 작업장삭제
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool DeleteWorkCenter_Master2VO(string workcode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = $"delete from WorkCenter_Master where Wc_Code=@Wc_Code";
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@Wc_Code", workcode);               
                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }

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
        FROM[dbo].[WorkCenter_Master]  WHERE Use_YN = 'Y'; ";
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
