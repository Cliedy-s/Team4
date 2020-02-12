using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class WorkHistory_Center_UserMasterService
    {
        public List<WorkHistory_Center_UserMasterVO> GetAllWorkHistory_Center_UserMaster() // 009 전체 조회
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();
            return dac.GetAllWorkHistory_Center_UserMaster();
        }

        public List<WorkHistory_Center_UserMasterVO> PickerWorkHistory_Center_UserMaster(string Adatetimepicker1, string Adatetimepicker2) //PRM_PRF_009 날짜별조회
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();

            return dac.PickerWorkHistory_Center_UserMaster(Adatetimepicker1, Adatetimepicker2);
        }

        public DataTable PickerWorkHistory_UserMaster(string Adatetimepicker1, string Adatetimepicker2) //PRM_PRF_010 날짜별조회
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();

            return dac.PickerWorkHistory_UserMaster(Adatetimepicker1, Adatetimepicker2);
        }

        public DataTable PickerWorkHistory_UserMaster_UserID(string Adatetimepicker1, string Adatetimepicker2, string UserID) //PRM_PRF_010 날짜별조회
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();

            return dac.PickerWorkHistory_UserMaster_UserID(Adatetimepicker1, Adatetimepicker2, UserID);
        }

        public List<WorkHistory_Center_UserMasterVO> GetAllUserDetails(string UserName) //PRM_PRF_010 서브그리드뷰
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();

            return dac.GetAllUserDetails(UserName);
        }

        /// <summary>
        /// 근무 시작
        /// </summary>
        /// <param name="insertitem"></param>
        /// <returns></returns>
        public bool InsertStartWork(string processcode, string userid, string wccode)
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();
            return dac.InsertStartWork(processcode, userid, wccode);
        }
        /// <summary>
        /// 근무 종료
        /// </summary>
        /// <param name="insertitem"></param>
        /// <returns></returns>
        public bool UpdateEndWork(string processcode, string userid, string wccode)
        {
            WorkHistory_Center_UserMasterDAC dac = new WorkHistory_Center_UserMasterDAC();
            return dac.UpdateEndWork(processcode, userid, wccode);
        }

    }
}
