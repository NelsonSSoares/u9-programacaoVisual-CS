using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fliperama_desc_Ficha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float fichas, total;
            fichas = float.Parse(txtQtd.Text);
            if ( fichas >= 10) 
            {
                total = fichas * 5;
            }else
            {
                total = fichas * 6;
            }
            txtTotal.Text = total.ToString(); 
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar?", "Limpar Campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { 
                txtQtd.Clear();
                txtTotal.Clear();
                txtQtd.Focus();
            }
        }
    }
}
