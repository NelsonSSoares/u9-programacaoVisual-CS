namespace tabuadaFatorial
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

        private void btnFatorial_Click(object sender, EventArgs e)
        {


            lstResultado.Items.Clear();

            int numUser = int.Parse(txtNum.Text), fatorial ,i ;

            fatorial = numUser;


            for ( i = numUser; i > 0; i--)
            {
                fatorial *= i;
                lstResultado.Items.Add(fatorial);
            }

        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            int numUser = int.Parse(txtNum.Text), i, result;


            for (i = 0; i <= 10; i++)
            {
                result = numUser * i;
                lstResultado.Items.Add(result);
            }
        }
    }
}