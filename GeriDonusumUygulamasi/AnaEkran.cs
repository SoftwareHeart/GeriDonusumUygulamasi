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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();

        }

        //Veritabanı Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımSinamOdev;Integrated Security=True");

        String kod;
        Mesajlar mesajlar = new Mesajlar();





        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ParaGonderme para = new ParaGonderme();
            para.paraKodLbl.Text = kodLbl.Text;
            para.paraLbl.Text = coinLbl.Text;

            para.Show();


        }
        private double geriDonusumDegerleriAdetHesaplama()
        {
            GeriDonusumTipleri geri = new GeriDonusumTipleri();
            int.TryParse(yarimLitreSise.SelectedIndex.ToString(), out int yarimLitresayi);
            geri.Plastik1 = ++yarimLitresayi;

            int.TryParse(buyukSiseAdet.SelectedIndex.ToString(), out int buyukSiseSayi);
            geri.Plastik1 = ++buyukSiseSayi;

            int.TryParse(posetAdet.SelectedIndex.ToString(), out int posetSayi);
            geri.Plastik1 = ++posetSayi;

            int.TryParse(demirAdet.SelectedIndex.ToString(), out int demirSayi);
            geri.Demir1 = ++demirSayi;

            int.TryParse(bakirAdet.SelectedIndex.ToString(), out int bakirSayi);
            geri.Bakir1 = ++bakirSayi;

            int.TryParse(camAdet.SelectedIndex.ToString(), out int camSayi);
            geri.Cam1 = ++camSayi;

            int.TryParse(kolaAdet.SelectedIndex.ToString(), out int kolaSayi);
            geri.Aleminum1 = ++kolaSayi;

            int.TryParse(KagitAdet.SelectedIndex.ToString(), out int kagitSayi);
            geri.Kagit1 = ++kagitSayi;
            double coin = coinHesapla(yarimLitresayi, buyukSiseSayi, posetSayi, geri.Demir1, geri.Bakir1, geri.Cam1, geri.Aleminum1, geri.Kagit1);
            return coin;
        }
       
        private void gndButton_Click(object sender, EventArgs e)
        {


            GeriDonusumTipleri geri = new GeriDonusumTipleri();


            double coin = geriDonusumDegerleriAdetHesaplama();
            //coin alma

            kod = kodLbl.Text;
            connection.Open();


            SqlCommand komut = new SqlCommand("Update Tbl_Kullanicilar set Plastik += @p1 ,Cam += @p2 ,Aleminum += @p3 ,Kagit+=@p4 ,Bakir+=@p5 ,Demir+=@p6, Coin+=@p8 where Kod = @p7", connection);
            komut.Parameters.AddWithValue("@p7", kod);
            komut.Parameters.AddWithValue("@p1", geri.Plastik1);
            komut.Parameters.AddWithValue("@p2", geri.Cam1);
            komut.Parameters.AddWithValue("@p3", geri.Aleminum1);
            komut.Parameters.AddWithValue("@p4", geri.Kagit1);
            komut.Parameters.AddWithValue("@p5", geri.Bakir1);
            komut.Parameters.AddWithValue("@p6", geri.Demir1);
            komut.Parameters.AddWithValue("@p8", coin);
            komut.ExecuteNonQuery();
            connection.Close();
            comboboxIlk();
            coinGosterme();

            MessageBox.Show("İşleminiz başarılı ile gerçekleşti :))", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void comboboxIlk()
        {
            //combobox ilk elemanın seçili gelmesi
            demirAdet.SelectedIndex = -1;
            yarimLitreSise.SelectedIndex = -1;
            buyukSiseAdet.SelectedIndex = -1;
            bakirAdet.SelectedIndex = -1;
            posetAdet.SelectedIndex = -1;
            camAdet.SelectedIndex = -1;
            kolaAdet.SelectedIndex = -1;
            KagitAdet.SelectedIndex = -1;
        }
        private double coinHesapla(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            int a1 = Convert.ToInt32(kucukSiseLbl.Text);
            int b1 = Convert.ToInt32(buyukSiseClbl.Text);
            int c1 = Convert.ToInt32(posetCLbl.Text);
            int d1 = Convert.ToInt32(demirCLbl.Text);
            int e1 = Convert.ToInt32(bakirLbl.Text);
            int f1 = Convert.ToInt32(camClbl.Text);
            int g1 = Convert.ToInt32(kolaCLbl.Text);
            int h1 = Convert.ToInt32(kagitLbl.Text);

            double result = (double)((a * a1) + (b * b1) + (c * c1) + (d * d1) + (e * e1) + (f * f1) + (g * g1) + (h * h1)) / 100000000;
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
            this.Hide();
        }


        private void coinGosterme()
        {
            connection.Open();
            //coin değerini gosterme
            SqlCommand cmd = new SqlCommand("Select Coin from Tbl_Kullanicilar where Kod=@deger ", connection);
            cmd.Parameters.AddWithValue("@deger", kodLbl.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                coinLbl.Text = dr["Coin"].ToString();
            }
            dr.Close();
            connection.Close();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            coinGosterme();
            coinDegerGetirme();
        }
        private void coinDegerGetirme()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Carbon where id=1", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kucukSiseLbl.Text = dr["Carbon"].ToString();
            }
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Select * from Tbl_Carbon where id=2", connection);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if(dr1.Read())
            {
                demirCLbl.Text = dr1["Carbon"].ToString() ;

            }
            dr1.Close();
            SqlCommand cmd2 = new SqlCommand("Select * from Tbl_Carbon where id=3", connection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
           if(dr2.Read())
            {
                kolaCLbl.Text = dr2["Carbon"].ToString();

            }
            dr2.Close();
            SqlCommand cmd3 = new SqlCommand("Select * from Tbl_Carbon where id=4", connection);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if(dr3.Read())
            {
                kagitLbl.Text = dr3["Carbon"].ToString();

            }
            dr3.Close();
            SqlCommand cmd4 = new SqlCommand("Select * from Tbl_Carbon where id=5", connection);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                bakirLbl.Text = dr4["Carbon"].ToString();

            }
            dr4.Close();
            SqlCommand cmd5 = new SqlCommand("Select * from Tbl_Carbon where id=6", connection);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                camClbl.Text = dr5["Carbon"].ToString() ;

            }
            dr5.Close();
            SqlCommand cmd6 = new SqlCommand("Select * from Tbl_Carbon where id=7", connection);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                buyukSiseClbl.Text = dr6["Carbon"].ToString() ;

            }
            dr6.Close();
            SqlCommand cmd7 = new SqlCommand("Select * from Tbl_Carbon where id=8", connection);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                posetCLbl.Text = dr7["Carbon"].ToString() ;

            }
            dr7.Close();
            connection.Close();
        }


    }
}
