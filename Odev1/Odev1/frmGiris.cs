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
            string Girilen�if;

            GirilenKul = "Alperen";
            Girilen�if = "1234";

            GirilenKul = txt1.Text;
            Girilen�if = txt2.Text;


            if((GirilenKul=="Alperen")&&(Girilen�if=="1234"))
            {
                MessageBox.Show("Program a��l�yor.......");               
                frmAnaPanel f2 = new frmAnaPanel();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanl�� Kullan�c� Ad� / �ifre ! Program Kapan�yor....");
                Application.Exit();
            }

        }
    }
}