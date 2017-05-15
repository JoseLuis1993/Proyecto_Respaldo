using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoRespaldo.Models;

namespace ProyectoRespaldo.Controllers
{
    public class MVirtualController : Controller
    {
        // GET: MVirtual
        public ActionResult Index_MVirtual()
        {
            return View();
        }



        // GET: MVirtual/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MVirtual/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVirtual/Create
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

        // GET: MVirtual/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MVirtual/Edit/5
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

        // GET: MVirtual/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MVirtual/Delete/5
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
