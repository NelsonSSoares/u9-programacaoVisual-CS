using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPizzaria
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

        private void rdbComBorda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSabores.Items.Add("Muzzarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");

            cboSabores.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboSabores.SelectedIndex = 0;
            cboSabores.Focus();
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            String strSabor;
            String strPedido = null;

            strSabor = cboSabores.Text;

            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um Sabor de Pizza!", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;
            }

            switch (strSabor)
            {
                case "Muzzarela":
                    strPedido = "Muzzarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break; 
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido =  "Calabresa";
                    break;
;            }
            if (chkAzeitona.Checked)
            {
                strPedido = strPedido + " com Azeitona";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebola";
            }
            if (rdbSemBorda.Checked)
            {
                strPedido = strPedido + " sem Borda";
            }
            if (rdbComBorda.Checked)
            {
                strPedido = strPedido + " com Borda";
            }

            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
