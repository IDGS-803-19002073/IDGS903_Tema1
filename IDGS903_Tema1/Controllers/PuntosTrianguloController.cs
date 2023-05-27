using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class PuntosTrianguloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(PuntosTriangulo coordenadas)
        {
            //coordenadas.CalcularArea();
            coordenadas.calcularArea();
            coordenadas.validarTriangulo();
            ViewBag.Res = coordenadas;
            return View(coordenadas);
        }

    }
}
