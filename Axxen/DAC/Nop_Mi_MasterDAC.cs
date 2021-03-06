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
    public class Nop_Mi_MasterDAC :DACParent
    {
        /// <summary>
        /// 비가동 소분류 목록
        /// </summary>
        public List<NopMiMasterVO> GetAllNopMi()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Remark
, nim.Ins_Date
, nim.Use_YN
	FROM Nop_Mi_Master AS nim
	WHERE nim.Use_YN = 'Y'; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 비가동 소분류 검색
        /// </summary>
        public List<NopMiMasterVO> GetAllNopMi(string macode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Remark
	FROM Nop_Mi_Master AS nim
	WHERE nim.Use_YN = 'Y' AND nim.Nop_Ma_Code = @macode; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@macode", macode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 비가동 소분류 목록 사용하지 않는 목록도 
        /// </summary>
        public List<NopMiMasterVO> GetAllNopMi2()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Remark
, nim.Ins_Date
, nim.Use_YN
	FROM Nop_Mi_Master AS nim; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 비가동 소분류 사용 유무 
        /// </summary>
        public bool UsedNop_Mi_Masterservice(string  code ,string use)
        {
            try
            {   
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
                    "update Nop_Mi_Master set Use_YN =@Use_YN where Nop_Mi_Code=@Nop_Mi_Code ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Nop_Mi_Code", code);
                comm.Parameters.AddWithValue("@Use_YN", use);
                comm.Connection.Open();
           int result =  comm.ExecuteNonQuery();
            
                comm.Connection.Close();

             

                 if (result > 0)
                        return true;
                    else
                        return false;
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 비가동 상세 추가
        /// </summary>
        public bool InsertUpdateNop_Mi_Master(NopMiMasterVO item)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText =
                       @"IF NOT EXISTS (SELECT Nop_Mi_Code FROM [dbo].[Nop_Mi_Master] WHERE Nop_Mi_Code=@Nop_Mi_Code)
BEGIN
	INSERT INTO [Nop_Mi_Master](Nop_Ma_Code,Nop_Mi_Code,Nop_Mi_Name,Remark,Ins_Date) VALUES(@Nop_Ma_Code,@Nop_Mi_Code,@Nop_Mi_Name,@Remark,GETDATE())
END
ELSE
BEGIN
UPDATE [Nop_Mi_Master] SET Nop_Mi_Name=@Nop_Mi_Name, Remark=@Remark,Up_Date=GETDATE() WHERE Nop_Mi_Code=@Nop_Mi_Code
END";
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                    comm.Parameters.AddWithValue("@Nop_Mi_Code", item.Nop_Mi_Code);
                    comm.Parameters.AddWithValue("@Nop_Mi_Name", item.Nop_Mi_Name);
                    comm.Parameters.AddWithValue("@Remark", item.Remark);

                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
              
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       public bool DeleteNopMiMasterVO(string Micode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "delete from Nop_Mi_Master  where Nop_Mi_Code=@Nop_Mi_Code";
                       
                    comm.CommandType = CommandType.Text;    
                    comm.Parameters.AddWithValue("@Nop_Mi_Code", Micode);
             
               
                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();

                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<NopMiMasterVO> GetCombo() //PRM_PRF_008_1 비가동상세분류코드
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select Nop_Mi_Code,Nop_Mi_Name from Nop_Mi_Master where Use_YN='Y'";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
