using IDGS903_Tema1.Models.Services;
using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TraductorController : Controller
    {
        public ActionResult Traductor(Traductor traductor)
        {
            TempData["Resultado"] = traductor.Traducir();
            return View(traductor);
        }
    }
}
