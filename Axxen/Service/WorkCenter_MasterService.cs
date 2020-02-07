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
        /// 모든 작업장 + 공정이름 
        /// </summary>
        /// <returns></returns>
        public List<WorkCenter_Master2VO> GetAll_WorkCenter_Master()
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.GetAll_WorkCenter_Master();
        }
        /// <summary>
        /// 작업장사용유무
        /// </summary>
        /// <param name="code"></param>
        /// <param name="use"></param>
        /// <returns></returns>
        public bool UsedWorkCenter_Master2VO(string code, string use)
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.UsedWorkCenter_Master2VO(code, use);
        }

        public bool InsertWorkservice(WorkCenter_Master2VO item)
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.InsertWorkservice(item);
        }

        public bool DeleteWorkCenter_Master2VO(string workcode)
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.DeleteWorkCenter_Master2VO(workcode);
        }

            /// <summary>
            /// 모든 작업장정보를 가져오는 메소드
            /// </summary>
            /// <returns></returns>
        public List<WorkCenter_MasterVO> GetAll()
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.GetAll();
        }

        public List<WorkCenter_MasterVO> GetCombo1() //PRM_PRF_008_1 작업장명만 가지고오는쿼리
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.GetCombo1();
        }
    }
}
