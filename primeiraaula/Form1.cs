using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAula
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 + valor2;

            txtTotal.Text = resultado.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
