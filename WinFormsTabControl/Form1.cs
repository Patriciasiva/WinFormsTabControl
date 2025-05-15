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
            txtInicio1.Text = Convert.ToString(ini = DateTime.Now);
            for (int i = 0; i < 15000; i++)
            {
                A += "a";
            }
            DateTime fin = new DateTime();
            txtfim1.Text = Convert.ToString(fin = DateTime.Now);
            string dif = Convert.ToString(fin - ini);
            txtdiferenca1.Text = string.Format("{0:t}", dif);


        }
    }
}
