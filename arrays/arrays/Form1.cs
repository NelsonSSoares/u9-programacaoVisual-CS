using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] newArray = {0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
          
            for (int i = 0; i < array.Length ; i++)
            {
                lstArray.Items.Add("Posição de I " + array[i]);
                for (int j = 0; j < newArray.Length ; j++)
                {
                    lstArray.Items.Add("Posição de J " + newArray[j]);
                }
            }
        }
    }
}
