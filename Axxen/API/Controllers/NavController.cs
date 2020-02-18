using API.DAC;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public ActionResult Menu(string category = null)
        {
        
                ViewBag.SelectedCategory = category;
                Item_MasterDAC dac = new Item_MasterDAC();
                List<string> categories = dac.GetAllItem_Master();

                return PartialView(categories);
         
        }

        /// <summary>
        /// 상단 메세지 상세목록
        /// </summary>
        /// <returns></returns>
        public ActionResult Message()
        {
     
            Sys_NoticeDAC dac = new Sys_NoticeDAC();         
            return PartialView(dac.Sys_noticeAll());
           
        }

    }
}