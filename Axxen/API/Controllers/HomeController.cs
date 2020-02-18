using API.DAC;
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
    }
}
