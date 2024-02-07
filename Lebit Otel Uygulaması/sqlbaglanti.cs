using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lebit_Otel_Uygulaması
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=PC_YAHYALEBIT\\SQLEXPRESS;Initial Catalog=LebitOtel;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
