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
    public partial class Kayit : System.Web.UI.Page
    {
        static string baglantiyolu = ConfigurationManager.AppSettings["baglantiYolu"];
        SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "INSERT INTO MUSTERILER(m_adi,m_sifre) VALUES (@adi,@sifre)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@adi", TextBox1.Text);
                komut.Parameters.AddWithValue("@sifre", TextBox2.Text);

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                Response.Redirect("Login.aspx");
            }
            catch (Exception hata)
            {
                Label3.Text = "İşlem Sırasında hata oluştu";
            }
        }
    }
}