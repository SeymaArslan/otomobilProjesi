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
    public partial class Odeme : Form
    {

        static string baglantiyolu = @"Data Source=TOSHIBA;Initial Catalog=YEDEKPARCA;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(baglantiyolu);
        public Odeme()
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
                string kayit = "INSERT INTO KREDI_ODEME(Ad,Soyad,KrediKartiNo,Cvc) VALUES (@ad,@soyad,@kredikarti,@cvc)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@kredikarti", textBox3.Text);
                komut.Parameters.AddWithValue("@cvc", textBox4.Text);

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Ödeme İşlemi Başarıyla Gerçekleşti.");
                ONERI onr = new ONERI();
                onr.Hide();
                onr.Show();
                this.Visible = false;

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "INSERT INTO VISA_ODEME(Ad,Soyad,HesapNo) VALUES (@ad,@soyad,@hesapno)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@ad", textBox5.Text);
                komut.Parameters.AddWithValue("@soyad", textBox6.Text);
                komut.Parameters.AddWithValue("@hesapno", textBox7.Text);
              

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Ödeme İşlemi başarıyla Gerçekleşti.");
                ONERI onr = new ONERI();
                onr.Hide();
                onr.Show();
                this.Visible = false;

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "INSERT INTO PAYPAL_ODEME(Paypal_Hesabi) VALUES (@paypal)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@paypal", textBox8.Text);
                


                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Ödeme İşlemi başarıyla Gerçekleşti.");
                ONERI onr = new ONERI();
                onr.Hide();
                onr.Show();
                this.Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}
