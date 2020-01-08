using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class MenuTree_Master_VO
    {
        /// <summary>
        /// 메뉴순번
        /// </summary>
        public int Seq { get; set; }
       
        /// <summary>
        /// 상위화면코드
        /// </summary>
        public string Parent_Screen_Code { get; set; }
        /// <summary>
        /// 화면코드
        /// </summary>
        public string Screen_Code { get; set; }
        /// <summary>
        /// 화면이름
        /// </summary>
        public string Screen_Name { get; set; }
        /// <summary>
        /// 정렬순서
        /// </summary>
        public int Sort_index { get; set; }
        /// <summary>
        /// 최초입력일자
        /// </summary>
        public DateTime Ins_Date { get; set; }
        /// <summary>
        /// 최초입력자
        /// </summary>
        public string Ins_Emp { get; set; }
        /// <summary>
        /// 최종수정일자
        /// </summary>
        public DateTime Up_Date { get; set; }
        /// <summary>
        /// 최종수정자
        /// </summary>
        public string Up_Emp { get; set; }
    }
    /// <summary>
    /// 즐겨찾기vo
    /// </summary>
    public class BookMark_VO
    {
        /// <summary>
        /// 즐겨찾기순번
        /// </summary>
        public long  Seq { get; set; }//즐겨찾기순번
        /// <summary>
        /// 사용자ID
        /// </summary>
        public string  User_ID { get; set; }//사용자ID
        /// <summary>
        /// 화면코드
        /// </summary>
        public string  Screen_Code { get; set; }//화면코드
        /// <summary>
        /// 부모코드
        /// </summary>
        public string  Parent_Screen_Code { get; set; }//부모코드
        /// <summary>
        /// 즐겨찾기타입
        /// </summary>
        public string  Type { get; set; }//즐겨찾기타입
        /// <summary>
        /// 정렬순서
        /// </summary>
        public int  Sort_index { get; set; }//정렬순서
        /// <summary>
        /// 최초입력일자
        /// </summary>
        public DateTime Ins_Date { get; set; }//최초입력일자
        /// <summary>
        /// 최초입력자
        /// </summary>
        public string  Ins_Emp { get; set; }//최초입력자
        /// <summary>
        /// 최종수정일자
        /// </summary>
        public DateTime Up_Date { get; set; }//최종수정일자
        /// <summary>
        /// 최종수정자
        /// </summary>
        public string  Up_Emp { get; set; }//최종수정자


    }
}
