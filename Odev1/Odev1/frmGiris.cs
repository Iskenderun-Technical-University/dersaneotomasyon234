namespace Odev1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string GirilenKul;
            string GirilenÞif;

            GirilenKul = "Alperen";
            GirilenÞif = "1234";

            GirilenKul = txt1.Text;
            GirilenÞif = txt2.Text;


            if((GirilenKul=="Alperen")&&(GirilenÞif=="1234"))
            {
                MessageBox.Show("Program açýlýyor.......");               
                frmAnaPanel f2 = new frmAnaPanel();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlýþ Kullanýcý Adý / Þifre ! Program Kapanýyor....");
                Application.Exit();
            }

        }
    }
}