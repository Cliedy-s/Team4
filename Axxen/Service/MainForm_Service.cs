using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using VO;
namespace Service
{
    public class MainForm_Service
    {
        public List<MenuTree_Master_VO> GetAll_MenuTree_Master()
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.GetAll_MenuTree_Master();
        }
        public bool UpdateManu(string parent, string son)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.UpdateManu(parent,son);

        }
        /// <summary>
        /// 메뉴 부모,자식 추가
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="son"></param>
        /// <returns></returns>
        public bool InsertMenuTree_Master_VO(MenuTree_Master_VO menu)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.InsertMenuTree_Master_VO(menu);
        }
        public bool DeleteMenuTree_Master_VO(string parent, string code)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.DeleteMenuTree_Master_VO(parent, code);

        }
            public List<BookMark_VO> GetAll_BookMark(string id)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.GetAll_BookMark(id);
        }

        public bool InsertBookMark(BookMark_VO list)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.InsertBookMark(list);
        }
      }
}
