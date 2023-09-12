using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFigurasGeometricas.Class
{
    public class Triangulo : Rectangulo
    {
        double lado1;
        double lado2;
        public Triangulo() { }


        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }
        public override double area()
        {
            return (base.area()/2);
        }

        public override double perimetro()
        {
            return Bases + Lado1 + Lado2;
        }


    }
}
