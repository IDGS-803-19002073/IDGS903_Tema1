using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var alumno1 = new Alumnos()
            {
                Nombre = "Antonio",
                Edad = 20,
                Activo = false,
                Incrito = new DateTime(2023, 01, 15)
            };
            ViewBag.Alumnos = alumno1;
            return View();
        }

        // GET: Escuela/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Escuela/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escuela/Create
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

        // GET: Escuela/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Escuela/Edit/5
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

        // GET: Escuela/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Escuela/Delete/5
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
