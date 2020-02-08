using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
   public class Inspect_Spec_MasterService
    {
        Inspect_Spec_MasterDAC dac;
        public Inspect_Spec_MasterService()
        {
             dac = new Inspect_Spec_MasterDAC();
        }

        /// <summary>
        /// 검사항목규격설정 가져오기
        /// </summary>
        /// <returns></returns>
        public List<InspectSpecVO> GetAll()
        {
          
            return dac.GetAll();
        }

        public bool InsertInspectSpec(List<InspectSpecVO> inspctspec)
        {
            return dac.InsertInspectSpec(inspctspec);
        }
        /// <summary>
        /// 검사항목규격설정 사용
        /// </summary>
        /// <returns></returns>
        public bool UseInspectSpec(InspectSpecVO inspect, string use)
        {
            return dac.UseInspectSpec(inspect, use);
        }
        public bool DeleteInspectSpecVO(string Item_Code,string Process_code,string Inspect_code)
        {
            return dac.DeleteInspectSpecVO(Item_Code, Process_code, Inspect_code);
        }
        }
}
