using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using DAC;

namespace Service
{
    public class WorkCenter_MasterService
    {
        /// <summary>
        /// 모든 작업장정보를 가져오는 메소드
        /// </summary>
        /// <returns></returns>
        public List<WorkCenter_MasterVO> GetAll()
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.GetAll();
        }
    }
}
