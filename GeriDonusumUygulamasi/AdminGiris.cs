using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GeriDonusumUygulamasi
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        //Veritabanı Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımSinamOdev;Integrated Security=True");

        private void grs_Btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", connection);
            komut.Parameters.AddWithValue("@p1", kullaniciAdTxt.Text);
            komut.Parameters.AddWithValue("@p2", sifretxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Admin ad = new Admin();
                ad.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız..","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
            giris.Close();
        }
    }
}
