using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace otomobilweb
{
    public partial class Stok : System.Web.UI.Page
    {
        static string baglantiyolu = ConfigurationManager.AppSettings["baglantiYolu"];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }

        protected void mkyj_stk_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM STOK_MAKYAJ ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }

        protected void mtr_stk_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM STOK_MOTOR ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }

        protected void kprt_stk_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM STOK_KAPORTA ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }
    }
}