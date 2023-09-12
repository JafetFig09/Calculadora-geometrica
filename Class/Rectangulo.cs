using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFigurasGeometricas.Class
{
    public class Rectangulo : Figura
    {
        double bases;
        double altura;
        

        public Rectangulo()
        {

        }

        public double Bases
        {
            get {  return bases; }
            set { bases = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }

        }

        public override double area()
        {
            return (Bases * Altura);
        }

        public override double perimetro()
        {
            return ((Bases * 2) + (Altura * 2));
        }
    }
}
