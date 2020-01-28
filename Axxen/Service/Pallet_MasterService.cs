using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Pallet_MasterService
    {
        /// <summary>
        /// 팔레트목록 가져오기
        /// </summary>
        public List<PalletVO> GetAll()
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetAll();
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
        /// 존재하는 팔레트인지 확인
        /// </summary>
        public bool IsExistPallet(string palletNo)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.IsExistPallet(palletNo);
        }
        /// <summary>
        /// 바코드번호 가져오기
        /// </summary>
        /// <param name="palletNo"></param>
        /// <returns></returns>
        public string GetBarcodeNo(string palletNo)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetBarcodeNo(palletNo);
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
        /// <summary>
        /// 바코드번호 변경
        /// </summary>
        /// <param name="palletNo"></param>
        /// <returns></returns>
        public bool UpdateBarcodeNo(string palletNo, string barcodeno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.UpdateBarcodeNo(palletNo, barcodeno);
        }
        /// <summary>
        /// 팔레트 삭제
        /// </summary>
        /// <returns></returns>
        public bool DeletePallet(string palletno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.DeletePallet(palletno);
        }
    }
}
