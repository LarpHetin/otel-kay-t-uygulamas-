namespace Lebit_Otel_Uygulaması
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textKullanıcıAdı.Text == "admin" && textSifre.Text == "admin")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void BtnCikisYap_Click(object sender, EventArgs e)
        {
            FrmAnaForm Fr = new FrmAnaForm();
            Fr.Show();
            this.Hide();
            
        }
    }
}
