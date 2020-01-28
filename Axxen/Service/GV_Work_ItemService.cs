using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class GV_Work_ItemService
    {
        public List<GV_Work_ItemVO> GetAllGV_Work_Item() //PRM_PRF_005 전체 컬럼 가지고오기
        {
            GV_Work_ItemDAC dac = new GV_Work_ItemDAC();

            return dac.GetAllGV_Work_Item();
        }

        public List<GV_History_Work_ItemVO> GetAllGV_History_Work_Item() //PRM_PRF_006 전체 컬럼 가지고오기
        {
            GV_Work_ItemDAC dac = new GV_Work_ItemDAC();

            return dac.GetAllGV_History_Work_Item();
        }

        public List<GV_History_Work_ItemVO> GetDatePicker_GV_History_Work_Item(string Adatetimepicker1, string Adatetimepicker2) //PRM_PRF_004 전체 컬럼 가지고오기
        {
            GV_Work_ItemDAC dac = new GV_Work_ItemDAC();

            return dac.GetDatePicker_GV_History_Work_Item(Adatetimepicker1, Adatetimepicker2);
        }

        public List<GV_History_Work_ItemVO> GV_Current_YesStatus() //PRM_PRF_007 사용중 대차 현황
        {
            GV_Work_ItemDAC dac = new GV_Work_ItemDAC();

            return dac.GV_Current_YesStatus();
        }

        public List<GV_History_Work_ItemVO> GetGV_Current_NO_Status() //PRM_PRF_007 빈 대차 현황
        {
            GV_Work_ItemDAC dac = new GV_Work_ItemDAC();

            return dac.GetGV_Current_NO_Status();
        }

        
    }
}
