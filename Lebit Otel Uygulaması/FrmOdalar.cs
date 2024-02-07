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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnOdalarCikis_Click(object sender, EventArgs e)
        {
            FrmAnaForm Fr = new FrmAnaForm();
            Fr.Show();
            this.Hide();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {

        }
    }
}
