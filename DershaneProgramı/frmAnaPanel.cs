using System;
using System.Windows.Forms;

namespace DershaneProgramı
{
    public partial class frmAnaPanel : Form
    {
        public frmAnaPanel()
        {
            InitializeComponent();
        }

        private void frmAnaPanel_Load(object sender, EventArgs e)
        {

            frmGirişPaneli frmGiriş = new frmGirişPaneli();
            frmGiriş.ShowDialog();


        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıEkle frmKulEkle = new frmKullanıcıEkle();
            frmKulEkle.ShowDialog();
        }
    }
}
