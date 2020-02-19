using API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class Item_MasterDAC : DACParent
    {

        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<string> GetAllItem_Master()
        {
       

            List<string> list = new List<string>();

            string sql = "GetAllItem_Master";
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
 
                    while (reader.Read())
                    {
                        list.Add(reader[1].ToString());
                    }
                }
            }
            return list;

        }

        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_MasterVO> GetAllItem_Master2()
        {
            try
            {
                List<Item_MasterVO> Itemlist = null;
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = "GetAllItem_Master";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Connection.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    Itemlist = Helper.DataReaderMapToList<Item_MasterVO>(reader);
                    com.Connection.Close();

                    return Itemlist;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_Master_and_woreqtVO> GetDetailsItem_MasterDAC(string id)
        {
            try
            {
                List<Item_Master_and_woreqtVO> Itemlist = null;
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = @"/****** SSMS의 SelectTopNRows 명령 스크립트 ******/
SELECT  [Item_Code]
      ,[Item_Name]
      ,[Item_Name_Eng]
      ,[Item_Name_Eng_Alias]
      ,[Item_Type]
      ,[Item_Spec]
      ,[Item_Unit]
      ,[Level_1]
      ,[Level_2]
      ,[Level_3]
      ,[Level_4]
      ,[Level_5]
      ,[Item_Stock]
      ,[Lead_Time]
      ,[LotSize]
      ,[PrdQty_Per_Hour]
      ,[PrdQTy_Per_Batch]
      ,[Cavity]
      ,[Line_Per_Qty]
      ,[Shot_Per_Qty]
      ,[Dry_GV_Qty]
      ,[Heat_GV_Qty]
      ,[Remark]
      ,[Use_YN]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]
  FROM [dbo].[Item_Master] where [Item_Code] = @Item_Code";
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@Item_Code", id);
                    com.Connection.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    Itemlist = Helper.DataReaderMapToList<Item_Master_and_woreqtVO>(reader);
                    com.Connection.Close();

                    return Itemlist;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool InsertItem_Master_and_woreqtVO(Item_Master_and_woreqtVO notice)
        {
            string sql = "Insert into Wo_Req ( Wo_Req_No, Item_Code, Req_Qty, Prd_Plan_Date, Cust_Name, Project_Name, Sale_Emp, Req_Status, Ins_Date, Ins_Emp)" +
                "  values( @Wo_Req_No, @Item_Code, @Req_Qty, @Prd_Plan_Date, @Cust_Name, @Project_Name, '김이박', '대기', @Ins_Date, @Ins_Emp)";

            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Wo_Req_No", notice.Wo_Req_No);
        
                cmd.Parameters.AddWithValue("@Item_Code", notice.Item_Code);
                cmd.Parameters.AddWithValue("@Req_Qty", notice.Req_Qty);
                cmd.Parameters.AddWithValue("@Prd_Plan_Date", notice.Prd_Plan_Date);
                cmd.Parameters.AddWithValue("@Cust_Name", notice.Cust_Name);
                cmd.Parameters.AddWithValue("@Project_Name", notice.Project_Name);
                cmd.Parameters.AddWithValue("@Ins_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Ins_Emp", UserInfo.User_Name);


                conn.Open();
                int iResult = cmd.ExecuteNonQuery();
                conn.Close();
                return (iResult > 0);
            }

        }


    }
}