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
    public partial class CarbonDuzenleme : Form
    {
        Mesajlar mesaj = new Mesajlar();
        public CarbonDuzenleme()
        {
            InitializeComponent();
        }
        //Veritabanı Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımSinamOdev;Integrated Security=True");
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coinDegerGetirme()
        {

            connection.Open();

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Carbon where id=1", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kucukSiseLbl.Text = dr["Carbon"].ToString() + " C";
            }
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Select * from Tbl_Carbon where id=2", connection);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                demirCLbl.Text = dr1["Carbon"].ToString() + " C";

            }
            dr1.Close();
            SqlCommand cmd2 = new SqlCommand("Select * from Tbl_Carbon where id=3", connection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                kolaCLbl.Text = dr2["Carbon"].ToString() + " C";

            }
            dr2.Close();
            SqlCommand cmd3 = new SqlCommand("Select * from Tbl_Carbon where id=4", connection);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                kagitLbl.Text = dr3["Carbon"].ToString() + " C";

            }
            dr3.Close();
            SqlCommand cmd4 = new SqlCommand("Select * from Tbl_Carbon where id=5", connection);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                bakirLbl.Text = dr4["Carbon"].ToString() + " C";

            }
            dr4.Close();
            SqlCommand cmd5 = new SqlCommand("Select * from Tbl_Carbon where id=6", connection);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                camClbl.Text = dr5["Carbon"].ToString() + " C";

            }
            dr5.Close();
            SqlCommand cmd6 = new SqlCommand("Select * from Tbl_Carbon where id=7", connection);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                buyukSiseClbl.Text = dr6["Carbon"].ToString() + " C";

            }
            dr6.Close();
            SqlCommand cmd7 = new SqlCommand("Select * from Tbl_Carbon where id=8", connection);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                posetCLbl.Text = dr7["Carbon"].ToString() + " C";

            }
            dr7.Close();
            connection.Close();


        }

        private void demirTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void demirBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(demirTxt, demirCLbl, idBulucu("Demir"));
        }

        private void buyukSiseBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(buyukSiseTxt, buyukSiseClbl, idBulucu("BuyukSise"));
            buyukSiseTxt.Text = "";
        }

        private void bakirBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(bakirTxt, bakirLbl, idBulucu("Bakir"));
            bakirTxt.Text = "";
        }
        private void kagitBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(kagitTxt, kagitLbl, idBulucu("Kagit"));
            kagitTxt.Text = "";
        }
        private void camBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(camTxt, camClbl, idBulucu("Cam"));
            camTxt.Text = "";
        }
        private void posetBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(posetTxt, posetCLbl, idBulucu("Poset"));
            posetTxt.Text = "";
        }
        private void kolaBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(kolaTxt, kolaCLbl, idBulucu("TenekeKutu"));
            kolaTxt.Text = "";
        }
        private void kucukSiseBtn_Click(object sender, EventArgs e)
        {
            coinGuncelleme(kucukSiseTxt, kucukSiseLbl, idBulucu("KucukSise"));
            kucukSiseTxt.Text = "";
        }
        private string geriDonusumCesidiniBulma(int id)
        {
            string geriDonusum = "Hata";

            connection.Open();

            //coin değerini gosterme
            SqlCommand cmd = new SqlCommand("Select GeriDonusumTurleri from Tbl_Carbon where id=@deger ", connection);
            cmd.Parameters.AddWithValue("@deger", id);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                geriDonusum = dr["GeriDonusumTurleri"].ToString();
                connection.Close();
                return geriDonusum;
            }
            else
            {
                mesaj.HataMesaji(); connection.Close();
                connection.Close();
                return geriDonusum;
            }

        }
        private void coinGuncelleme(TextBox txt, Label lbl, int id)
        {

            connection.Open();
            int.TryParse(txt.Text, out int geriDonusum);
            if (geriDonusum != 0 && geriDonusum >= 0)
            {

                SqlCommand cmd = new SqlCommand("Update Tbl_Carbon set Carbon = @p2 where id=@p1", connection);
                cmd.Parameters.AddWithValue("@p1", id);
                cmd.Parameters.AddWithValue("@p2", txt.Text);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("Select Carbon from Tbl_Carbon  where id=@p1", connection);
                cmd1.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    lbl.Text = dr["Carbon"].ToString() + " C";
                }


            }
            connection.Close();
        }
        private int idBulucu(string ad)
        {
            connection.Open();
            int idDeger = 9;
            //coin değerini gosterme
            SqlCommand cmd = new SqlCommand("Select id from Tbl_Carbon where GeriDonusumTurleri=@deger ", connection);
            cmd.Parameters.AddWithValue("@deger", ad);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idDeger = (int)dr["id"];
                connection.Close();
                return idDeger;
            }
            else
            {
                mesaj.HataMesaji();
            }
            connection.Close();

            return idDeger;


        }


        private void CarbonDuzenleme_Load(object sender, EventArgs e)
        {
            coinDegerGetirme();
        }


    }
}
