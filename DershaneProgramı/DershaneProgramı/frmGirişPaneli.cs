using System;
using System.Drawing;
using System.Windows.Forms;
using Klaslarım;

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
           
            string GirilenKulAdı;
            string GirilenŞifre;

            // txtKullanıcıAdı ve txtŞifre ye girilen değerler ali ve 1234 mü kontrol edeceğiz.

            GirilenKulAdı = txtKullanıcıAdı.Text;
            GirilenŞifre = txtŞifre.Text;

            // Giriş panelinden girilen Kullanıcı Adı ve Şifreyi SQL e gönderip
            // Böyle bir kullanıcı var mı kontrol edelim.
            // Veritabanıİşlemeri klasından kullanıcı ekle metodunu çağıralım.


            Veritabanıİşlemleri vti = new Veritabanıİşlemleri();

            string Adı;

            Adı = vti.KullanıcıVarMı(GirilenKulAdı, GirilenŞifre);


            Hak++;

            if (Adı !="")
            {

                MessageBox.Show("Program açılıyor.......");
                ProgramKapanmasın = true;
                frmAnaPanel.KulAdı = Adı;

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

        private void frmGirişPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
