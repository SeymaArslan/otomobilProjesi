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
    public partial class Menu : Form
    {
        
        static string baglantiyolu = @"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(baglantiyolu);
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yEDEKPARCADataSet.MAKYAJ' table. You can move, or remove it, as needed.
            //this.mAKYAJTableAdapter.Fill(this.yEDEKPARCADataSet.MAKYAJ);

            //comboBox1.Items.Add("Makyaj Bölümü");
            //comboBox1.Items.Add("Kaporta Bölümü");
            //comboBox1.Items.Add("Motor Bölümü");


            comboBox1.DisplayMember = "Menu";
            comboBox1.ValueMember = "Cat_ID";
            DataSet kategori = YedekParcaMenu();
            comboBox1.DataSource = kategori.Tables[0];

        }
        public DataSet YedekParcaMenu()   //veritabanına baglanıp combobaxa alanları çekme
        {
           
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM KATEGORI";

            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;

            DataSet kategori = new DataSet();
            baglanti.Open();
            adaptor.Fill(kategori);
            baglanti.Close();

            return kategori;


        }
        public void MakyajTablosu() // veritabanına bağlanıp combobaxtaki verileri gride çekelim.
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM MAKYAJ ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void MotorTablosu() // veritabanına bağlanıp combobaxtaki verileri gride çekelim.
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM MOTOR ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void KaportaTablosu() // veritabanına bağlanıp combobaxtaki verileri gride çekelim.
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM KAPORTA ";

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

       

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(comboBox1.SelectedItem=="Makyaj Bölümü");
            {
                MakyajTablosu();
            }
            if(comboBox1.SelectedText=="Motor Bölümü")
            {
                MotorTablosu();
            }
            if (comboBox1.SelectedText == "Kaporta Bölümü")
            {
                KaportaTablosu();
            }

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void stk_grntl_Click(object sender, EventArgs e)
        {
            Stok stk = new Stok();
            stk.Hide();
            stk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura ftr = new Fatura();   
            ftr.Hide();
            ftr.Show();
            this.Visible = false;   //o anki sayfamızı kapatır
           
        }

       

     
    }
}
