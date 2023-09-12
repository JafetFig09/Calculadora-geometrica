using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFigurasGeometricas.Class
{
    public class Circulo : Figura
    {

        private double radio;

        public Circulo() { }

        public double Radio
        {    get { return radio; } 
            
            set {  radio = value; } 
        
        }

        public override double area()
        {
            return Math.PI * (radio * radio);
        }

        public override double perimetro()
        {
            return 2* Math.PI * radio;
        }
    }
}
