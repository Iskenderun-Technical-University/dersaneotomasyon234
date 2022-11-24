using System;
using System.Windows.Forms;

namespace DershaneProgramı
{
    public partial class frmAnaPanel : Form
    {

        public static string KulAdı;
  
        public frmAnaPanel()
        {
            InitializeComponent();
        }

        private void frmAnaPanel_Load(object sender, EventArgs e)
        {

            frmGirişPaneli frmGiriş = new frmGirişPaneli();
            frmGiriş.ShowDialog();

            lblKullanıcıAdı.Text = KulAdı;

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıEkle frmKulEkle = new frmKullanıcıEkle();
            frmKulEkle.ShowDialog();
        }

        private void kullanıcıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıDüzenle frmKulDüzenle = new frmKullanıcıDüzenle();
            frmKulDüzenle.ShowDialog();
        }

        private void öğrenciKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖğrenciKaydet frmÖğrenciKaydet = new frmÖğrenciKaydet();

            frmÖğrenciKaydet.ShowDialog();


        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖğrenciDüzenle frmÖğrenciDüzenle = new frmÖğrenciDüzenle();
            frmÖğrenciDüzenle.ShowDialog();
        }
    }
}
