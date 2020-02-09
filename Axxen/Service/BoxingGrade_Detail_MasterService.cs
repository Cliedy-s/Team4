using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class BoxingGrade_Detail_MasterService
	{
		/// <summary>
		/// 포장등급 가져오기
		/// </summary>
		/// <returns></returns>
		public List<BoxingGrade_Detail_MasterVO> GetAll()
		{
			BoxingGrade_Detail_MasterDAC dac = new BoxingGrade_Detail_MasterDAC();
			return dac.GetAll();
        }
        /// <summary>
        /// 포장등급상세로 등급 가져오기
        /// </summary>
        /// <returns></returns>
        public string GellBoxing_Grade(string boxingDetailCode)
        {
            BoxingGrade_Detail_MasterDAC dac = new BoxingGrade_Detail_MasterDAC();
            return dac.GellBoxing_Grade( boxingDetailCode);
        }
        public bool DeleteBoxingGrade_Detail_MasterVO(string boxcode)
        {
            BoxingGrade_Detail_MasterDAC dac = new BoxingGrade_Detail_MasterDAC();
            return dac.DeleteBoxingGrade_Detail_MasterVO(boxcode);
        }
        public bool UsedBoxingGrade_Detail_MasterVO(string code, string use)
        {
            BoxingGrade_Detail_MasterDAC dac = new BoxingGrade_Detail_MasterDAC();
            return dac.UsedBoxingGrade_Detail_MasterVO(code, use);
        }
        public bool GetInsertUpdateBoxingGrade_Detail_MasterVO(string check, string code, string Name, string bigcode, string user)
        {
            BoxingGrade_Detail_MasterDAC dac = new BoxingGrade_Detail_MasterDAC();
            return dac.GetInsertUpdateBoxingGrade_Detail_MasterVO(check, code, Name, bigcode, user);
        }
        }
}
