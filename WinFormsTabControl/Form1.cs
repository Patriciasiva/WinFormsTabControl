namespace WinFormsTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string A = "";
            DateTime ini = new DateTime();
            txtInicio2.Text = Convert.ToString(ini = DateTime.Now);
            for (int i = 0; i < 15000; i++)
            {
                A += "a";
            }
            DateTime fin = new DateTime();
            txtFim2.Text = Convert.ToString(fin = DateTime.Now);
            string dif = Convert.ToString(fin - ini);
            txtDiferenca2.Text = string.Format("{0:t}", dif);


        }
    }
}
