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
    public partial class Form1 : Form
    {
        public string baglantiyolu = @"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string kullaniciadi = "samet";
            //string kullanicisifre = "1234";

            //string girilen_kullanici = textBox1.Text;
            //string girilen_sifre = textBox2.Text;

            //if (girilen_kullanici == kullaniciadi || girilen_sifre == kullanicisifre)
            //{
            //    Menu frm = new Menu();
            //    frm.Hide();
            //    frm.Show();

            //}
            //else
            //    MessageBox.Show("Kullanıcı adı hatalı girildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "SELECT  * FROM MUSTERILER WHERE m_adi=@pm_adi AND m_sifre=@pm_sifre";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pm_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@pm_sifre", textBox2.Text);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                Menu frm = new Menu();
                frm.Hide();
                frm.Show();
                this.Visible = false;
                baglanti.Close();
            }
            else
                MessageBox.Show("Kullanıcı adı hatalı girildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Hide();
            kyt.Show();

        }


    }
}
