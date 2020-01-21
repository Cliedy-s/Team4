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
  public  class ItemMasterDAC : DACParent
    {
        /// <summary>
        /// 품목그룹정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_Level_MasterVO> GetAllItem_Level_Master()
        {
            List<Item_Level_MasterVO> ItemGroup = null;
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "GetAllItem_Level_Master";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                ItemGroup = Helper.DataReaderMapToList<Item_Level_MasterVO>(reader);
                com.Connection.Close();

                return ItemGroup;
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
