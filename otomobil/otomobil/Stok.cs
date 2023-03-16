using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace otomobil
{
    public partial class Stok : Form
    {
        static string baglantiyolu=@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(baglantiyolu);
        public Stok()
        {
            InitializeComponent();
        }

        private void STK_MKYJ_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM STOK_MAKYAJ  ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.DataSource = dt;
            baglanti.Close();
        }

        private void STK_KPRT_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM STOK_KAPORTA  ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.DataSource = dt;
            baglanti.Close();
        }

        private void STK_MTR_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM STOK_MOTOR  ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.DataSource = dt;
            baglanti.Close();
        }

     
    
    }

}
