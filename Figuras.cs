using CalculadoraFigurasGeometricas.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculadoraFigurasGeometricas
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

     

        private void cCirculo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void calcularCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();

            if (double.TryParse(tRadio.Text.Trim(),out double resultado))
            {
                if (resultado <= 0)
                {
                    MessageBox.Show("No se acepta este valor");
                }
                else
                {
                    circulo.Radio = resultado;
                    tPerimetroCirculo.Text = circulo.perimetro().ToString();
                    tAreaCirculo.Text = circulo.area().ToString();
                }
            }
            else
            {
                MessageBox.Show("No se aceptan carcateres");
            } 
                
               
        }

        private void tAreaCirculo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void bCalcularRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo rectangulo = new Rectangulo();

            try
            {

                rectangulo.Bases = Convert.ToDouble(tBaseRectangulo.Text.Trim());
                rectangulo.Altura = Convert.ToDouble(tAlturaRectangulo.Text.Trim());

                if (rectangulo.Bases <= 0 || rectangulo.Altura <= 0)
                {

                    MessageBox.Show("No se acepta este valor");
                }
                else
                {
                    tPerimetroRectangulo.Text = rectangulo.perimetro().ToString();
                    tAreaRectangulo.Text = rectangulo.area().ToString();
                }
                    

                
        
            }
            catch(Exception ) 
            {
                MessageBox.Show("No se aceptan carcateres");
            }

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void btnCalcularTrinagulo_Click(object sender, EventArgs e)
        {
           try
            {
                Triangulo triangulo = new Triangulo();

                triangulo.Altura = Convert.ToDouble(tbAlturaTriangulo.Text.Trim());
                triangulo.Bases = Convert.ToDouble(tbBaseTriangulo.Text.Trim());
                triangulo.Lado1 = Convert.ToDouble(tbLado1Triangulo.Text.Trim());
                triangulo.Lado2 = Convert.ToDouble(tbLado2Triangulo.Text.Trim());

                if (triangulo.Altura <= 0 || triangulo.Bases <= 0 || triangulo.Lado1 <= 0
                    || triangulo.Lado2 <= 0)
                {
                    MessageBox.Show("No se acepta este valor");

                }
                else
                {
                    lbPerimetroTriangulo.Text = triangulo.perimetro().ToString();
                    lbAreaTriangulo.Text = triangulo.area().ToString();
                }
                
            }
           catch (Exception)
            {
                MessageBox.Show("No se aceptan carcateres");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcularCuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                Cuadrado cuadrado = new Cuadrado();

                cuadrado.Lado = Convert.ToDouble(tbLadoCuadrado.Text.Trim());

                if (cuadrado.Lado <= 0)
                {
                    MessageBox.Show("No se acepta este valor");
                }
                else
                {
                    lbAreaCuadrado.Text = cuadrado.area().ToString();
                    lbPerimetroCuadrado.Text = cuadrado.perimetro().ToString();
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("No se aceptan carcateres");
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {


            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;

        }
    }

    
}
