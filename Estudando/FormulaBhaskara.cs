using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudando
{
    public partial class FormulaBhaskara : Form
    {
        public FormulaBhaskara()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double delta = 0;
            double a1 = 0;
            double a2 = 0;

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            delta = b * b - (4 * a * c);
            if (delta > 0)
            {
                a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                a2 = (-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show("o valor da Fórmula de Bhaskara de A é: " + a1);
                MessageBox.Show("o valor da Fórmula de Bhaskara de B é: " + a2);
            }
            else
            {
                MessageBox.Show("Valor de delta é negativo: " + delta);
            }

            
            

        }
    }
}
