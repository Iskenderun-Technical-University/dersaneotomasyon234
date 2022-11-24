
namespace DershaneProgramı
{
    partial class frmÖğrenciKaydet
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
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDoğumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpKayıtTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbEğitim = new System.Windows.Forms.ComboBox();
            this.cmbKayıtTürü = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rchHakkında = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdı
            // 
            this.txtAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdı.Location = new System.Drawing.Point(108, 137);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(160, 23);
            this.txtAdı.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADI:";
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadı.Location = new System.Drawing.Point(108, 180);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(160, 23);
            this.txtSoyadı.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADI:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcNo.Location = new System.Drawing.Point(108, 218);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(160, 23);
            this.txtTcNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "T.C NO:";
            // 
            // dtpDoğumTarihi
            // 
            this.dtpDoğumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoğumTarihi.Location = new System.Drawing.Point(108, 259);
            this.dtpDoğumTarihi.Name = "dtpDoğumTarihi";
            this.dtpDoğumTarihi.Size = new System.Drawing.Size(160, 20);
            this.dtpDoğumTarihi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "CİNSİYET:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "D. TARİHİ:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(108, 296);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 3;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Location = new System.Drawing.Point(216, 296);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(52, 17);
            this.rdbKadın.TabIndex = 3;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            this.rdbKadın.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeslek.Location = new System.Drawing.Point(108, 330);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(160, 23);
            this.txtMeslek.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "MESLEĞİ:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(108, 367);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(160, 23);
            this.txtTelefon.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "TELEFON:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(108, 401);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 23);
            this.txtMail.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "MAİL:";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(108, 437);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(160, 23);
            this.txtAdres.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "ADRES:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(747, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "EĞİTİM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(711, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "KAYIT TÜRÜ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(706, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "KAYIT TARİHİ:";
            this.label12.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpKayıtTarihi
            // 
            this.dtpKayıtTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKayıtTarihi.Location = new System.Drawing.Point(811, 218);
            this.dtpKayıtTarihi.Name = "dtpKayıtTarihi";
            this.dtpKayıtTarihi.Size = new System.Drawing.Size(160, 20);
            this.dtpKayıtTarihi.TabIndex = 2;
            // 
            // cmbEğitim
            // 
            this.cmbEğitim.FormattingEnabled = true;
            this.cmbEğitim.Items.AddRange(new object[] {
            "Yazılım",
            "Network",
            "Server",
            "Java",
            "SQL",
            "İspanyolca"});
            this.cmbEğitim.Location = new System.Drawing.Point(812, 140);
            this.cmbEğitim.Name = "cmbEğitim";
            this.cmbEğitim.Size = new System.Drawing.Size(159, 21);
            this.cmbEğitim.TabIndex = 4;
            // 
            // cmbKayıtTürü
            // 
            this.cmbKayıtTürü.FormattingEnabled = true;
            this.cmbKayıtTürü.Items.AddRange(new object[] {
            "KesinKayıt",
            "ÖnKayıt"});
            this.cmbKayıtTürü.Location = new System.Drawing.Point(811, 179);
            this.cmbKayıtTürü.Name = "cmbKayıtTürü";
            this.cmbKayıtTürü.Size = new System.Drawing.Size(159, 21);
            this.cmbKayıtTürü.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(724, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "HAKKINDA:";
            this.label13.Click += new System.EventHandler(this.label4_Click);
            // 
            // rchHakkında
            // 
            this.rchHakkında.Location = new System.Drawing.Point(727, 294);
            this.rchHakkında.Name = "rchHakkında";
            this.rchHakkında.Size = new System.Drawing.Size(244, 163);
            this.rchHakkında.TabIndex = 5;
            this.rchHakkında.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.Location = new System.Drawing.Point(367, 437);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(253, 44);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumBlue;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 31);
            this.label14.TabIndex = 8;
            this.label14.Text = "KİŞİSEL BİLGİLER";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumBlue;
            this.label15.Location = new System.Drawing.Point(695, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(231, 31);
            this.label15.TabIndex = 8;
            this.label15.Text = "KAYIT BİLGİLERİ";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(42, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 50);
            this.panel1.TabIndex = 9;
            // 
            // frmÖğrenciKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchHakkında);
            this.Controls.Add(this.cmbKayıtTürü);
            this.Controls.Add(this.cmbEğitim);
            this.Controls.Add(this.rdbKadın);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.dtpKayıtTarihi);
            this.Controls.Add(this.dtpDoğumTarihi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMeslek);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdı);
            this.Name = "frmÖğrenciKaydet";
            this.Text = "frmÖğrenciKaydet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDoğumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpKayıtTarihi;
        private System.Windows.Forms.ComboBox cmbEğitim;
        private System.Windows.Forms.ComboBox cmbKayıtTürü;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rchHakkında;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
    }
}