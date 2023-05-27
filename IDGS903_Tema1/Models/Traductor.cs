using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Traductor
    {
        public string Opcion { get; set; }
        public string Palabra { get; set; }

        public string Traducir()
        {

            BuscarService busqueda = new BuscarService();
            return busqueda.BuscarPalabra(Palabra, Opcion);

        }

    }
}