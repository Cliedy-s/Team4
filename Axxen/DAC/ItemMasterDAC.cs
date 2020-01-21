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
    public class ItemMasterDAC : DACParent
    {
        /// <summary>
        /// 품목그룹정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_Level_Master> GetAllItem_Level_Master()
        {
            List<Item_Level_Master> ItemGroup = null;
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "GetAllItem_Level_Master";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                ItemGroup = Helper.DataReaderMapToList<Item_Level_Master>(reader);
                com.Connection.Close();

                return ItemGroup;
            }
        }

        /// <summary>
        /// 그룹 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool Use_YNItem_Level_Master(string groupcode, string used)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "Use_YNItem_Level_Master";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Level_Code", groupcode);
                comm.Parameters.AddWithValue("@Use_YN", used);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteScalar());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }

        }




        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_MasterVO> GetAllItem_Master()
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
        /// 품목정보 수정 캐비티, 성형, shot수 mds_sds_002
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool InsertUpdateAllItem_Master(Item_MasterVO item)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "InsertUpdateAllItem_Master";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Item_Code", item.Item_Code);
                    comm.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                    comm.Parameters.AddWithValue("@Item_Name_Eng", item.Item_Name_Eng);
                    comm.Parameters.AddWithValue("@Item_Name_Eng_Alias", item.Item_Name_Eng_Alias);
                    comm.Parameters.AddWithValue("@Item_Type", item.Item_Type);
                    comm.Parameters.AddWithValue("@Item_Spec", item.Item_Spec);
                    comm.Parameters.AddWithValue("@Item_Unit", item.Item_Unit);
                    comm.Parameters.AddWithValue("@Level_1", item.Level_1);
                    comm.Parameters.AddWithValue("@Level_2", item.Level_2);
                    comm.Parameters.AddWithValue("@Level_3", item.Level_3);
                    comm.Parameters.AddWithValue("@Level_4", item.Level_4);
                    comm.Parameters.AddWithValue("@Level_5", item.Level_5);
                    comm.Parameters.AddWithValue("@Item_Stock", item.Item_Stock);
                    comm.Parameters.AddWithValue("@LotSize", item.LotSize);
                    comm.Parameters.AddWithValue("@PrdQty_Per_Hour", item.PrdQty_Per_Hour);
                    comm.Parameters.AddWithValue("@PrdQTy_Per_Batch", item.PrdQTy_Per_Batch);
            

                    comm.Parameters.AddWithValue("@Cavity", item.Cavity);
                    comm.Parameters.AddWithValue("@Line_Per_Qty", item.Line_Per_Qty);
                    comm.Parameters.AddWithValue("@Shot_Per_Qty", item.Shot_Per_Qty);

                    comm.Parameters.AddWithValue("@Dry_GV_Qty", item.Dry_GV_Qty);

                    comm.Parameters.AddWithValue("@Heat_GV_Qty", item.Heat_GV_Qty);
                    comm.Parameters.AddWithValue("@Remark", item.Remark);
                    comm.Parameters.AddWithValue("@Ins_Date", item.Ins_Date);
                    comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);




                    comm.Connection.Open();
                 int result = comm.ExecuteNonQuery();              
                    comm.Connection.Close();

                    return result > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// PRM_PRF_002
        /// </summary>
        /// <returns></returns>
        public List<Item_Goods_HistoryVO> GetworkOrder_Item_Goods()
        {
            List<Item_Goods_HistoryVO> ItemGroup = null;
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "GetworkOrder_Item_Goods";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                ItemGroup = Helper.DataReaderMapToList<Item_Goods_HistoryVO>(reader);
                com.Connection.Close();

                return ItemGroup;
            }
        }


    }
}
