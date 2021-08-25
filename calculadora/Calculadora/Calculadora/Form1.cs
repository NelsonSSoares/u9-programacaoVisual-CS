using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        /*
            if (txt1.Text == null || txt2.Text == null )
            {
                MessageBox.Show("Os campos estão vazios!", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        */

            float valor1, valor2, resultado;

            valor1 = float.Parse(txt1.Text);
            valor2 = float.Parse(txt2.Text);


            resultado = valor1 + valor2;

            txtResultado.Text = resultado.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = float.Parse(txt1.Text);
            valor2 = float.Parse(txt2.Text);

            resultado = valor1 - valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = float.Parse(txt1.Text);
            valor2 = float.Parse(txt2.Text);

            resultado = valor1 * valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = float.Parse(txt1.Text);
            valor2 = float.Parse(txt2.Text);

            resultado = valor1 / valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txtResultado.Clear();
            txt1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
