namespace Lebit_Otel_Uygulaması
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            BtnShowData = new Button();
            BtnCikisMusteri = new Button();
            BtnSil = new Button();
            BtnAra = new Button();
            BtnGuncelle = new Button();
            CbxCinsiyet = new ComboBox();
            label10 = new Label();
            textUcret = new TextBox();
            label9 = new Label();
            DtpCikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            MskTelefonNum = new MaskedTextBox();
            textOdaNo = new TextBox();
            textMail = new TextBox();
            textKimlik = new TextBox();
            textSoyadi = new TextBox();
            textAdi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnTemizle = new Button();
            textbox1 = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.Location = new Point(10, 413);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1115, 228);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TC";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Mail";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "OdaNo";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "GirişTarihi";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "ÇıkışTarihi";
            // 
            // BtnShowData
            // 
            BtnShowData.BackColor = Color.FromArgb(192, 192, 255);
            BtnShowData.Location = new Point(10, 29);
            BtnShowData.Margin = new Padding(4);
            BtnShowData.Name = "BtnShowData";
            BtnShowData.Size = new Size(171, 46);
            BtnShowData.TabIndex = 1;
            BtnShowData.Text = "Verileri Göster";
            BtnShowData.UseVisualStyleBackColor = false;
            BtnShowData.Click += button1_Click;
            // 
            // BtnCikisMusteri
            // 
            BtnCikisMusteri.BackColor = Color.FromArgb(255, 128, 128);
            BtnCikisMusteri.Location = new Point(13, 299);
            BtnCikisMusteri.Margin = new Padding(4);
            BtnCikisMusteri.Name = "BtnCikisMusteri";
            BtnCikisMusteri.Size = new Size(171, 46);
            BtnCikisMusteri.TabIndex = 2;
            BtnCikisMusteri.Text = "Çıkış";
            BtnCikisMusteri.UseVisualStyleBackColor = false;
            BtnCikisMusteri.Click += BtnCikisMusteri_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.FromArgb(192, 192, 255);
            BtnSil.Location = new Point(10, 191);
            BtnSil.Margin = new Padding(4);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(171, 46);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += button1_Click_1;
            // 
            // BtnAra
            // 
            BtnAra.BackColor = Color.FromArgb(192, 192, 255);
            BtnAra.Location = new Point(10, 137);
            BtnAra.Margin = new Padding(4);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(171, 46);
            BtnAra.TabIndex = 4;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = false;
            BtnAra.Click += button2_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.FromArgb(192, 192, 255);
            BtnGuncelle.Location = new Point(10, 83);
            BtnGuncelle.Margin = new Padding(4);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(171, 46);
            BtnGuncelle.TabIndex = 5;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += button3_Click;
            // 
            // CbxCinsiyet
            // 
            CbxCinsiyet.BackColor = Color.FromArgb(255, 255, 192);
            CbxCinsiyet.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbxCinsiyet.FormattingEnabled = true;
            CbxCinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            CbxCinsiyet.Location = new Point(361, 133);
            CbxCinsiyet.Name = "CbxCinsiyet";
            CbxCinsiyet.Size = new Size(266, 38);
            CbxCinsiyet.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(251, 133);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 59;
            label10.Text = "Cinsiyet :";
            // 
            // textUcret
            // 
            textUcret.BackColor = Color.FromArgb(255, 255, 192);
            textUcret.Enabled = false;
            textUcret.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textUcret.Location = new Point(803, 134);
            textUcret.Name = "textUcret";
            textUcret.Size = new Size(266, 37);
            textUcret.TabIndex = 58;
            textUcret.TextChanged += textUcret_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(717, 137);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 57;
            label9.Text = "Ücret :";
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            DtpCikisTarihi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            DtpCikisTarihi.Location = new Point(803, 220);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(266, 37);
            DtpCikisTarihi.TabIndex = 56;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            DtpGirisTarihi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            DtpGirisTarihi.Location = new Point(803, 176);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(266, 37);
            DtpGirisTarihi.TabIndex = 55;
            DtpGirisTarihi.ValueChanged += DtpGirisTarihi_ValueChanged;
            // 
            // MskTelefonNum
            // 
            MskTelefonNum.BackColor = Color.FromArgb(255, 255, 192);
            MskTelefonNum.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            MskTelefonNum.Location = new Point(361, 176);
            MskTelefonNum.Mask = "(999) 000-0000";
            MskTelefonNum.Name = "MskTelefonNum";
            MskTelefonNum.Size = new Size(266, 37);
            MskTelefonNum.TabIndex = 54;
            // 
            // textOdaNo
            // 
            textOdaNo.BackColor = Color.FromArgb(255, 255, 192);
            textOdaNo.Enabled = false;
            textOdaNo.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textOdaNo.Location = new Point(803, 91);
            textOdaNo.Name = "textOdaNo";
            textOdaNo.Size = new Size(266, 37);
            textOdaNo.TabIndex = 53;
            // 
            // textMail
            // 
            textMail.BackColor = Color.FromArgb(255, 255, 192);
            textMail.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textMail.Location = new Point(803, 48);
            textMail.Name = "textMail";
            textMail.Size = new Size(266, 37);
            textMail.TabIndex = 52;
            textMail.TextChanged += textMail_TextChanged;
            // 
            // textKimlik
            // 
            textKimlik.BackColor = Color.FromArgb(255, 255, 192);
            textKimlik.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textKimlik.Location = new Point(361, 220);
            textKimlik.MaxLength = 11;
            textKimlik.Name = "textKimlik";
            textKimlik.Size = new Size(266, 37);
            textKimlik.TabIndex = 51;
            // 
            // textSoyadi
            // 
            textSoyadi.BackColor = Color.FromArgb(255, 255, 192);
            textSoyadi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textSoyadi.Location = new Point(361, 90);
            textSoyadi.Name = "textSoyadi";
            textSoyadi.Size = new Size(266, 37);
            textSoyadi.TabIndex = 50;
            // 
            // textAdi
            // 
            textAdi.BackColor = Color.FromArgb(255, 255, 192);
            textAdi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textAdi.Location = new Point(361, 47);
            textAdi.Name = "textAdi";
            textAdi.Size = new Size(266, 37);
            textAdi.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(669, 226);
            label8.Name = "label8";
            label8.Size = new Size(119, 28);
            label8.TabIndex = 48;
            label8.Text = "Çıkış Tarihi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(671, 180);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 47;
            label7.Text = "Giriş Tarihi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(636, 95);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 46;
            label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(196, 220);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 45;
            label5.Text = "T.C. Kimlik No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(727, 51);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 44;
            label4.Text = "Mail :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(204, 176);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 43;
            label3.Text = "Telefon Num :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(262, 90);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 42;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(292, 46);
            label1.Name = "label1";
            label1.Size = new Size(53, 28);
            label1.TabIndex = 41;
            label1.Text = "Adı :";
            // 
            // BtnTemizle
            // 
            BtnTemizle.BackColor = Color.FromArgb(192, 192, 255);
            BtnTemizle.Location = new Point(10, 245);
            BtnTemizle.Margin = new Padding(4);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(171, 46);
            BtnTemizle.TabIndex = 61;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = false;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // textbox1
            // 
            textbox1.BackColor = Color.FromArgb(255, 255, 192);
            textbox1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textbox1.Location = new Point(575, 320);
            textbox1.MaxLength = 11;
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(266, 37);
            textbox1.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(410, 320);
            label11.Name = "label11";
            label11.Size = new Size(149, 28);
            label11.TabIndex = 62;
            label11.Text = "Aranacak İsim :";
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(33, 228, 189);
            ClientSize = new Size(1127, 643);
            Controls.Add(textbox1);
            Controls.Add(label11);
            Controls.Add(BtnTemizle);
            Controls.Add(CbxCinsiyet);
            Controls.Add(label10);
            Controls.Add(textUcret);
            Controls.Add(label9);
            Controls.Add(DtpCikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(MskTelefonNum);
            Controls.Add(textOdaNo);
            Controls.Add(textMail);
            Controls.Add(textKimlik);
            Controls.Add(textSoyadi);
            Controls.Add(textAdi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnAra);
            Controls.Add(BtnSil);
            Controls.Add(BtnCikisMusteri);
            Controls.Add(BtnShowData);
            Controls.Add(listView1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            Text = "Müşteri Bilgileri";
            Load += FrmMusteriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button BtnShowData;
        private Button BtnCikisMusteri;
        private Button BtnSil;
        private Button BtnAra;
        private Button BtnGuncelle;
        private ComboBox CbxCinsiyet;
        private Label label10;
        private TextBox textUcret;
        private Label label9;
        private DateTimePicker DtpCikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private MaskedTextBox MskTelefonNum;
        private TextBox textOdaNo;
        private TextBox textMail;
        private TextBox textKimlik;
        private TextBox textSoyadi;
        private TextBox textAdi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnTemizle;
        private TextBox textbox1;
        private Label label11;
    }
}