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
   public class ScreenItemDAC : DACParent
    {

        /// <summary>
        /// 사용자가 속한 그룹의 화면들
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<ScreenItem_AuthorityVO> GetUserInfoScreenItem(List<UserGroup_MappingVO> group)
        {
            List<ScreenItem_AuthorityVO> list = new List<ScreenItem_AuthorityVO>() ;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                for (int i = 0; i < group.Count; i++)
                {
                    cmd.CommandText = "GetUserInfoScreenItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserGroup_Code", group[i].UserGroup_Code);
                

                    cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        ScreenItem_AuthorityVO item = new ScreenItem_AuthorityVO
                        {
                            UserGroup_Code = reader["UserGroup_Code"].ToString(),
                    Screen_Code = reader["Screen_Code"].ToString(),
                        Pre_Type = reader["Pre_Type"].ToString(),
                        Use_YN = reader["Use_YN"].ToString(),
                     

                    };

                        list.Add(item);
                    }
                
                    cmd.Parameters.Clear();
                    cmd.Connection.Close();
                }

                return list;
            }
        }

        /// <summary>
        /// 모든 스크린 아이템
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_MasterVO> GetALLScreenItem()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "GetALLScreenItem";
                cmd.CommandType = CommandType.StoredProcedure;
             

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ScreenItem_MasterVO> list = Helper.DataReaderMapToList<ScreenItem_MasterVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool UsedScreenItem_MasterVO(string screencode, string used)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = $"update ScreenItem_Master set Use_YN=@Use_YN where Screen_Code=@Screen_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Screen_Code", screencode);
                comm.Parameters.AddWithValue("@Use_YN", used);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }

        }
        /// <summary>
        /// 그룹서 사용하는 화면들
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_AuthorityVO> GetUseGroupScreenItem(string groupCode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUseGroupScreenItem";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code", groupCode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ScreenItem_AuthorityVO> list = Helper.DataReaderMapToList<ScreenItem_AuthorityVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
           /// <summary>
        /// 그룹에서 사용하지않는 화면
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_AuthorityVO> GetNotUseGroupScreenItem(string groupCode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetNotUseGroupScreenItem";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code", groupCode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ScreenItem_AuthorityVO> list = Helper.DataReaderMapToList<ScreenItem_AuthorityVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 추가한 항목 저장
        /// </summary>
        /// <param name="List"></param>
        public void InsertUpdateScreenItem_Authority(List<ScreenItem_AuthorityVO> List)
        {
            
           using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);

                for(int i=0; i<List.Count; i++) { 
                comm.CommandText = "InsertUpdateScreenItem_Authority";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code", List[i].UserGroup_Code);
                comm.Parameters.AddWithValue("@Screen_Code", List[i].Screen_Code);
                comm.Parameters.AddWithValue("@Pre_Type", List[i].Pre_Type);
                comm.Parameters.AddWithValue("@Ins_Date", List[i].Ins_Date);
                comm.Parameters.AddWithValue("@Ins_Emp", List[i].Ins_Emp);

                   comm.Connection.Open();
                   comm.ExecuteNonQuery();
                   comm.Parameters.Clear();
                   comm.Connection.Close();
                }          
            }
           
        }
        /// <summary>
        /// 그룹에서 사용하던 화면을 더이상 사용하지않을때. Use_YN==N으로 변경
        /// </summary>
        /// <param name="List"></param>
        public void DeleteGroupUseScreenItem_Authority(string group,List<ScreenItem_AuthorityVO> List)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);

                for (int i = 0; i < List.Count; i++)
                {
                    comm.CommandText = "DeleteGroupUseScreenItem_Authority";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserGroup_Code", group);
                    comm.Parameters.AddWithValue("@Screen_Code", List[i].Screen_Code);

                    comm.Connection.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    comm.Connection.Close();
                }
            }

        }
     
        }
}
