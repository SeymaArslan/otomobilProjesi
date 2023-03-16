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
    
    public partial class Login : System.Web.UI.Page
    {
        static string baglantiYolu = ConfigurationManager.AppSettings["baglantiYolu"];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            string ad = TextBox1.Text;
            string sifre = TextBox2.Text;

            SqlCommand komut = new SqlCommand("SELECT * FROM MUSTERILER WHERE m_adi='"+ ad + "'and m_sifre='"+sifre+"'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Session.Add("kullanıcı", ad);
                Response.Redirect("Anasayfa.aspx");
            }
            else
                Label4.Visible = true;
                Label4.Text = "Giriş Başarısız";

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kayit.aspx");
        }
    }
}