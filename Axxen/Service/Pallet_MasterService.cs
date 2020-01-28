using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class Pallet_MasterService
    {
        /// <summary>
        /// 팔레트목록 가져오기
        /// </summary>
        public List<PalletVO> GetAllByWorkorderno(string workorderno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetAllByWorkorderno(workorderno);
        }
        /// <summary>
        /// 등급상세정보를 추가한 팔레트목록
        /// </summary>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public List<PalletDetailVO> GetAllDetail(string workorderno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetAllDetail(workorderno);
        }
        /// <summary>
        /// 금일 입고 팔레트 목록
        /// </summary>
        /// <returns></returns>
        public List<PalletTodayInVO> GetPalletTodayIn()
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetPalletTodayIn();
        }
        /// <summary>
        /// 팔레트 생성
        /// </summary>
        public bool InsertPallet(PalletVO item)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.InsertPallet(item);
        }
        /// <summary>
        /// 팔레트입고
        /// </summary>
        /// <returns></returns>
        public bool InputPallet(string username, string workorderno, string palletno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.InputPallet(username, workorderno, palletno);
        }
    }
}
