using API.DAC;
using API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class DefHistoryController : Controller
    {
        // GET: DefHistory
        public ActionResult Index()
        {
            return View();
        }

        // GET: DefHistory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DefHistory/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult DefectiveCreate()
        {
            Def_HistoryDAC def = new Def_HistoryDAC();

            ViewBag.Workorderno = new SelectList(def.GetDefHistoryWorkorderno());
            ViewBag.CodeName = def.GetDefMiMasterCodeName();
            //List<Def_HistoryVO> fruits = def.GetDefMiMasterCodeName();

            return View();
        }

        // POST: DefHistory/Create
        [HttpPost]
        public ActionResult DefectiveCreate(Def_HistoryVO definfo)
        {           
            try
            {               
                definfo.Up_Emp = UserInfo.User_Name;
                definfo.Ins_Emp = UserInfo.User_Name;

                string filename = definfo.FileUploadFile.FileName;

                var fileName = Path.GetFileName(definfo.FileUploadFile.FileName);
                var path = Path.Combine(Server.MapPath("~/uploads"), fileName);
                definfo.FileUploadFilePath = path;
                definfo.FileUploadFile.SaveAs(path);
                
                // TODO: Add insert logic here
                Def_HistoryDAC def = new Def_HistoryDAC();
                if (def.SaveDef(definfo))
                {
                    return RedirectToAction("Index", "Home"); //인서트가 성공적으로 됐다면. 목록으로 가라 indexview가 목록임.
                }
                else
                {
                    return View(definfo); //인서트가성공안되면 내가 써논 값을 가지고 create를 하기위해서
                }

            }
            catch(Exception err)
            {
                string sss = err.Message;
                return View();
            }
        }


        public ActionResult DefectiveDetails()
        {
            Def_HistoryDAC def = new Def_HistoryDAC();
            return View(def.DefectiveDetails());
        }

        // POST: DefHistory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DefHistory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DefHistory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
