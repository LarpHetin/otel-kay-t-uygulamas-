using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Lebit_Otel_Uygulaması
{
    public partial class FrmYeniMüşteri : Form
    {
        public FrmYeniMüşteri()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "103";
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "201";
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "202";
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "203";
        }

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "301";
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "302";
        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "303";
        }

        private void BtnOda401_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "401";
        }

        private void BtnOda402_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "402";
        }

        private void BtnOda403_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "403";
        }

        private void BtnOda501_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "501";
        }

        private void BtnOda502_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "502";
        }

        private void BtnOda503_Click(object sender, EventArgs e)
        {
            textOdaNo.Text = "503";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 150;
            textUcret.Text = Ucret.ToString();
        }

        private void BtnMusteriCikis_Click(object sender, EventArgs e)
        {
            FrmAnaForm Fr = new FrmAnaForm();
            Fr.Show();
            this.Hide();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into AddCustomer (Adi,Soyadi,Cinsiyet,Telefon,TC,Mail,OdaNo,Ucret,GirisTarihi,CikisTarihi)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAdi.Text);
            komut.Parameters.AddWithValue("@p2", textSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", CbxCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefonNum.Text);
            komut.Parameters.AddWithValue("@p5", textKimlik.Text);
            komut.Parameters.AddWithValue("@p6", textMail.Text);
            komut.Parameters.AddWithValue("@p7", textOdaNo.Text);
            komut.Parameters.AddWithValue("@p8", textUcret.Text);
            komut.Parameters.AddWithValue("@p9", DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@p10", DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
          
        }

        private void FrmYeniMüşteri_Load(object sender, EventArgs e)
        {

        }
    }
}