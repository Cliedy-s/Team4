using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    /// <summary>
    /// 유저그룹마스터
    /// </summary>
  public  class UserGroup_MasterVO
    {
        /// <summary>
        /// 사용자그룹코드
        /// </summary>
        public string UserGroup_Code { get; set; }
        /// <summary>
        /// 사용자그룹명
        /// </summary>
        public string UserGroup_Name { get; set; }
        /// <summary>
        /// 관리자권한여부
        /// </summary>
        public string Admin { get; set; }
        /// <summary>
        /// 사용여부
        /// </summary>
        public string Use_YN { get; set; }
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
    /// 조인된 유저 목록
    /// </summary>
    public class UserGroup_MappingVO {

       /// <summary>
       /// 유저그릅코드
       /// </summary>
        public string UserGroup_Code { get; set; }
        /// <summary>
        /// 유저아이디
        /// </summary>
        public string User_ID { get; set; }
        /// <summary>
        /// 등록일자
        /// </summary>
        public DateTime Ins_Date { get; set; }
        /// <summary>
        /// 등록자
        /// </summary>
        public string Ins_Emp { get; set; }
        /// <summary>
        /// 수정이자
        /// </summary>
        public DateTime Up_Date { get; set; }
        /// <summary>
        /// 수정자
        /// </summary>
        public string Up_Emp { get; set; }





    }


}
