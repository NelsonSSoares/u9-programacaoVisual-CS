namespace prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int i ;
            for (i = 0; i <= 30; i++)
            {
                lstNumeros.Items.Add(i);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int i =0;
            while (i <= 30)
            {
                lstNumeros.Items.Add(i);

                i++;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
        }
    }
}