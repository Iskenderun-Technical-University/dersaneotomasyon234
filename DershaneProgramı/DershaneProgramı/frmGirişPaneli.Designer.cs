
namespace DershaneProgramı
{
    partial class frmGirişPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirişPaneli));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ŞİFRE :";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(496, 128);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(175, 26);
            this.txtKullanıcıAdı.TabIndex = 3;
            this.txtKullanıcıAdı.Text = "alperen";
            this.txtKullanıcıAdı.TextChanged += new System.EventHandler(this.txtKullanıcıAdı_TextChanged);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtŞifre.Location = new System.Drawing.Point(496, 178);
            this.txtŞifre.MaxLength = 4;
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(175, 26);
            this.txtŞifre.TabIndex = 4;
            this.txtŞifre.Text = "7642";
            this.txtŞifre.TextChanged += new System.EventHandler(this.txtŞifre_TextChanged);
            // 
            // btnGiriş
            // 
            this.btnGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiriş.Location = new System.Drawing.Point(387, 291);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(284, 41);
            this.btnGiriş.TabIndex = 5;
            this.btnGiriş.Text = "GİRİŞ";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "DERSHANE PROGRAMI";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(504, 216);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 7;
            // 
            // frmGirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 405);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGirişPaneli";
            this.Text = "frmGirişPaneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGirişPaneli_FormClosing);
            this.Load += new System.EventHandler(this.frmGirişPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMesaj;
    }
}