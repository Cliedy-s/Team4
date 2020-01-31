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
        /// 금형 검색
        /// </summary>
        /// <param name="wccode"></param>
        /// <param name="wcstatus"></param>
        /// <returns></returns>
        public List<MoldVO> GetMoldList(string wccode = null, string moldstatus = null)
        { // 현재 작업장 코드
            MoldDAC dac = new MoldDAC();
            return dac.GetMoldList(wccode, moldstatus);
        }
        /// <summary>
        /// 장착
        /// </summary>
        /// <returns></returns>
        public bool UpdateEquipMold(string wccode, string moldcode)
        {
            MoldDAC dac = new MoldDAC();
            return dac.UpdateEquipMold(wccode, moldcode);
        }
        /// <summary>
        /// 탈착
        /// </summary>
        /// <returns></returns>
        public bool UpdateEquipMold( string moldcode)
        {
            MoldDAC dac = new MoldDAC();
            return dac.UpdateEquipMold( moldcode);
        }
    }
}
