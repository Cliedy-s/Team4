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

        public List<ScreenItem_AuthorityVO> GetGroupScreenItem(string groupCode)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetGroupScreenItem(groupCode);
        }
    }
}
