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
    public partial class Adres : Form
    {
        static string baglantiyolu = @"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(baglantiyolu);
        public Adres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "INSERT INTO ADRESLER(Mahalle,il_ilce,Sehir,Posta) VALUES (@mahalle,@ililce,@sehir,@posta)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@mahalle", textBox1.Text);
                komut.Parameters.AddWithValue("@ililce", textBox2.Text);
                komut.Parameters.AddWithValue("@sehir", textBox3.Text);
                komut.Parameters.AddWithValue("@posta", textBox4.Text);

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Adres Kayıt İşlemi Gerçekleşti.");
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odeme odm = new Odeme();
            odm.Hide();
            odm.Show();
            this.Visible = false;
        }
    }
}
