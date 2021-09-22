using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sal, fgts, porcFGTS,inss, porcINSS, irrf, porcIRRF, DEP = 0, vt,porcVT, sl;
            sal = double.Parse(txtSal.Text);
            porcFGTS = 8;
            porcINSS = 0;
            porcIRRF = 0;
            porcVT   = 6;
            DEP = double.Parse(cboDEP.Text);
            vt = sal * (porcVT / 100);
            sal = float.Parse(txtSal.Text);
            fgts = sal * (porcFGTS / 100);
            txtFGTS.Text = fgts.ToString();
            txtVT.Text = vt.ToString();
            if (sal <= 1100)
            {
                porcINSS = 0.075;
                inss = sal * porcINSS;
                txtINSS.Text = inss.ToString();
            }
            else if (sal <= 2203.48)
            {
                porcINSS = 0.09;
                inss = sal * porcINSS;
                txtINSS.Text = inss.ToString();
            }
            else if (sal <= 3305.22)
            {
                porcINSS = 0.12;
                inss = sal * porcINSS;
                txtINSS.Text = inss.ToString();
            }
            else if (sal <= 6433.57)
            {
                porcINSS = 0.14 ;
                inss = sal * porcINSS;
                txtINSS.Text = inss.ToString();
            }
            else
            {
                inss = 900.70;
                txtINSS.Text = inss.ToString();
            }

            if(sal <=1903.98)
            {
                irrf = sal * porcIRRF - 142.80 + (DEP * 189.59);
                txtIRRF.Text = irrf.ToString();
            }
            else if (sal <= 2826.66)
            {
                porcIRRF = 0.075;
                irrf = sal * porcIRRF - 142.80 + (DEP * 189.59);
                txtIRRF.Text = irrf.ToString();
            }
            else if (sal <= 3751.05)
            {
                porcIRRF = 0.15;
                irrf = sal * porcIRRF - 354.80 + (DEP * 189.59);
                txtIRRF.Text = irrf.ToString();
            }
            else if (sal <= 4664.68)
            {
                porcIRRF = 0.225;
                irrf = sal * porcIRRF - 636.13 + (DEP * 189.59);
                txtIRRF.Text = irrf.ToString();
            }
            else
            {
                porcIRRF = 0.275 + (DEP * 189.59);
                irrf = sal * porcIRRF - 636.13;
                txtIRRF.Text = irrf.ToString();
            }
            
            if(rbtnSim.Checked == true)
            {
                sl = sal - inss - irrf - vt;
                txtSaliq.Text = sl.ToString();
            }
            else
            {
                sl = sal - inss - irrf;
                txtSaliq.Text = sl.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
