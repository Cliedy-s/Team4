using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    /// <summary>
    /// 공정 서비스
    /// </summary>
  public  class ProcessService
    {
        ProcessDAC DAC;
        public ProcessService()
        {
            DAC = new ProcessDAC();
        }
        public List<Process_MasterVO> GetAllProcess_Master()
        {

            return DAC.GetAllProcess_Master();
        }
        public bool GetUpdateProcessMaster(string processcode, string used)
        {
            return DAC.GetUpdateProcessMaster(processcode, used);
        }

    }
        
}
