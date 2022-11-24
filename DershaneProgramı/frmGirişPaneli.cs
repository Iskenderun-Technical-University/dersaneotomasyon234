using System;
using System.Drawing;
using System.Windows.Forms;

namespace DershaneProgramı
{
    public partial class frmGirişPaneli : Form
    {
        public frmGirişPaneli()
        {
            InitializeComponent();
        }


        byte Hak = 0;
        bool ProgramKapanmasın = false;
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string KulAdı = "ali";
            string Şifre = "1234";

            string GirilenKulAdı;
            string GirilenŞifre;

            // txtKullanıcıAdı ve txtŞifre ye girilen değerler ali ve 1234 mü kontrol edeceğiz.

            GirilenKulAdı = txtKullanıcıAdı.Text;
            GirilenŞifre = txtŞifre.Text;

            Hak++;

            if (GirilenKulAdı == KulAdı && GirilenŞifre == Şifre)
            {

                MessageBox.Show("Program açılıyor.......");
                ProgramKapanmasın = true;
                this.Close();
            }
            else
            {
                if (Hak == 3)
                {
                    MessageBox.Show("Sistem yöneticisi ile görüşün!!!,program sonlanacaktır");
                    Application.Exit(); // programı kapat.
                }

                // MessageBox.Show("KullanıcıAdı/Şifre hatalı...!!!\n "+(3-Hak)+" Hakkınız kaldı");

                lblMesaj.Text = "KullanıcıAdı/Şifre hatalı!!";
                lblMesaj.ForeColor = Color.Red;

            }

        }

        private void txtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

        private void txtŞifre_TextChanged(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

        private void frmGirişPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProgramKapanmasın)
            {
                // şifre doğru girilmiş,sadece bu formu(Giriş formu) kapatacağız
                // formu yukarıda kapatmıştık. bırak kapansın:))
            }
            else
            {
                // ya yanlış şifre girilmiş yada exit e basılarak çıkılmış
                // bu durmda uyguamayı/programı kapatacağız.
                Application.Exit();

            }
        }
    }
}
