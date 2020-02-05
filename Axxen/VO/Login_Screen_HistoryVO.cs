using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    /// <summary>
    /// 화면사용이력
    /// </summary>
   public class Login_Screen_HistoryVO
    {

        public string Session_ID { get; set; }
        public long Seg { get; set; }
        public DateTime Open_Day { get; set; }
        public DateTime Open_Date { get; set; }
        public string User_ID { get; set; }
        public string Screen_Code { get; set; }
    }

    /// <summary>
    /// 화면사용이력검색 정보
    /// </summary>
    public class SearchLogin_Screen_HistoryVO
    {

public string User_Name { get; set; }
        public string Session_ID { get; set; }
        public string Type { get; set; }
        public DateTime Login_Date { get; set; }

        public DateTime Open_Date { get; set; }



    }

}
