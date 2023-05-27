using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class BuscarService
    {
        public string BuscarPalabra(string palabra, string opcion)
        {
            string[] palabras = null;
            string archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            if (File.Exists(archivo))
            {
                palabras = File.ReadAllLines(archivo);
                string translation = "";
                foreach (string line in palabras)
                {
                    switch (opcion)
                    {
                        case "English":
                            translation = line.Split(' ')[0];
                            if (palabra != null &&  translation == palabra.ToLower())
                            {
                                return line.Split(' ')[1];
                            }
                            break;

                        case "Spanish":
                            translation = line.Split(' ')[1];
                            if (palabra != null &&  translation == palabra.ToLower())
                            {
                                return line.Split(' ')[0];
                            }
                            break;
                    }
                }
                if (translation != "")
                {
                    return "Palabra no encontrada";

                }
            }
        
            return "¡Selecciona una opción y traduce!";

        }
    }
}