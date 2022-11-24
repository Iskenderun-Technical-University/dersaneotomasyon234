using System;
using System.Windows.Forms;
using Klaslarım;

namespace DershaneProgramı
{
    public partial class frmKullanıcıEkle : Form
    {
        public frmKullanıcıEkle()
        {
            InitializeComponent();
        }

        private void frmKullanıcıEkle_Load(object sender, EventArgs e)
        {


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanıcı kul = new Kullanıcı();

            kul.AdıSoyadı = txtAdıSoyadı.Text;
            kul.KullanıcıAdı = txtKullanıcıAdı.Text;
            kul.Şifre = txtŞifre.Text;
            kul.Mail = txtMail.Text;
            kul.Telefon = txtTelefon.Text;

            // Kullanıcı bilgileri SQL e göndermeden önce kontrol edelim

            string HataVarMı;

            HataVarMı = BilgiKontrol.KullanıcıBilgileriGirilmişMi(kul);

            if(HataVarMı!="")
            {
                MessageBox.Show(HataVarMı);
                return;
            }
            else
            {
                if( ! BilgiKontrol.MailKontrol(kul.Mail))
                {
                    MessageBox.Show("Hatalı mail adresi");
                    return;
                }
            }


            // Kullanıcı eklensin mi diye kullanıcıdan onay alalım.

            DialogResult dr;

            dr = MessageBox.Show("Kullanıcı Eklensin Mi?", "EKLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr==DialogResult.No)
            {
                return;
            }


            Veritabanıİşlemleri vti = new Veritabanıİşlemleri();

            bool EklendiMi;


            EklendiMi = vti.KullanıcıEkle(kul);

            if(EklendiMi)
            {
                MessageBox.Show(kul.AdıSoyadı + " Adlı kullanıcı eklendi");
                // TextBox ları Temizleme metodunu çağıralım
                Temizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı eklenemedi!!!");
            }



        } // btn Click sonu

        void Temizle()
        {
            txtAdıSoyadı.Text = txtKullanıcıAdı.Text = txtŞifre.Text = txtMail.Text = txtTelefon.Text = "" ;

        }
        

    }
}
