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
        /// 그룹 저장 수정
        /// </summary>
        /// <returns></returns>
        public bool InsertUpdateItem_Level_Master(Item_Level_Master item)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "InsertUpdateItem_Level_Master";
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@Level_Code", item.Level_Code);
                    comm.Parameters.AddWithValue("@Level_Name", item.Level_Name);
                    comm.Parameters.AddWithValue("@Item_lvl1", item.Item_lvl1);
                    comm.Parameters.AddWithValue("@Item_lvl2", item.Item_lvl2);
                    comm.Parameters.AddWithValue("@Item_lvl3", item.Item_lvl3);
                    comm.Parameters.AddWithValue("@Item_lvl4", item.Item_lvl4);
                    comm.Parameters.AddWithValue("@Item_lvl5", item.Item_lvl5);
                    comm.Parameters.AddWithValue("@Box_Qty", item.Box_Qty);
                    comm.Parameters.AddWithValue("@Pcs_Qty", item.Pcs_Qty);
                    comm.Parameters.AddWithValue("@Mat_Qty", item.Mat_Qty);
                    comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    else
                        return false;

                }
            }
            catch
            {
           
                return false;
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
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
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
                    comm.Parameters.AddWithValue("@PrdQty_Per_Hour", item.PrdQty_Per_Hour);
                    comm.Parameters.AddWithValue("@PrdQTy_Per_Batch", item.PrdQTy_Per_Batch);
                    comm.Parameters.AddWithValue("@Cavity", item.Cavity);
                    comm.Parameters.AddWithValue("@Line_Per_Qty", item.Line_Per_Qty);
                    comm.Parameters.AddWithValue("@Shot_Per_Qty", item.Shot_Per_Qty);
                    comm.Parameters.AddWithValue("@Dry_GV_Qty", item.Dry_GV_Qty);
                    comm.Parameters.AddWithValue("@Heat_GV_Qty", item.Heat_GV_Qty);
                    comm.Parameters.AddWithValue("@Ins_Date", item.Ins_Date);
                    comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);




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


        public List<Item_Goods_HistoryVO> GetDatePicker_work_ltem_Goods(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_003 DateTimePicker 사용
        {
            List<Item_Goods_HistoryVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select Prd_Date,wo.Item_Code,Item_Name,Pallet_No,Plan_Qty,Worker_CloseTime,Close_CancelTime,Upload_Flag,wo.Workorderno,Wo_Status from workOrder wo INNER JOIN Item_Master im ON wo.Item_Code = im.Item_Code INNER JOIN Goods_In_History gih ON wo.Workorderno = gih.Workorderno  where Prd_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}' Order By Prd_Date Desc";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<Item_Goods_HistoryVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

    }
}
