using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using DAC;
namespace Service
{
   public class ScreenItemService
    {

        /// <summary>
        /// 모든 스크린 아이템
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_MasterVO> GetALLScreenItem()
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetALLScreenItem();
        }

            public List<ScreenItem_AuthorityVO> GetGroupScreenItem(string groupCode)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetGroupScreenItem(groupCode);
        }
    }
}
