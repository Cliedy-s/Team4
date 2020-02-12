using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class Sys_NoticeController : Controller
    {
        // GET: Sys_Notice
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sys_Notice/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sys_Notice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sys_Notice/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sys_Notice/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sys_Notice/Edit/5
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

        // GET: Sys_Notice/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sys_Notice/Delete/5
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
