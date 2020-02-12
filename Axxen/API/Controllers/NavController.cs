using API.DAC;
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
            Item_MasterDac dac = new Item_MasterDac();
            List<string> categories = dac.GetAllItem_Master();

            return PartialView(categories);
        }
    }
}