using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float result))
            {
                chart1.Series["tdgunbb"].Points.AddXY(chart1.Series["tdgunbb"].Points.Count, result); // Agregar el punto en la gráfica con coordenadas (x, result)
                textBox1.Clear(); // Limpiar el TextBox para permitir nuevas entradas

                // Cambiar el color de la última columna agregada
                
                
            }
            else
            {

                MessageBox.Show("Ingresa un valor válido en el TextBox."); // Mostrar un mensaje de error si el valor ingresado no es válido
            }

            //int result = 5;
            //chart1.Series["f1"].Points.AddXY(0,result);

        }
    }
}
