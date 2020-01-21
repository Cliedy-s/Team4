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
      public List<Item_Level_MasterVO> GetAllItem_Level_Master()
        {

            return DAC.GetAllItem_Level_Master();
        }

        public List<Item_Goods_HistoryVO> GetworkOrder_Item_Goods()
        {

            return DAC.GetworkOrder_Item_Goods();
        }
    }
}
