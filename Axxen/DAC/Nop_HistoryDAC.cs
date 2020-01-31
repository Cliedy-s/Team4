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
    public class Nop_HistoryDAC : DACParent
    {
        /// <summary>
        /// 비가동 목록
        /// </summary>
        public List<NopHistoryVO> GetAllNop_History()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"SELECT 	
	 nh.Nop_Seq
	, nh.Nop_Date
	, nh.Nop_Happentime
	, nh.Nop_Canceltime
	, nh.Wc_Code
	, nh.Nop_Mi_Code
	, nh.Nop_Type
	, nh.Nop_Time
	, nim.Nop_Mi_Name
	, nam.Nop_Ma_Name
    , wcm.[Wc_Name] 
 FROM Nop_History as nh
	JOIN Nop_Mi_Master AS nim ON nh.Nop_Mi_Code = nim.Nop_Mi_Code AND nim.Use_YN = 'Y'
	JOIN Nop_Ma_Master AS nam ON nim.Nop_Ma_Code = nam.Nop_Ma_Code AND nam.Use_YN = 'Y'
	JOIN [WorkCenter_Master] as wcm ON wcm.[Wc_Code] = nh.Wc_Code AND wcm.[Use_YN] ='Y'; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopHistoryVO> list = Helper.DataReaderMapToList<NopHistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 비가동 사유변경
        /// </summary>
        /// <param name="nopMiCode"></param>
        /// <param name="username"></param>
        /// <param name="nopseq"></param>
        /// <returns></returns>
        public bool UpdateNop_History(string nopMiCode, string username, int nopseq)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"UPDATE Nop_History  
	SET  
	Nop_Mi_Code = @Nop_Mi_Code 
	, Up_Date = getdate() 
	, Up_Emp = @username 
	WHERE Nop_Seq = @nopseq; ";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Nop_Mi_Code", nopMiCode);
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@nopseq", nopseq);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }

        }

        public bool InsertNop_History(NopHistoryVO nop)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"INSERT INTO Nop_History(Nop_Date, Nop_Happentime, Nop_Canceltime, Wc_Code, Nop_Mi_Code, Nop_Type, Nop_Time, Remark, Ins_Date, Ins_Emp) values(@Nop_Date, @Nop_Happentime, @Nop_Canceltime, @Wc_Code, @Nop_Mi_Code, @Nop_Type, @Nop_Time, @Remark, @Ins_Date, @Ins_Emp)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Nop_Date", nop.Nop_Date);
                comm.Parameters.AddWithValue("@Nop_Happentime", nop.Nop_Happentime);
                comm.Parameters.AddWithValue("@Nop_Canceltime", nop.Nop_Canceltime);
                comm.Parameters.AddWithValue("@Wc_Code", nop.Wc_Code);
                comm.Parameters.AddWithValue("@Nop_Mi_Code", nop.Nop_Mi_Code);
                comm.Parameters.AddWithValue("@Nop_Type", nop.Nop_Type);
                comm.Parameters.AddWithValue("@Nop_Time", nop.Nop_Time);
                comm.Parameters.AddWithValue("@Remark", nop.Remark);
                comm.Parameters.AddWithValue("@Ins_Date", nop.Ins_Date);
                comm.Parameters.AddWithValue("@Ins_Emp", nop.Ins_Emp);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }

        }

        
    }
}
