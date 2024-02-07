namespace Lebit_Otel_Uygulaması
{
    partial class FrmAdminGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            label2 = new Label();
            textKullanıcıAdı = new TextBox();
            textSifre = new TextBox();
            BtnGirişYap = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            BtnCikisYap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(159, 219);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(187, 275);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            label2.Click += label2_Click;
            // 
            // textKullanıcıAdı
            // 
            textKullanıcıAdı.BackColor = Color.FromArgb(255, 255, 192);
            textKullanıcıAdı.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textKullanıcıAdı.Location = new Point(326, 219);
            textKullanıcıAdı.Name = "textKullanıcıAdı";
            textKullanıcıAdı.Size = new Size(220, 34);
            textKullanıcıAdı.TabIndex = 2;
            // 
            // textSifre
            // 
            textSifre.BackColor = Color.FromArgb(255, 255, 192);
            textSifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textSifre.Location = new Point(326, 279);
            textSifre.Name = "textSifre";
            textSifre.Size = new Size(220, 34);
            textSifre.TabIndex = 3;
            textSifre.UseSystemPasswordChar = true;
            // 
            // BtnGirişYap
            // 
            BtnGirişYap.BackColor = Color.FromArgb(128, 255, 128);
            BtnGirişYap.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGirişYap.Location = new Point(425, 356);
            BtnGirişYap.Name = "BtnGirişYap";
            BtnGirişYap.Size = new Size(121, 46);
            BtnGirişYap.TabIndex = 4;
            BtnGirişYap.Text = "Giriş";
            BtnGirişYap.UseVisualStyleBackColor = false;
            BtnGirişYap.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(159, 66);
            label3.Name = "label3";
            label3.Size = new Size(344, 50);
            label3.TabIndex = 6;
            label3.Text = "Lebit Otele Hoşgeldiniz";
            // 
            // BtnCikisYap
            // 
            BtnCikisYap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCikisYap.BackColor = Color.FromArgb(255, 128, 128);
            BtnCikisYap.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCikisYap.Location = new Point(262, 356);
            BtnCikisYap.Name = "BtnCikisYap";
            BtnCikisYap.Size = new Size(121, 46);
            BtnCikisYap.TabIndex = 7;
            BtnCikisYap.Text = "Çıkış";
            BtnCikisYap.UseVisualStyleBackColor = false;
            BtnCikisYap.Click += BtnCikisYap_Click;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(33, 228, 189);
            ClientSize = new Size(778, 471);
            Controls.Add(BtnCikisYap);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(BtnGirişYap);
            Controls.Add(textSifre);
            Controls.Add(textKullanıcıAdı);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textKullanıcıAdı;
        private TextBox textSifre;
        private Button BtnGirişYap;
        private PictureBox pictureBox1;
        private Label label3;
        private Button BtnCikisYap;
    }
}
