using API.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VO;

namespace API.Controllers
{
    public class MainController : ApiController
    {

        public List<MenuTree_Master_VO> GetAll_MenuTree_Master()
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.GetAll_MenuTree_Master();
        }
        public List<BookMark_VO> GetAll_BookMark(string id)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.GetAll_BookMark(id);
        }

        [HttpPost]
        public bool InsertBookMark(BookMark_VO list)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.InsertBookMark(list);
        }
    }
}
