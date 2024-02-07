namespace Lebit_Otel_Uygulaması
{
    partial class FrmAnaForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textMusteriler = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button1.Location = new Point(119, 92);
            button1.Name = "button1";
            button1.Size = new Size(151, 87);
            button1.TabIndex = 0;
            button1.Text = "Admin Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button2.Location = new Point(433, 92);
            button2.Name = "button2";
            button2.Size = new Size(151, 87);
            button2.TabIndex = 1;
            button2.Text = "Yeni Müşteri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button3.Location = new Point(747, 92);
            button3.Name = "button3";
            button3.Size = new Size(151, 87);
            button3.TabIndex = 2;
            button3.Text = "Odalar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textMusteriler
            // 
            textMusteriler.BackColor = Color.FromArgb(255, 128, 0);
            textMusteriler.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textMusteriler.Location = new Point(119, 264);
            textMusteriler.Name = "textMusteriler";
            textMusteriler.Size = new Size(151, 87);
            textMusteriler.TabIndex = 3;
            textMusteriler.Text = "Müşteriler";
            textMusteriler.UseVisualStyleBackColor = false;
            textMusteriler.Click += textMusteriler_Click;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(1016, 564);
            Controls.Add(textMusteriler);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmAnaForm";
            Text = "Ana Sayfa";
            Load += FrmAnaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button textMusteriler;
    }
}