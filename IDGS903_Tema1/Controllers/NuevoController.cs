using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        public ActionResult Calculos(OperasBas op)
        {
            var model = new OperasBas();

            model.Res = op.Operas();

            return View(model);
        }
    }
}
