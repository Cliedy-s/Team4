using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VO;

namespace DAC
{
    public class MoldDAC : DACParent
    {
        /// <summary>
        /// 금형등록 정보조회
        /// </summary>
        /// <returns></returns>
        public List<MoldVO> SelectMoldAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SelectMoldAll";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 성형작업 종료
        /// </summary>
        /// <returns></returns>
        public bool InsertUpdateEndMoldWork(string userid, string moldcode, string workorderno, int prdcnt, int shotcnt)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "InsertUpdateEndMoldWork";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@userid", userid);
                comm.Parameters.AddWithValue("@moldcode", moldcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@prdcnt", prdcnt);
                comm.Parameters.AddWithValue("@shotcnt", shotcnt);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 금형그룹 조회
        /// </summary>
        /// <returns></returns>
        public List<MoldVO> SelectMoldGroup()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "select distinct Mold_Group from Mold_Master";

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 금형사용정보조회
        /// </summary>
        /// <returns></returns>
        public List<Mold_J_Item_Wc_MuseVO> SelectMold_Item_Wc_Muse()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SelectMold_Item_Wc_Muse";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Mold_J_Item_Wc_MuseVO> list = Helper.DataReaderMapToList<Mold_J_Item_Wc_MuseVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 금형정보등록
        /// </summary>
        /// <param name="minfo">금형정보가담긴VO</param>
        /// <returns>true/false</returns>
        public bool InsertMold(MoldVO minfo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"insert into Mold_Master( Mold_Code,Mold_Name,Mold_Group,Mold_Status,Cum_Shot_Cnt,Cum_Prd_Qty
      ,Cum_Time,Guar_Shot_Cnt,Purchase_Amt,In_Date,Last_Setup_Time,Wc_Code,Remark
      ,Use_YN,Ins_Date,Ins_Emp,Up_Date,Up_Emp) values ( @Mold_Code, @Mold_Name, @Mold_Group, @Mold_Status, @Cum_Shot_Cnt, @Cum_Prd_Qty
      , @Cum_Time, @Guar_Shot_Cnt, @Purchase_Amt, @In_Date, @Last_Setup_Time, @Wc_Code,@Remark
      , @Use_YN, SYSDATETIME(),'김상영', SYSDATETIME(),'김상영')";

                comm.Parameters.AddWithValue("@Mold_Code", minfo.Mold_Code);
                comm.Parameters.AddWithValue("@Mold_Name", minfo.Mold_Name);
                comm.Parameters.AddWithValue("@Mold_Group", minfo.Mold_Group);
                comm.Parameters.AddWithValue("@Mold_Status", minfo.Mold_Status);
                comm.Parameters.AddWithValue("@Cum_Shot_Cnt", minfo.Cum_Shot_Cnt);
                comm.Parameters.AddWithValue("@Cum_Prd_Qty", minfo.Cum_Prd_Qty);
                comm.Parameters.AddWithValue("@Cum_Time", minfo.Cum_Time);
                comm.Parameters.AddWithValue("@Guar_Shot_Cnt", minfo.Guar_Shot_Cnt);
                comm.Parameters.AddWithValue("@Purchase_Amt", minfo.Purchase_Amt);
                comm.Parameters.AddWithValue("@In_Date", minfo.In_Date);
                comm.Parameters.AddWithValue("@Last_Setup_Time", minfo.Last_Setup_Time);
                comm.Parameters.AddWithValue("@Wc_Code", minfo.Wc_Code);
                comm.Parameters.AddWithValue("@Remark", minfo.Remark);
                comm.Parameters.AddWithValue("@Use_YN", minfo.Use_YN);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }

        /// <summary>
        /// 금형정보 등록에 필요한 작업장정보 조회
        /// </summary>
        /// <returns></returns>
        /// 
        public DataSet MoldWorkCenter()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "select Wc_Code, Wc_Name from WorkCenter_Master where Process_Code = 'PC10002'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "Wc");
                conn.Close();
            }
            return ds;
        }

        /// <summary>
        /// 금형정보삭제
        /// </summary>
        /// <param name="moldno"></param>
        /// <returns></returns>
        public bool DeleteMold(string moldno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "Delete from Mold_Master where Mold_Code = @Mold_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Mold_Code", moldno);
                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }

        //pop
        /// <summary>
        /// 금형 검색
        /// </summary>
        /// <param name="wccode"></param>
        /// <param name="wcstatus"></param>
        /// <returns></returns>
        public List<MoldVO> GetMoldList(string wccode = null, string moldstatus = null)
        { // 현재 작업장 코드
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"GetMoldList";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@Mold_Status", moldstatus);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 장착
        /// </summary>
        /// <returns></returns>
        public bool UpdateEquipMold(string wccode, string moldcode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
@"UPDATE Mold_Master 
 SET Wc_Code = @wccode
       , [Last_Setup_Time] = getdate()
 WHERE Mold_Code = @moldcode; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", wccode);
                //comm.Parameters.AddWithValue("@wccode", (object)wccode ?? DBNull.Value);
                comm.Parameters.AddWithValue("@moldcode", moldcode);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 탈착
        /// </summary>
        /// <returns></returns>
        public bool UpdateEquipMold(string moldcode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
@"UPDATE Mold_Master 
 SET Wc_Code = @wccode
 WHERE Mold_Code = @moldcode; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", DBNull.Value);
                comm.Parameters.AddWithValue("@moldcode", moldcode);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
    }
}
