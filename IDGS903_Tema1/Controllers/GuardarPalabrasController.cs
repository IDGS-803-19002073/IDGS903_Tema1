using IDGS903_Tema1.Models;
using IDGS903_Tema1.Models.Services;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class GuardarPalabrasController : Controller
    {
        public ActionResult RegistrarPalabra(GuardarPalabras traductor)
        {
            var guarda = new GuardaService();
            guarda.GuardaPalabras(traductor);
            return View();
        }

        public ActionResult MostrarDiccionario()
        {
            var maes = new LeerService();
            ViewBag.GuardarPalabras = maes.LeerPalabras();
            return View();
        }
    }
}
