
namespace DershaneProgramı
{
    partial class frmÖğrenciDüzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranacakİsim = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eğitim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.dtpDoğumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rchHakkında = new System.Windows.Forms.RichTextBox();
            this.cmbSertifika = new System.Windows.Forms.ComboBox();
            this.cmbMezuniyet = new System.Windows.Forms.ComboBox();
            this.cmbKayıtTürü = new System.Windows.Forms.ComboBox();
            this.cmbEğitim = new System.Windows.Forms.ComboBox();
            this.dtpKayıtTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnKayıtGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI:";
            // 
            // txtAranacakİsim
            // 
            this.txtAranacakİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAranacakİsim.Location = new System.Drawing.Point(438, 27);
            this.txtAranacakİsim.Name = "txtAranacakİsim";
            this.txtAranacakİsim.Size = new System.Drawing.Size(171, 23);
            this.txtAranacakİsim.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(641, 24);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(130, 28);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adı,
            this.Soyadı,
            this.TcNo,
            this.Eğitim});
            this.dataGridView1.Location = new System.Drawing.Point(262, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 113);
            this.dataGridView1.TabIndex = 3;
            // 
            // Adı
            // 
            this.Adı.HeaderText = "ADI";
            this.Adı.Name = "Adı";
            this.Adı.Width = 150;
            // 
            // Soyadı
            // 
            this.Soyadı.HeaderText = "SOYADI";
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.Width = 150;
            // 
            // TcNo
            // 
            this.TcNo.HeaderText = "TCNO";
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 150;
            // 
            // Eğitim
            // 
            this.Eğitim.HeaderText = "EĞİTİM";
            this.Eğitim.Name = "Eğitim";
            this.Eğitim.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbKadın);
            this.panel1.Controls.Add(this.rdbErkek);
            this.panel1.Controls.Add(this.dtpDoğumTarihi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMeslek);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTcNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSoyadı);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAdı);
            this.panel1.Location = new System.Drawing.Point(33, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 358);
            this.panel1.TabIndex = 4;
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Location = new System.Drawing.Point(195, 166);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(52, 17);
            this.rdbKadın.TabIndex = 3;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(99, 166);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 3;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDoğumTarihi
            // 
            this.dtpDoğumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoğumTarihi.Location = new System.Drawing.Point(99, 125);
            this.dtpDoğumTarihi.Name = "dtpDoğumTarihi";
            this.dtpDoğumTarihi.Size = new System.Drawing.Size(171, 20);
            this.dtpDoğumTarihi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "CİNSİYETİ:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "D. TARİHİ:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "ADRES:";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(99, 296);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(171, 23);
            this.txtAdres.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "MAİL:";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(99, 261);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(171, 23);
            this.txtMail.TabIndex = 1;
            this.txtMail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "TELEFON:";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(99, 224);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(171, 23);
            this.txtTelefon.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "MESLEĞİ:";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeslek.Location = new System.Drawing.Point(99, 195);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(171, 23);
            this.txtMeslek.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "T.C NO:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcNo.Location = new System.Drawing.Point(99, 86);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(171, 23);
            this.txtTcNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYADI:";
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadı.Location = new System.Drawing.Point(99, 49);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(171, 23);
            this.txtSoyadı.TabIndex = 1;
            this.txtSoyadı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADI:";
            // 
            // txtAdı
            // 
            this.txtAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdı.Location = new System.Drawing.Point(99, 20);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(171, 23);
            this.txtAdı.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(33, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 41);
            this.panel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(30, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "KİŞİSEL BİLGİLER";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(713, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 41);
            this.panel3.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(48, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "KAYIT BİLGİLERİ";
            this.label12.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rchHakkında);
            this.panel4.Controls.Add(this.cmbSertifika);
            this.panel4.Controls.Add(this.cmbMezuniyet);
            this.panel4.Controls.Add(this.cmbKayıtTürü);
            this.panel4.Controls.Add(this.cmbEğitim);
            this.panel4.Controls.Add(this.dtpKayıtTarihi);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(681, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 358);
            this.panel4.TabIndex = 4;
            // 
            // rchHakkında
            // 
            this.rchHakkında.Location = new System.Drawing.Point(35, 225);
            this.rchHakkında.Name = "rchHakkında";
            this.rchHakkında.Size = new System.Drawing.Size(255, 96);
            this.rchHakkında.TabIndex = 4;
            this.rchHakkında.Text = "";
            // 
            // cmbSertifika
            // 
            this.cmbSertifika.FormattingEnabled = true;
            this.cmbSertifika.Location = new System.Drawing.Point(119, 169);
            this.cmbSertifika.Name = "cmbSertifika";
            this.cmbSertifika.Size = new System.Drawing.Size(171, 21);
            this.cmbSertifika.TabIndex = 3;
            // 
            // cmbMezuniyet
            // 
            this.cmbMezuniyet.FormattingEnabled = true;
            this.cmbMezuniyet.Location = new System.Drawing.Point(119, 128);
            this.cmbMezuniyet.Name = "cmbMezuniyet";
            this.cmbMezuniyet.Size = new System.Drawing.Size(171, 21);
            this.cmbMezuniyet.TabIndex = 3;
            // 
            // cmbKayıtTürü
            // 
            this.cmbKayıtTürü.FormattingEnabled = true;
            this.cmbKayıtTürü.Location = new System.Drawing.Point(119, 52);
            this.cmbKayıtTürü.Name = "cmbKayıtTürü";
            this.cmbKayıtTürü.Size = new System.Drawing.Size(171, 21);
            this.cmbKayıtTürü.TabIndex = 3;
            // 
            // cmbEğitim
            // 
            this.cmbEğitim.FormattingEnabled = true;
            this.cmbEğitim.Location = new System.Drawing.Point(119, 23);
            this.cmbEğitim.Name = "cmbEğitim";
            this.cmbEğitim.Size = new System.Drawing.Size(171, 21);
            this.cmbEğitim.TabIndex = 3;
            // 
            // dtpKayıtTarihi
            // 
            this.dtpKayıtTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKayıtTarihi.Location = new System.Drawing.Point(119, 89);
            this.dtpKayıtTarihi.Name = "dtpKayıtTarihi";
            this.dtpKayıtTarihi.Size = new System.Drawing.Size(171, 20);
            this.dtpKayıtTarihi.TabIndex = 2;
            this.dtpKayıtTarihi.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "SERTİFİKA:";
            this.label13.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "MEZUNİYET:";
            this.label14.Click += new System.EventHandler(this.label4_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(36, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "HAKKINDA:";
            this.label18.Click += new System.EventHandler(this.label4_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "KAYIT TARİHİ:";
            this.label19.Click += new System.EventHandler(this.label4_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "KAYIT TÜRÜ:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(55, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "EĞİTİM:";
            // 
            // btnKayıtGüncelle
            // 
            this.btnKayıtGüncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKayıtGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayıtGüncelle.Location = new System.Drawing.Point(409, 580);
            this.btnKayıtGüncelle.Name = "btnKayıtGüncelle";
            this.btnKayıtGüncelle.Size = new System.Drawing.Size(222, 48);
            this.btnKayıtGüncelle.TabIndex = 2;
            this.btnKayıtGüncelle.Text = "KAYIT GÜNCELLE";
            this.btnKayıtGüncelle.UseVisualStyleBackColor = false;
            // 
            // frmÖğrenciDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKayıtGüncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtAranacakİsim);
            this.Controls.Add(this.label1);
            this.Name = "frmÖğrenciDüzenle";
            this.Text = "frmÖğrenciDüzenle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranacakİsim;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eğitim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDoğumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rchHakkında;
        private System.Windows.Forms.ComboBox cmbSertifika;
        private System.Windows.Forms.ComboBox cmbMezuniyet;
        private System.Windows.Forms.ComboBox cmbKayıtTürü;
        private System.Windows.Forms.ComboBox cmbEğitim;
        private System.Windows.Forms.DateTimePicker dtpKayıtTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnKayıtGüncelle;
    }
}