namespace programmingLanguages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cboList.Items.Clear();
            cboList.Items.Add("2021 - Nomadland");
            cboList.Items.Add("2020 - Parasita");
            cboList.Items.Add("2019 - Green Book");
            cboList.Items.Add("2018 - A forma da água.");
            cboList.Items.Add("2017 - Moonlight - Sob a luz do luar.");
            cboList.SelectedIndex = 0;
        }

        private void rdbDev_CheckedChanged(object sender, EventArgs e)
        {
            cboList.Items.Clear();
            cboList.Items.Add("Python");
            cboList.Items.Add("Java");
            cboList.Items.Add("C#");
            cboList.Items.Add("JavaScript");
            cboList.Items.Add("PHP");
            cboList.SelectedIndex = 3;
        }

        private void rdbInfra_CheckedChanged(object sender, EventArgs e)
        {
            cboList.Items.Clear();
            cboList.Items.Add("Azure");
            cboList.Items.Add("AWS");
            cboList.Items.Add("Cisco");
            cboList.Items.Add("Dell");
            cboList.Items.Add("Asus");
            cboList.SelectedIndex=0;
        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = cboList.SelectedItem.ToString();

            switch (selected)
            {
                case "JavaScript":
                    picBox.Load("javascript.png");
                    break;

                case "Python":
                    picBox.Load("python.png");
                    break;

                case "Java":
                    picBox.Load("java.png");
                    break;

                case "C#":
                    picBox.Load("csharp.png");
                    break;
                case "PHP":
                    picBox.Load("php.png");
                    break;
                case "Azure":
                    picBox.Load("azure.png");
                    break;
                case "AWS":
                    picBox.Load("aws.png");
                    break;
                case "Cisco":
                    picBox.Load("cisco.png");
                    break;
                case "Dell":
                    picBox.Load("dell.png");
                    break;
                case "Asus":
                    picBox.Load("asus.png");
                    break;
         
                case "2021 - Nomadland":
                    picBox.Load("nomadland.jpg");
                        break;
                case "2020 - Parasita":
                    picBox.Load("parasite.jpg");
                    break;
                case "2019 - Green Book":
                    picBox.Load("GreenBook.jpg");
                    break;
                case "2018 - A Forma da água.":
                    picBox.Load("aformaagua.jpg");
                    break;
                case "2017 - Moonlight - Sob a luz do luar.":
                    picBox.Load("moonlight.jpg");
                    break;
            }
        }
    }
}