using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace functions
{
    public partial class Form1 : Form
    {
        int verificaMaior(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        void limparCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtResultado.Clear();
            txtA.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            txtResultado.Text = verificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
