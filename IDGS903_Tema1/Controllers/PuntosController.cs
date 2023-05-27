using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class PuntosController : Controller
    {
        // GET: Puntos
        public ActionResult Calcular(Puntos puntos)
        {
            TempData["Resultado"] = puntos.CalcularPuntos();
            return View(puntos);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
