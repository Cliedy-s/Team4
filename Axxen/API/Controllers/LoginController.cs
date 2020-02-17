using API.DAC;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(string User_ID, string pwd)
        {
            if (!string.IsNullOrEmpty(User_ID)) {
                UserInfoDAC dac = new UserInfoDAC();
                return View(dac.GetLoginInfo(User_ID, pwd));
            }
            else { 
            return View();
            }
        }
        // GET: Login
        public ActionResult selectuser(string User_ID, string pwd)
        {
            UserInfoDAC dac = new UserInfoDAC();
            return View(dac.GetLoginInfo(User_ID, pwd));

        }
        public ActionResult userbox()
        {
            UserInfoDAC dac = new UserInfoDAC();
          
                return PartialView(model: UserInfo.User_ID);
        
        }
    }
}