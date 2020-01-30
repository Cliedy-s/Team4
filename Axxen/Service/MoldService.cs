using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class MoldService
    {
        /// <summary>
        /// 금형 정보조회
        /// </summary>
        /// <returns></returns>
        public List<MoldVO> SelectMoldAll()
        {
            MoldDAC dac = new MoldDAC();
            return dac.SelectMoldAll();
        }

        /// <summary>
        /// 금형그룹조회
        /// </summary>
        /// <returns></returns>
        public List<MoldVO> selectMoldGroup()
        {
            MoldDAC dac = new MoldDAC();
            return dac.SelectMoldGroup();
        }

        /// <summary>
        /// 금형사용정보조회
        /// </summary>
        /// <returns></returns>
        public List<Mold_J_Item_Wc_MuseVO> SelectMold_Item_Wc_Muse()
        {
            MoldDAC dac = new MoldDAC();
            return dac.SelectMold_Item_Wc_Muse();
        }

        /// <summary>
        /// 금형정보등록
        /// </summary>
        /// <param name="minfo">금형정보가 담긴 VO</param>
        /// <returns>true/false</returns>
        public bool InsertMold(MoldVO minfo)
        {
            MoldDAC dac = new MoldDAC();
            return dac.InsertMold(minfo);
        }

        /// <summary>
        /// 금형정보 등록에 필요한 작업장정보 조회
        /// </summary>
        /// <returns></returns>
        public DataSet MoldWorkCenter()
        {
            MoldDAC dac = new MoldDAC();
            return dac.MoldWorkCenter();
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
