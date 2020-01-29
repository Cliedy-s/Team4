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

        //pop
        /// <summary>
        /// 장착 가능 금형 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <param name="wcstatus"></param>
        /// <returns></returns>
        public List<MoldVO> SelectEquipableMold(string wccode, string wcstatus)
        { // 현재 작업장 코드, 장착
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = 
@"SELECT mold.Mold_Code
 ,mold.Mold_Name 
 ,mold.Mold_Group 
 ,mold.Mold_Status 
 ,mold.Cum_Shot_Cnt 
 ,mold.Cum_Prd_Qty 
 ,mold.Cum_Time 
 ,mold.Guar_Shot_Cnt 
 ,mold.Purchase_Amt 
 ,mold.In_Date 
 ,mold.Last_Setup_Time 
 ,mold.Wc_Code 
 ,mold.Remark 
 ,mold.Use_YN 
 FROM Mold_Master as mold 
 WHERE mold.Wc_Code = @wccode
    AND mold.Mold_Status = @wcstatus
    AND mold.Use_YN = 1; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@wcstatus", wcstatus);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 장착된 금형 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <param name="wcstatus"></param>
        /// <returns></returns>
        public List<MoldVO> SelectEquipedMold(string wccode, string wcstatus)
        { // 현재 작업장코드, 대기
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
@"SELECT mold.Mold_Code
 ,mold.Mold_Name
 ,mold.Mold_Group
 ,mold.Mold_Status
 ,mold.Cum_Shot_Cnt
 ,mold.Cum_Prd_Qty
 ,mold.Cum_Time
 ,mold.Guar_Shot_Cnt
 ,mold.Purchase_Amt
 ,mold.In_Date
 ,mold.Last_Setup_Time
 ,mold.Wc_Code
 ,mold.Remark
 ,mold.Use_YN
 FROM Mold_Master as mold
 WHERE mold.Wc_Code = @wccode
	AND mold.Mold_Status = @wcstatus
	AND mold.Use_YN = 1
	AND mold.Cum_Shot_Cnt >= mold.Guar_Shot_Cnt; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@wcstatus", wcstatus);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 장착/ 탈착
        /// </summary>
        /// <returns></returns>
        public bool UpdateEquipMold(string wccode, string moldcode, string moldstatus)
        { 
            //장착
            //현재 작업장코드, 장착
            //탈착
            //빈칸, 대기
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText =
     @"UPDATE Mold_Master 
SET mold.Wc_Code = @wccode,  mold.Mold_Status =@moldstatus
WHERE mold.Mold_Code = @moldcode";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@wccode", wccode);
                    comm.Parameters.AddWithValue("@moldstatus", moldstatus);
                    comm.Parameters.AddWithValue("@moldcode", moldcode);

                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    return result > 0;
                }

        }
    }
}
