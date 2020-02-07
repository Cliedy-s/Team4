using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class GV_MasterService
    {
        public List<GVMasterVO> GetALLGVMaster()
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetALLGVMaster();
        }
        public bool InsertUpdateGV_Master(GVMasterVO GVMaster)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.InsertUpdateGV_Master(GVMaster);
        }
        public bool UsedGV_Master(string GV_Code, string used)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.UsedGV_Master(GV_Code, used);
        }
        public bool DeleteGVMasterVO(string gvcode)
        {

            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.DeleteGVMasterVO(gvcode);
        }

            /// <summary>
            /// 대차리스트 작업장별로 가져오기
            /// </summary>
        public List<GVWorkItemVO> GetAllByWC(string wccode, string woinichar)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetAllByWC(wccode, woinichar);
        } // TODO : 프로시저로 빼기
        /// <summary>
        /// 대차리스트 대차그룹, 대차상태 따라 가져오기
        /// </summary>
        /// <param name="gvgroup"></param>
        /// <param name="gvstatus"></param>
        /// <returns></returns>
        public List<GVVO> GetAllByGV(string gvgroup, string gvstatus)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetAllByGV(gvgroup, gvstatus);
        }
        /// <summary>
        /// 적재시간을 포함한 대차리스트
        /// </summary>
        /// <returns></returns>
        public List<GVLoadingTimeVO> GetAllWithLoadingTime(string gvgroup, string workorderno)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetAllWithLoadingTime(gvgroup, workorderno);
        }


        public List<GVMasterVO> GetGV_Code() // 대차 코드
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetGV_Code();
        }
        public List<GVMasterVO> GetGV_GroupCode() // 대차 그룹 코드
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetGV_GroupCode();
        }
        
    }
}
