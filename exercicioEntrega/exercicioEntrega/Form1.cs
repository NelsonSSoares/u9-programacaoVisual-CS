using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioEntrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            //  int tabuada = 10;
            int result;
            int i = 0;

            listTabuada.Items.Clear();

            for (i = 0; i<=10; i++)
            {
                result = valor * i;
                listTabuada.Items.Add(result);
            }

            txtValor.Clear();
            txtValor.Focus();
        }
    }
}
