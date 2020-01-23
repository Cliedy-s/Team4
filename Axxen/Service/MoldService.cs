using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class MoldService
    {
        public List<MoldVO> SelectMoldAll()
        {
            MoldDAC dac = new MoldDAC();
            return dac.SelectMoldAll();
        }

        public List<Mold_J_Item_Wc_MuseVO> SelectMold_Item_Wc_Muse()
        {
            MoldDAC dac = new MoldDAC();
            return dac.SelectMold_Item_Wc_Muse();
        }

        //pop
        /// <summary>
        /// 장착 가능 금형 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <param name="wcstatus"></param>
        /// <returns></returns>
        public List<MoldVO> SelectEquipableMold(string wccode, string wcstatus)
        { // 현재 작업장 코드, 장착
            MoldDAC dac = new MoldDAC();
            return dac.SelectEquipableMold(wccode, wcstatus);
        }
        /// <summary>
        /// 장착된 금형 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <param name="wcstatus"></param>
        /// <returns></returns>
        public List<MoldVO> SelectEquipedMold(string wccode, string wcstatus)
        { // 현재 작업장코드, 대기
            MoldDAC dac = new MoldDAC();
            return dac.SelectEquipedMold(wccode, wcstatus);
        }
        /// <summary>
        /// 장착/ 탈착
        /// </summary>
        /// <returns></returns>
        public bool UpdateEquipMold(string wccode, string moldcode, string moldstatus)
        {
            //장착
            //현재 작업장코드, 장착
            //탈착
            //빈칸, 대기
            MoldDAC dac = new MoldDAC();
            return dac.UpdateEquipMold(wccode, moldcode, moldstatus);
        }
    }
}
