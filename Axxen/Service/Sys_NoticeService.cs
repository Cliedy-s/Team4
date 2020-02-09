using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Sys_NoticeService
    {
        public List<Sys_NoticeVO> GetAllSys_notice()
        {
            Sys_NoticeDAC dac = new Sys_NoticeDAC();
            return dac.GetAllSys_notice();
        }



        /// <summary>
        /// 현재 공지사항 가져오기
        /// </summary>
        /// <param name="Seq"></param>
        /// <returns></returns>
        public Sys_NoticeVO GetCurrentSysNotice(int Seq)
        {
            Sys_NoticeDAC dac = new Sys_NoticeDAC();
            return dac.GetCurrentSysNotice(Seq);
        }
    }
}
