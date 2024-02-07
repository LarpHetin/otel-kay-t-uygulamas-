using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lebit_Otel_Uygulaması
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void showdata()
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from AddCustomer", bgl.baglanti());
            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = rdr["ID"].ToString();
                add.SubItems.Add(rdr["Adi"].ToString());
                add.SubItems.Add(rdr["Soyadi"].ToString());
                add.SubItems.Add(rdr["Cinsiyet"].ToString());
                add.SubItems.Add(rdr["Telefon"].ToString());
                add.SubItems.Add(rdr["TC"].ToString());
                add.SubItems.Add(rdr["Mail"].ToString());
                add.SubItems.Add(rdr["OdaNo"].ToString());
                add.SubItems.Add(rdr["Ucret"].ToString());
                add.SubItems.Add(rdr["GirisTarihi"].ToString());
                add.SubItems.Add(rdr["CikisTarihi"].ToString());

                listView1.Items.Add(add);
            }
            bgl.baglanti().Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void BtnCikisMusteri_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update AddCustomer set Adi='" + textAdi.Text + "',Soyadi='" + textSoyadi.Text + "',Cinsiyet='" + CbxCinsiyet.Text + "',Telefon='" + MskTelefonNum.Text + "',TC='"+ textKimlik.Text+"',Mail='"+ textMail.Text+ "',OdaNo='"+ textOdaNo.Text+"',Ucret='"+ textUcret.Text+ "',GirisTarihi='"+ DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "'where ID=" + id + "", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            showdata();
        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUcret_TextChanged(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefonNum.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textKimlik.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from AddCustomer where ID=(" + id + ")", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from AddCustomer where Adi like '%"+ textbox1.Text+"%'", bgl.baglanti());
            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = rdr["ID"].ToString();
                add.SubItems.Add(rdr["Adi"].ToString());
                add.SubItems.Add(rdr["Soyadi"].ToString());
                add.SubItems.Add(rdr["Cinsiyet"].ToString());
                add.SubItems.Add(rdr["Telefon"].ToString());
                add.SubItems.Add(rdr["TC"].ToString());
                add.SubItems.Add(rdr["Mail"].ToString());
                add.SubItems.Add(rdr["OdaNo"].ToString());
                add.SubItems.Add(rdr["Ucret"].ToString());
                add.SubItems.Add(rdr["GirisTarihi"].ToString());
                add.SubItems.Add(rdr["CikisTarihi"].ToString());

                listView1.Items.Add(add);
            }
            bgl.baglanti().Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textAdi.Clear();
            textSoyadi.Clear();
            CbxCinsiyet.Text = "";
            MskTelefonNum.Clear();
            textKimlik.Clear();
            textMail.Text = "";
            textOdaNo.Clear();
            textUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            textbox1.Clear();
        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
