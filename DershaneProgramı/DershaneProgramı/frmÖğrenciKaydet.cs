using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneProgramı
{
    public partial class frmÖğrenciKaydet : Form
    {
        public frmÖğrenciKaydet()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            // Bilgisayardan bir resim seçelim ve picturebox'a atalım.
            // Bilgisayardan bir file seçmek için openfiledialog class'ını kullanıyoruz. 

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if(ofd.FileName != "")
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }


        }

    }
}
