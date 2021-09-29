using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosBR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.Text == "AC")
            {
                picEstado.Load("acre.jpg");
            }
            else if (cboEstado.Text == "AL")
            {
                picEstado.Load("alagoas.jpg");
            }
            else if (cboEstado.Text == "AP")
            {
                picEstado.Load("amapa.jpg");
            }
            else if (cboEstado.Text == "AM")
            {
                picEstado.Load("amazonas.jpg");
            }
            else if (cboEstado.Text == "BA")
            {
                picEstado.Load("bahia.jpg");
            }
            else if (cboEstado.Text == "CE")
            {
                picEstado.Load("ceara.jpg");
            }
            else if (cboEstado.Text == "DF")
            {
                picEstado.Load("brasilia.jpg");
            }
            else if (cboEstado.Text == "ES")
            {
                picEstado.Load("espirito-santo.jpg");
            }
            else if (cboEstado.Text == "GO")
            {
                picEstado.Load("goias.jpg");
            }
            else if (cboEstado.Text == "MA")
            {
                picEstado.Load("maranhao.jpg");
            }
            else if (cboEstado.Text == "MT")
            {
                picEstado.Load("mato-grosso.jpg");
            }
            else if (cboEstado.Text == "MS")
            {
                picEstado.Load("mato-grosso-do-sul.jpg");
            }
            else if (cboEstado.Text == "MG")
            {
                picEstado.Load("minas-gerais.jpg");
            }
            else if (cboEstado.Text == "PA")
            {
                picEstado.Load("para.jpg");
            }
            else if (cboEstado.Text == "PB")
            {
                picEstado.Load("paraiba.jpg");
            }
            else if (cboEstado.Text == "PR")
            {
                picEstado.Load("parana.jpg");
            }
            else if (cboEstado.Text == "PE")
            {
                picEstado.Load("pernambuco.jpg");
            }
            else if (cboEstado.Text == "PI")
            {
                picEstado.Load("piaui.jpg");
            }
            else if (cboEstado.Text == "RJ")
            {
                picEstado.Load("rio-de-janeiro.jpg");
            }
            else if (cboEstado.Text == "RN")
            {
                picEstado.Load("rio-grande-do-norte.jpg");
            }
            else if (cboEstado.Text == "RS")
            {
                picEstado.Load("rio-grande-do-sul.jpg");
            }
            else if (cboEstado.Text == "RO")
            {
                picEstado.Load("rondonia.jpg");
            }
            else if (cboEstado.Text == "RR")
            {
                picEstado.Load("roraima.jpg");
            }
            else if (cboEstado.Text == "SC")
            {
                picEstado.Load("santa-catarina.jpg");
            }
            else if (cboEstado.Text == "SP")
            {
                picEstado.Load("sao-paulo.jpg");
            }
            else if (cboEstado.Text == "SE")
            {
                picEstado.Load("sergipe.jpg");
            }
            else if (cboEstado.Text == "TO")
            {
                picEstado.Load("tocantins.jpg");
            }
        }
    }
}
