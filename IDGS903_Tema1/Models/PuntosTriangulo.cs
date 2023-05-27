using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class PuntosTriangulo
    {

        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double y3 { get; set; }
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }
        public string tipo { get; set; }
        public double area { get; set; }

        public void calcularArea()
        {
            double x = this.x2 - this.x1;
            double y = this.y2 - this.y1;
            this.lado1 = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            double x1 = this.x3 - this.x2;
            double y1 = this.y3 - this.y2;
            this.lado2 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            double x2 = this.x1 - this.x3;
            double y2 = this.y1 - this.y3;
            this.lado3 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            //validar si es un triangulo
            if (validacionTriangulo(this.x1,this.y1,this.x2,this.y2,this.x3,this.y3))
            {
                double perimetro = lado1 + lado2 + lado3;
                double semiperimetro = perimetro / 2;
                double areaHeronFormula = semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3);
                this.area = Math.Sqrt(areaHeronFormula);
            }
        }

        public bool validacionTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double pendienteAB = (y2 - y1) / (x2 - x1);
            double pendienteAC = (y3 - y1) / (x3 - x1);

            if (pendienteAB != pendienteAC)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
        public void validarTriangulo()
        {
            if (this.area > 0)
            {
                //3 lados iguales
                if (Math.Round(lado1) == Math.Round(lado2) && Math.Round(lado2) == Math.Round(lado3) && Math.Round(lado1) == Math.Round(lado3))
                {
                    this.tipo = "Equilatero";
                }
                else if ((Math.Round(lado1) == Math.Round(lado2) || Math.Round(lado2) == Math.Round(lado3) || Math.Round(lado1) == Math.Round(lado3)) && (Math.Round(lado1) != Math.Round(lado2) || Math.Round(lado2) != Math.Round(lado3) || Math.Round(lado1) != Math.Round(lado3)))
                {
                    //2 lados iguales
                    this.tipo = "Isoceles";
                }
                else if (Math.Round(lado1) != Math.Round(lado2) && Math.Round(lado2) != Math.Round(lado3) && Math.Round(lado1) != Math.Round(lado3))
                {
                    //lados diferentes
                    this.tipo = "Escaleno";
                }
            }
            else
            {
                this.tipo = "Es una linea recta";


            }

        }
    }
}