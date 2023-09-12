using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFigurasGeometricas.Class
{
    public class Cuadrado : Figura
    {

        double lado;
        public Cuadrado() { }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double area()
        {
            return Lado * Lado;
        }

        public override double perimetro()
        {
            return Lado * 4;
        }
    }
}
