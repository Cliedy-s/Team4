using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        /// 입고안된 팔레트목록 가져오기
        /// </summary>
        public List<PalletVO> GetNotInputed()
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetNotInputed();
        }
        /// <summary>
        /// 팔레트 검색
        /// </summary>
        public PalletVO GetPallet(string palletno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetPallet(palletno);
        }
        /// <summary>
        /// 팔레트 검색하기
        /// </summary>
        public DataTable GetPalletToDT(string palletno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetPalletToDT(palletno);
        }
        /// <summary>
        /// 팔레트목록 날짜로 가져오기
        /// </summary>
        public List<PalletVO> GetAllByDateTime(DateTime fromdate, DateTime todate)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetAllByDateTime(fromdate, todate);
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
        /// 팔레트 정보 가져오기
        /// </summary>
        /// <returns></returns>
        public PalletTodayInVO GetPalletInfo(string palletno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetPalletInfo(palletno);
        }
        /// <summary>
        /// 입고가능한 팔레트 목록
        /// </summary>
        /// <returns></returns>
        public List<PalletTodayInVO> GetInablePallet()
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetInablePallet();
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
        /// 바코드 번호로 팔레트 검색
        /// </summary>
        public PalletVO GetPalletByBarcode(string barcodeNo)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.GetPalletByBarcode(barcodeNo);
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
        /// 팔레트 수량 추가
        /// </summary>
        public bool UpdatePallet(string palletno, int qty)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.UpdatePallet(palletno, qty);
        }
        /// <summary>
        /// 팔레트입고
        /// </summary>
        /// <returns></returns>
        public bool InputPallet(string username, string workorderno, string palletno, int inqty)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.InputPallet(username, workorderno, palletno, inqty);
        }
        /// <summary>
        /// 팔레트입고 여부
        /// </summary>
        /// <returns></returns>
        public bool IsPalletInput(string palletno)
        {
            Pallet_MasterDAC dac = new Pallet_MasterDAC();
            return dac.IsPalletInput(palletno);
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
