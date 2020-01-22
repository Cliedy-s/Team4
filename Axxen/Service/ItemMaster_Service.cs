using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    
    public class ItemMaster_Service
    {
        ItemMasterDAC DAC;
        public ItemMaster_Service()
        {
             DAC = new ItemMasterDAC();
        }
      public List<Item_Level_Master> GetAllItem_Level_Master()
        {

            return DAC.GetAllItem_Level_Master();
        }
        /// <summary>
        /// 그룹 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool Use_YNItem_Level_Master(string groupcode, string used)
        {
            return DAC.Use_YNItem_Level_Master(groupcode, used);
        }

        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_MasterVO> GetAllItem_Master()
        {
            return DAC.GetAllItem_Master();
        }

        public bool InsertUpdateAllItem_Master(Item_MasterVO item)
        {
            
            return DAC.InsertUpdateAllItem_Master(item);
        }

        public List<Item_Goods_HistoryVO> GetworkOrder_Item_Goods()
        {
            return DAC.GetworkOrder_Item_Goods();
        }

            public List<Item_Goods_HistoryVO> GetDatePicker_work_ltem_Goods(string Adatetimepicker1, string Adatetimepicker2) //PRM_PRF_004 전체 컬럼 가지고오기
        {
            return DAC.GetDatePicker_work_ltem_Goods(Adatetimepicker1, Adatetimepicker2);
        }
    }
}
