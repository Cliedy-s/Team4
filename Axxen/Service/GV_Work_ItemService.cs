using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class GV_Work_ItemService
    {
        public List<GV_Work_ItemVO> GetAllGV_Work_Item() //PRM_PRF_005 전체 컬럼 가지고오기
        {
            GV_Work_ItemDAC dac = new GV_Work_ItemDAC();

            return dac.GetAllGV_Work_Item();
        }
    }
}
