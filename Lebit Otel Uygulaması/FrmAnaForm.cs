using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebit_Otel_Uygulaması
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar Fr = new FrmOdalar();
            Fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris Fr = new FrmAdminGiris();
            Fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMüşteri Fr = new FrmYeniMüşteri();
            Fr.Show();
            this.Hide();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void textMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler Fr = new FrmMusteriler();
            Fr.Show();
            this.Hide();
        }
    }
}
