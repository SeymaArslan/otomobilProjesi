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
    public partial class Anasayfa : System.Web.UI.Page
    {
        static string baglantiyolu = ConfigurationManager.AppSettings["baglantiYolu"];
        protected void Page_Load(object sender, EventArgs e)
        {
              
        }
      
        public void MakyajTablosu() // veritabanına bağlanıp combobaxtaki verileri gride çekelim.
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM MAKYAJ ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }
        public void MotorTablosu() // veritabanına bağlanıp combobaxtaki verileri gride çekelim.
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM MOTOR ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }
        public void KaportaTablosu() // veritabanına bağlanıp combobaxtaki verileri gride çekelim.
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM KAPORTA ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DropDownList1.SelectedItem.Text == "Makyaj Bölümü")
            {
                MakyajTablosu();

            }

            if (DropDownList1.SelectedItem.Text == "Kaporta Bölümü")
            {
                KaportaTablosu();

            }


            if (DropDownList1.SelectedItem.Text == "Motor Bölümü")
            {
                MotorTablosu();

            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
      
                 
                ListBox1.Items.Add(GridView1.SelectedRow.Cells.ToString());
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            {
                ListBox1.Items.Remove(ListBox1.SelectedItem);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fatura.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stok.aspx");
        }

      
       
    }
}