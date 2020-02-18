using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using API.DAC;

namespace API.Controllers
{
    public class Sys_NoticeController : Controller
    {
        // GET: Sys_Notice
        public ActionResult Index()
        {

            Sys_NoticeDAC dac = new Sys_NoticeDAC();
            List<Sys_NoticeVO> sys = dac.Sys_noticeAll();
            ViewBag.Labels = (from item in sys
                              select item.Title).ToList();
            return View(dac.Sys_noticeAll());
            
        }

        // GET: Sys_Notice/Details/5
        public ActionResult Details(int id) 
        {
            Sys_NoticeDAC dac = new Sys_NoticeDAC();
            return View(dac.GetDetailsSys_Notice(id, false));
        }

        // GET: Sys_Notice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sys_Notice/Create
        [HttpPost]
        public ActionResult Create(Sys_NoticeVO notice)
        {
            try
            {
                // TODO: Add insert logic here
                Sys_NoticeDAC dac = new Sys_NoticeDAC();
                if (dac.InsertSys_Notice(notice))
                {
                    return RedirectToAction("Index"); //인서트가 성공적으로 됐다면. 목록으로 가라 indexview가 목록임.
                }
                else
                {
                    return View("Create", notice); //인서트가성공안되면 내가 써논 값을 가지고 create를 하기위해서
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Sys_Notice/Edit/5
        public ActionResult Edit(int id)
        {
            Sys_NoticeDAC dac = new Sys_NoticeDAC();
            return View(dac.GetDetailsSys_Notice(id, false));
        }

        // POST: Sys_Notice/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Sys_NoticeVO collection)
        {
            try
            {
                // TODO: Add insert logic here
                Sys_NoticeDAC dac = new Sys_NoticeDAC();
                if (dac.UpdateSys_Notice(collection))
                {
                    return RedirectToAction("Index"); //인서트가 성공적으로 됐다면. 목록으로 가라 indexview가 목록임.
                }
                else
                {
                    return View("Edit", collection); //인서트가성공안되면 내가 써논 값을 가지고 create를 하기위해서
                }
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
        public ActionResult Delete(int id, Sys_NoticeVO collection)
        {
            try
            {

                Sys_NoticeDAC boardMgt = new Sys_NoticeDAC();
                if (boardMgt.DeleteSys_Notice(id))
                {
                    return RedirectToAction("Index"); //인서트가 성공적으로 됐다면. 목록으로 가라 indexview가 목록임.
                }
                else
                {
                    return View("Delete", collection); //인서트가성공안되면 내가 써논 값을 가지고 create를 하기위해서
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
