using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klaslarım;

namespace DershaneProgramı
{
    public partial class frmKullanıcıDüzenle : Form
    {
        public frmKullanıcıDüzenle()
        {
            InitializeComponent();
        }

        private void frmKullanıcıDüzenle_Load(object sender, EventArgs e)
        {
            KullanıcıListesi();
        }


        void KullanıcıListesi()
        {
            Veritabanıİşlemleri vti = new Veritabanıİşlemleri();
            DataTable dt = vti.KullanıcıListesi();

            // gridview içinde tablo gösterir.
            // gelen tabloyu girde atalım
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["No"].Visible = false;
        }



        int KulNo=0;
        int SeçilenSatır = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeçilenSatır = e.RowIndex;

            if(SeçilenSatır<0)
            {
                // en üst satır(kolon adları) seçilmişse çıkalım
                return;
            }

            KulNo = Convert.ToInt32( dataGridView1.Rows[SeçilenSatır].Cells["No"].Value);
            txtAdıSoyadı.Text = dataGridView1.Rows[SeçilenSatır].Cells["AdıSoyadı"].Value.ToString();
            txtKullanıcıAdı.Text= dataGridView1.Rows[SeçilenSatır].Cells["KullanıcıAdı"].Value.ToString();
            txtŞifre.Text = dataGridView1.Rows[SeçilenSatır].Cells["Şifre"].Value.ToString();
            txtMail.Text = dataGridView1.Rows[SeçilenSatır].Cells["Mail"].Value.ToString();
            txtTelefon.Text= dataGridView1.Rows[SeçilenSatır].Cells["Telefon"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(KulNo !=0)
            {
                // Kullanıcı seçilmiş sileceğiz.

                DialogResult dr = MessageBox.Show("Kullnıcı Siliniyor", "SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dr==DialogResult.OK)
                {
                    Veritabanıİşlemleri vti = new Veritabanıİşlemleri();

                    bool SilindiMi = vti.KullnıcıSil(KulNo);
                         
                    if(SilindiMi)
                    {
                        MessageBox.Show("Kullanıcı Silindi..");
                        Temizle();
                        KullanıcıListesi();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Silinemedi!!");
                    }


                }
            }
            else
            {
                MessageBox.Show("Kullanıcı seçmediniz!!");
            }


        }

        void Temizle()
        {
            txtAdıSoyadı.Text = txtKullanıcıAdı.Text = txtŞifre.Text = txtMail.Text = txtTelefon.Text = "";
            KulNo = 0;
            SeçilenSatır = -1;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            // Bir kullanıcı seçilmiş mi diye kontrol ediyoruz.
            if(KulNo <= 0)
            {
                MessageBox.Show("Kullanıcı seçmediniz ! ");
                return;
            }
            // Seçilen kulanıcıyı güncelleyelim.
            // Kullanıcının yeni verilerini kullanıcı class'ından bir objeye alalım.
            Kullanıcı kul = new Kullanıcı();
            kul.No = KulNo;
            kul.AdıSoyadı = txtAdıSoyadı.Text.Trim();
            kul.KullanıcıAdı = txtKullanıcıAdı.Text.Trim();
            kul.Şifre = txtŞifre.Text.Trim();
            kul.Telefon = txtTelefon.Text.Trim();
            kul.Mail = txtMail.Text.Trim();

            // Kullanıcı bilgileri verilmiş mi kontrol ediyoruz. 

            string Hata;
            Hata = BilgiKontrol.KullanıcıBilgileriGirilmişMi(kul);
            
            if(Hata !="")
            {
                MessageBox.Show(Hata);
                return;
            }
             
            // Mail Kontrol
            if(BilgiKontrol.MailKontrol(kul.Mail)==false)
            {
                MessageBox.Show("Mail formatı yanlış ! ");
                return;
            }


            // Kullanıcı seçilmiş ve kullanıcı bilgileri doğru girilmiş
            // Bu verileri veritabanı işlemleri class'ındaki KullanıcılarıGüncelle metoduna gönderelim ve SQL'e yeni bilgi gönderilsin.

            bool GüncellendiMi;
            Veritabanıİşlemleri vti = new Veritabanıİşlemleri();
            GüncellendiMi = vti.KullanıcıGüncelle(kul);
            
            if(GüncellendiMi)
            {
                MessageBox.Show("Kullanıcı Güncellendi.");
                Temizle();
                KullanıcıListesi();
            }
            else
            {
                MessageBox.Show("Kullanıcı Güncellenemedi.");
            }
        }
    }
}
