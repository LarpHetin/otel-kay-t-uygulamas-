namespace Lebit_Otel_Uygulaması
{
    partial class FrmYeniMüşteri
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
            groupBox1 = new GroupBox();
            label11 = new Label();
            CbxCinsiyet = new ComboBox();
            label10 = new Label();
            textUcret = new TextBox();
            label9 = new Label();
            BtnKaydet = new Button();
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
            groupBox2 = new GroupBox();
            BtnOda503 = new Button();
            BtnOda502 = new Button();
            BtnOda501 = new Button();
            BtnOda403 = new Button();
            BtnOda402 = new Button();
            BtnOda401 = new Button();
            BtnOda303 = new Button();
            BtnOda302 = new Button();
            BtnOda301 = new Button();
            BtnOda203 = new Button();
            BtnOda202 = new Button();
            BtnOda201 = new Button();
            BtnOda103 = new Button();
            BtnOda102 = new Button();
            BtnOda101 = new Button();
            BtnBosOda = new Button();
            BtnDoluOda = new Button();
            BtnMusteriCikis = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkTurquoise;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(CbxCinsiyet);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textUcret);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(BtnKaydet);
            groupBox1.Controls.Add(DtpCikisTarihi);
            groupBox1.Controls.Add(DtpGirisTarihi);
            groupBox1.Controls.Add(MskTelefonNum);
            groupBox1.Controls.Add(textOdaNo);
            groupBox1.Controls.Add(textMail);
            groupBox1.Controls.Add(textKimlik);
            groupBox1.Controls.Add(textSoyadi);
            groupBox1.Controls.Add(textAdi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 552);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgiler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(48, 359);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 41;
            label11.Text = "0";
            label11.Visible = false;
            // 
            // CbxCinsiyet
            // 
            CbxCinsiyet.BackColor = Color.FromArgb(255, 255, 192);
            CbxCinsiyet.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbxCinsiyet.FormattingEnabled = true;
            CbxCinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            CbxCinsiyet.Location = new Point(183, 134);
            CbxCinsiyet.Name = "CbxCinsiyet";
            CbxCinsiyet.Size = new Size(317, 38);
            CbxCinsiyet.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(73, 134);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 39;
            label10.Text = "Cinsiyet :";
            // 
            // textUcret
            // 
            textUcret.BackColor = Color.FromArgb(255, 255, 192);
            textUcret.Enabled = false;
            textUcret.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textUcret.Location = new Point(183, 352);
            textUcret.Name = "textUcret";
            textUcret.Size = new Size(317, 37);
            textUcret.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(96, 352);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 37;
            label9.Text = "Ücret :";
            label9.Click += label9_Click;
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = SystemColors.ButtonShadow;
            BtnKaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKaydet.Location = new Point(252, 491);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(157, 44);
            BtnKaydet.TabIndex = 36;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = false;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            DtpCikisTarihi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            DtpCikisTarihi.Location = new Point(183, 438);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(317, 37);
            DtpCikisTarihi.TabIndex = 35;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            DtpGirisTarihi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            DtpGirisTarihi.Location = new Point(183, 395);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(317, 37);
            DtpGirisTarihi.TabIndex = 34;
            // 
            // MskTelefonNum
            // 
            MskTelefonNum.BackColor = Color.FromArgb(255, 255, 192);
            MskTelefonNum.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            MskTelefonNum.Location = new Point(183, 177);
            MskTelefonNum.Mask = "(999) 000-0000";
            MskTelefonNum.Name = "MskTelefonNum";
            MskTelefonNum.Size = new Size(317, 37);
            MskTelefonNum.TabIndex = 33;
            // 
            // textOdaNo
            // 
            textOdaNo.BackColor = Color.FromArgb(255, 255, 192);
            textOdaNo.Enabled = false;
            textOdaNo.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textOdaNo.Location = new Point(183, 309);
            textOdaNo.Name = "textOdaNo";
            textOdaNo.Size = new Size(317, 37);
            textOdaNo.TabIndex = 32;
            // 
            // textMail
            // 
            textMail.BackColor = Color.FromArgb(255, 255, 192);
            textMail.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textMail.Location = new Point(183, 265);
            textMail.Name = "textMail";
            textMail.Size = new Size(317, 37);
            textMail.TabIndex = 31;
            // 
            // textKimlik
            // 
            textKimlik.BackColor = Color.FromArgb(255, 255, 192);
            textKimlik.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textKimlik.Location = new Point(183, 221);
            textKimlik.MaxLength = 11;
            textKimlik.Name = "textKimlik";
            textKimlik.Size = new Size(317, 37);
            textKimlik.TabIndex = 30;
            // 
            // textSoyadi
            // 
            textSoyadi.BackColor = Color.FromArgb(255, 255, 192);
            textSoyadi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textSoyadi.Location = new Point(183, 91);
            textSoyadi.Name = "textSoyadi";
            textSoyadi.Size = new Size(317, 37);
            textSoyadi.TabIndex = 29;
            // 
            // textAdi
            // 
            textAdi.BackColor = Color.FromArgb(255, 255, 192);
            textAdi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            textAdi.Location = new Point(183, 47);
            textAdi.Name = "textAdi";
            textAdi.Size = new Size(317, 37);
            textAdi.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(48, 439);
            label8.Name = "label8";
            label8.Size = new Size(119, 28);
            label8.TabIndex = 27;
            label8.Text = "Çıkış Tarihi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(50, 395);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 26;
            label7.Text = "Giriş Tarihi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(15, 309);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 25;
            label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(18, 221);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 24;
            label5.Text = "T.C. Kimlik No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(112, 265);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 23;
            label4.Text = "Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(26, 177);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 22;
            label3.Text = "Telefon Num :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(84, 91);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 21;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(114, 47);
            label1.Name = "label1";
            label1.Size = new Size(53, 28);
            label1.TabIndex = 20;
            label1.Text = "Adı :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnOda503);
            groupBox2.Controls.Add(BtnOda502);
            groupBox2.Controls.Add(BtnOda501);
            groupBox2.Controls.Add(BtnOda403);
            groupBox2.Controls.Add(BtnOda402);
            groupBox2.Controls.Add(BtnOda401);
            groupBox2.Controls.Add(BtnOda303);
            groupBox2.Controls.Add(BtnOda302);
            groupBox2.Controls.Add(BtnOda301);
            groupBox2.Controls.Add(BtnOda203);
            groupBox2.Controls.Add(BtnOda202);
            groupBox2.Controls.Add(BtnOda201);
            groupBox2.Controls.Add(BtnOda103);
            groupBox2.Controls.Add(BtnOda102);
            groupBox2.Controls.Add(BtnOda101);
            groupBox2.Location = new Point(563, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 552);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // BtnOda503
            // 
            BtnOda503.BackColor = Color.GreenYellow;
            BtnOda503.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda503.Location = new Point(277, 410);
            BtnOda503.Name = "BtnOda503";
            BtnOda503.Size = new Size(106, 58);
            BtnOda503.TabIndex = 14;
            BtnOda503.Text = "503";
            BtnOda503.UseVisualStyleBackColor = false;
            BtnOda503.Click += BtnOda503_Click;
            // 
            // BtnOda502
            // 
            BtnOda502.BackColor = Color.GreenYellow;
            BtnOda502.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda502.Location = new Point(149, 410);
            BtnOda502.Name = "BtnOda502";
            BtnOda502.Size = new Size(106, 58);
            BtnOda502.TabIndex = 13;
            BtnOda502.Text = "502";
            BtnOda502.UseVisualStyleBackColor = false;
            BtnOda502.Click += BtnOda502_Click;
            // 
            // BtnOda501
            // 
            BtnOda501.BackColor = Color.GreenYellow;
            BtnOda501.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda501.Location = new Point(19, 410);
            BtnOda501.Name = "BtnOda501";
            BtnOda501.Size = new Size(106, 58);
            BtnOda501.TabIndex = 12;
            BtnOda501.Text = "501";
            BtnOda501.UseVisualStyleBackColor = false;
            BtnOda501.Click += BtnOda501_Click;
            // 
            // BtnOda403
            // 
            BtnOda403.BackColor = Color.GreenYellow;
            BtnOda403.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda403.Location = new Point(277, 323);
            BtnOda403.Name = "BtnOda403";
            BtnOda403.Size = new Size(106, 58);
            BtnOda403.TabIndex = 11;
            BtnOda403.Text = "403";
            BtnOda403.UseVisualStyleBackColor = false;
            BtnOda403.Click += BtnOda403_Click;
            // 
            // BtnOda402
            // 
            BtnOda402.BackColor = Color.GreenYellow;
            BtnOda402.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda402.Location = new Point(149, 323);
            BtnOda402.Name = "BtnOda402";
            BtnOda402.Size = new Size(106, 58);
            BtnOda402.TabIndex = 10;
            BtnOda402.Text = "402";
            BtnOda402.UseVisualStyleBackColor = false;
            BtnOda402.Click += BtnOda402_Click;
            // 
            // BtnOda401
            // 
            BtnOda401.BackColor = Color.GreenYellow;
            BtnOda401.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda401.Location = new Point(19, 323);
            BtnOda401.Name = "BtnOda401";
            BtnOda401.Size = new Size(106, 58);
            BtnOda401.TabIndex = 9;
            BtnOda401.Text = "401";
            BtnOda401.UseVisualStyleBackColor = false;
            BtnOda401.Click += BtnOda401_Click;
            // 
            // BtnOda303
            // 
            BtnOda303.BackColor = Color.GreenYellow;
            BtnOda303.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda303.Location = new Point(277, 235);
            BtnOda303.Name = "BtnOda303";
            BtnOda303.Size = new Size(106, 58);
            BtnOda303.TabIndex = 8;
            BtnOda303.Text = "303";
            BtnOda303.UseVisualStyleBackColor = false;
            BtnOda303.Click += BtnOda303_Click;
            // 
            // BtnOda302
            // 
            BtnOda302.BackColor = Color.GreenYellow;
            BtnOda302.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda302.Location = new Point(149, 235);
            BtnOda302.Name = "BtnOda302";
            BtnOda302.Size = new Size(106, 58);
            BtnOda302.TabIndex = 7;
            BtnOda302.Text = "302";
            BtnOda302.UseVisualStyleBackColor = false;
            BtnOda302.Click += BtnOda302_Click;
            // 
            // BtnOda301
            // 
            BtnOda301.BackColor = Color.GreenYellow;
            BtnOda301.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda301.Location = new Point(19, 235);
            BtnOda301.Name = "BtnOda301";
            BtnOda301.Size = new Size(106, 58);
            BtnOda301.TabIndex = 6;
            BtnOda301.Text = "301";
            BtnOda301.UseVisualStyleBackColor = false;
            BtnOda301.Click += BtnOda301_Click;
            // 
            // BtnOda203
            // 
            BtnOda203.BackColor = Color.GreenYellow;
            BtnOda203.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda203.Location = new Point(277, 142);
            BtnOda203.Name = "BtnOda203";
            BtnOda203.Size = new Size(106, 58);
            BtnOda203.TabIndex = 5;
            BtnOda203.Text = "203";
            BtnOda203.UseVisualStyleBackColor = false;
            BtnOda203.Click += BtnOda203_Click;
            // 
            // BtnOda202
            // 
            BtnOda202.BackColor = Color.GreenYellow;
            BtnOda202.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda202.Location = new Point(149, 142);
            BtnOda202.Name = "BtnOda202";
            BtnOda202.Size = new Size(106, 58);
            BtnOda202.TabIndex = 4;
            BtnOda202.Text = "202";
            BtnOda202.UseVisualStyleBackColor = false;
            BtnOda202.Click += BtnOda202_Click;
            // 
            // BtnOda201
            // 
            BtnOda201.BackColor = Color.GreenYellow;
            BtnOda201.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda201.Location = new Point(19, 142);
            BtnOda201.Name = "BtnOda201";
            BtnOda201.Size = new Size(106, 58);
            BtnOda201.TabIndex = 3;
            BtnOda201.Text = "201";
            BtnOda201.UseVisualStyleBackColor = false;
            BtnOda201.Click += BtnOda201_Click;
            // 
            // BtnOda103
            // 
            BtnOda103.BackColor = Color.GreenYellow;
            BtnOda103.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda103.Location = new Point(277, 47);
            BtnOda103.Name = "BtnOda103";
            BtnOda103.Size = new Size(106, 58);
            BtnOda103.TabIndex = 2;
            BtnOda103.Text = "103";
            BtnOda103.UseVisualStyleBackColor = false;
            BtnOda103.Click += BtnOda103_Click;
            // 
            // BtnOda102
            // 
            BtnOda102.BackColor = Color.GreenYellow;
            BtnOda102.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda102.Location = new Point(149, 47);
            BtnOda102.Name = "BtnOda102";
            BtnOda102.Size = new Size(106, 58);
            BtnOda102.TabIndex = 1;
            BtnOda102.Text = "102";
            BtnOda102.UseVisualStyleBackColor = false;
            BtnOda102.Click += BtnOda102_Click;
            // 
            // BtnOda101
            // 
            BtnOda101.BackColor = Color.GreenYellow;
            BtnOda101.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnOda101.Location = new Point(19, 47);
            BtnOda101.Name = "BtnOda101";
            BtnOda101.Size = new Size(106, 58);
            BtnOda101.TabIndex = 0;
            BtnOda101.Text = "101";
            BtnOda101.UseVisualStyleBackColor = false;
            BtnOda101.Click += BtnOda101_Click;
            // 
            // BtnBosOda
            // 
            BtnBosOda.BackColor = Color.GreenYellow;
            BtnBosOda.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnBosOda.Location = new Point(795, 583);
            BtnBosOda.Name = "BtnBosOda";
            BtnBosOda.Size = new Size(106, 58);
            BtnBosOda.TabIndex = 13;
            BtnBosOda.Text = "BOŞ";
            BtnBosOda.UseVisualStyleBackColor = false;
            BtnBosOda.Click += button18_Click;
            // 
            // BtnDoluOda
            // 
            BtnDoluOda.BackColor = Color.Red;
            BtnDoluOda.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnDoluOda.Location = new Point(665, 583);
            BtnDoluOda.Name = "BtnDoluOda";
            BtnDoluOda.Size = new Size(106, 58);
            BtnDoluOda.TabIndex = 12;
            BtnDoluOda.Text = "DOLU";
            BtnDoluOda.UseVisualStyleBackColor = false;
            BtnDoluOda.Click += BtnDoluOda_Click;
            // 
            // BtnMusteriCikis
            // 
            BtnMusteriCikis.BackColor = Color.FromArgb(255, 128, 128);
            BtnMusteriCikis.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            BtnMusteriCikis.Location = new Point(288, 583);
            BtnMusteriCikis.Name = "BtnMusteriCikis";
            BtnMusteriCikis.Size = new Size(106, 58);
            BtnMusteriCikis.TabIndex = 14;
            BtnMusteriCikis.Text = "Çıkış";
            BtnMusteriCikis.UseVisualStyleBackColor = false;
            BtnMusteriCikis.Click += BtnMusteriCikis_Click;
            // 
            // FrmYeniMüşteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(1009, 667);
            Controls.Add(BtnMusteriCikis);
            Controls.Add(BtnBosOda);
            Controls.Add(BtnDoluOda);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmYeniMüşteri";
            Text = "Yeni Müşteri Ekle";
            Load += FrmYeniMüşteri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnKaydet;
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
        private GroupBox groupBox2;
        private Button BtnOda403;
        private Button BtnOda402;
        private Button BtnOda401;
        private Button BtnOda303;
        private Button BtnOda302;
        private Button BtnOda301;
        private Button BtnOda203;
        private Button BtnOda202;
        private Button BtnOda201;
        private Button BtnOda103;
        private Button BtnOda102;
        private Button BtnOda101;
        private Button BtnOda503;
        private Button BtnOda502;
        private Button BtnOda501;
        private Button BtnBosOda;
        private Button BtnDoluOda;
        private TextBox textUcret;
        private Label label9;
        private ComboBox CbxCinsiyet;
        private Label label10;
        private Label label11;
        private Button BtnMusteriCikis;
    }
}