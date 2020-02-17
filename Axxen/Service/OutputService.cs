using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class OutputService
    {
        /// <summary>
        /// 월별 생산현황
        /// </summary>
        /// <param name="month"></param>
        /// <param name="lmonth"></param>
        /// <returns></returns>
        public List<OutputVO> GetOutput(string month, string lmonth)
        {
            OutputDAC dac = new OutputDAC();
            return dac.GetOutPut(month, lmonth);
        }

        /// <summary>
        /// 월별 포장현황
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public List<BoxPackageVO> GetBoxPackage(string month)
        {
            OutputDAC dac = new OutputDAC();
            return dac.GetBoxPackage(month);
        }
    }
}
