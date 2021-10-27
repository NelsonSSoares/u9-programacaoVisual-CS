using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picPilot_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posit = int.Parse(cboClass.Text);

            switch (posit)
            {
                case 1:
                    picPilot.Load("max-verstappe.jpg");
                    break;
                case 2:
                    picPilot.Load("Lewis_Hamilton.jpg");
                    break;
                case 3:
                    picPilot.Load("bottas.jpg");
                    break;
                case 4:
                    picPilot.Load("sergio-perez.jpg");
                    break;
                case 5:
                    picPilot.Load("lando-norris.jpg");
                    break;
                case 6:
                    picPilot.Load("Charles-Leclerc.jpg");
                    break;
                case 7:
                    picPilot.Load("Carlos-Sainz.jpg");
                    break;
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            cboClass.Items.Clear();

            int nump = 0 , i;

            if (string.IsNullOrEmpty(txtnumPilot.Text))
            {
                MessageBox.Show("O Campo deve ser Preenchido ", "Formula 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnumPilot.Focus();

            }
            else {
                nump = int.Parse(txtnumPilot.Text);
            }
    

            if (nump > 7 || nump <= 0 || nump == null )
            {
                MessageBox.Show("a Quantidade deve ser entre 1 e 7 ", "Formula 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnumPilot.Focus();
            }

            for (i = 0; i <= nump; i++)
            {
                cboClass.Items.Add(i);
            }

        }

        private void txtnumPilot_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
