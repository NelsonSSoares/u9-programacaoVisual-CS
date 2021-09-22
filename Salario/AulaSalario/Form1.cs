using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaSalario
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalario.Focus();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            float fgts, sal, porcetagem = 8;
            sal = float.Parse(txtSalario.Text);
            fgts = sal * (porcetagem/100);
            txtFGTS.Text = fgts.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
