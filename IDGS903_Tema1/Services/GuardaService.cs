using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models.Services
{
    public class GuardaService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var mat = maes.Matricula;
            var nom = maes.Nombre;
            var apa = maes.Apaterno;
            var ama = maes.Amaterno;
            var email = maes.Email;
            var datos = mat + "," + nom + "," + apa + "," + ama + "," + email + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            // File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);

        }
        public void GuardaPalabras(GuardarPalabras traductor)
        {
            var espagnol = !string.IsNullOrEmpty(traductor.espagnol) ? traductor.espagnol.ToLowerInvariant() : string.Empty;
            var ingles = !string.IsNullOrEmpty(traductor.ingles) ? traductor.ingles.ToLowerInvariant() : string.Empty;
            var datos = espagnol + " " + ingles + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");

            if (!string.IsNullOrEmpty(espagnol) && !string.IsNullOrEmpty(ingles))
            {
                File.AppendAllText(archivo, datos);
            }
        }

    }
}