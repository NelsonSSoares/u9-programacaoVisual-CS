using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovasPropriedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPagamento.Items.Add("À Vista");
            cboPagamento.Items.Add("2x");
            cboPagamento.Items.Add("3x");
            cboPagamento.Items.Add("4x");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParcela_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total,  vParcela;
            String parcelas;

            total = double.Parse(txtTotal.Text);
            parcelas = cboPagamento.Text;

            if (parcelas == "À Vista")
            {
                vParcela = total * 0.9;
                txtParcela.Text = vParcela.ToString();
            }
            else if (parcelas == "2x")
            {
                vParcela = total / 2;
                txtParcela.Text = vParcela.ToString();
            }
            else if (parcelas == "3x")
            {
                vParcela = total / 3;
                txtParcela.Text = vParcela.ToString();
            }
            else if (parcelas == "4x")
            {
                vParcela = total / 4;
                txtParcela.Text = vParcela.ToString();
            }

        }
    }
}
