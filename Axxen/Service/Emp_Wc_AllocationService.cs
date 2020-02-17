using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Emp_Wc_AllocationService
    {
        /// <summary>
        /// 작업장에 할당된 작업자들 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <returns></returns>
        public List<WorkerVO> GetAllocatedWorker(string wccode)
        {
            Emp_Wc_AllocationDAC dac = new Emp_Wc_AllocationDAC();
            return dac.GetAllocatedWorker(wccode);
        }
        /// <summary>
        /// 작업장에 할당 가능한 작업자들 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <returns></returns>
        public List<WorkerAllocatableVO> GetAllocatableWorker(string wccode)
        {
            Emp_Wc_AllocationDAC dac = new Emp_Wc_AllocationDAC();
            return dac.GetAllocatableWorker(wccode);
        }
        /// <summary>
        /// 작업장에 할당된 유저인지 확인함
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool IsAllocated(string userid, string wccode)
        {
            Emp_Wc_AllocationDAC dac = new Emp_Wc_AllocationDAC();
            return dac.IsAllocated(userid, wccode);
        }
    }
}
