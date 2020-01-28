using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Nop_History_Mi_MaService
    {
        public List<Nop_History_Mi_MaVO> GetAllNop_History_Mi_Ma() // 전체 조회
        {
            Nop_History_Mi_MaDAC dac = new Nop_History_Mi_MaDAC();
            return dac.GetAllNop_History_Mi_Ma();
        }

        public List<Nop_History_Mi_MaVO> GetDatePicker_Nop_History_Mi_Ma(string Adatetimepicker1, string Adatetimepicker2) //PRM_PRF_008 날짜별조회
        {
            Nop_History_Mi_MaDAC dac = new Nop_History_Mi_MaDAC();

            return dac.GetDatePicker_Nop_History_Mi_Ma(Adatetimepicker1, Adatetimepicker2);
        }
    }
}
