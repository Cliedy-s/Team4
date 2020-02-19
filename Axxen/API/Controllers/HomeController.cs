using API.DAC;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Item_MasterDAC dac = new Item_MasterDAC();

            return View(dac.GetAllItem_Master2());
        }

        // GET: Sys_Notice/Details/5
        public ActionResult Details(string id)
        {
            Item_MasterDAC dac = new Item_MasterDAC();
            List<Item_Master_and_woreqtVO> item = new List<Item_Master_and_woreqtVO>();
            item = dac.GetDetailsItem_MasterDAC(id);
               return View(item[0]);

        }

        [HttpPost]
        public ActionResult Details(Item_Master_and_woreqtVO notice)
        {   
                // TODO: Add insert logic here
                Item_MasterDAC dac = new Item_MasterDAC();
                if (dac.InsertItem_Master_and_woreqtVO(notice))
                {
                    return RedirectToAction("Index"); //인서트가 성공적으로 됐다면. 목록으로 가라 indexview가 목록임.
                }
            else { 
            return RedirectToAction("Details");
            }

        }
    }
}
