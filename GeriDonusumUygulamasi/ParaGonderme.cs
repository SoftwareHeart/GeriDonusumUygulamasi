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
    public partial class ParaGonderme : Form
    {
        Mesajlar mesajlar = new Mesajlar();
        //Veritabanı Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımSinamOdev;Integrated Security=True");
        public ParaGonderme()
        {
            InitializeComponent();
            paraKodLbl.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadeceHarf girişi
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı girişi
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            try
            {
                //kullanıcıdan girdiği coin değerlerini alma;
                decimal.TryParse(ilkTutarTxt.Text, out decimal ilkTutar);
                decimal.TryParse(virguldenSonraTutarTxt.Text, out decimal virguldenSonraTutar);
                for (int i = 1; i <= virguldenSonraTutarTxt.Text.Length; i++)
                {
                    virguldenSonraTutar = virguldenSonraTutar / 10;
                }

                ilkTutar += virguldenSonraTutar;

                decimal coinGonderici;

                coinGonderici = Convert.ToDecimal(paraLbl.Text);
                if (paraKodLbl.Text == gkodTxt.Text)
                {
                    MessageBox.Show("Kendinize coin gönderemezsiniz :))", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    connection.Open();
                    //girilen kodu incelemek
                    SqlCommand cmd = new SqlCommand("Select Coin from Tbl_Kullanicilar where Kod=@p1", connection);
                    cmd.Parameters.AddWithValue("@p1", gkodTxt.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        if (ilkTutar <= coinGonderici)
                        {
                            coinGonderici = coinGonderici - ilkTutar;
                            SqlCommand komut = new SqlCommand("Update Tbl_Kullanicilar set Coin+=@p1 where Kod = @p2", connection);
                            komut.Parameters.AddWithValue("@p2", gkodTxt.Text);
                            komut.Parameters.AddWithValue("@p1", ilkTutar);
                            komut.ExecuteNonQuery();
                            //Kullanıcının coin değerini atama;
                            SqlCommand komut1 = new SqlCommand("Update Tbl_Kullanicilar set Coin -=@p1 where kod=@p2", connection);
                            komut1.Parameters.AddWithValue("@p2", paraKodLbl.Text);
                            komut1.Parameters.AddWithValue("@p1", ilkTutar);
                            komut1.ExecuteNonQuery();
                            SqlCommand sql = new SqlCommand("Select Coin from Tbl_Kullanicilar where kod=@p1", connection);
                            sql.Parameters.AddWithValue("@p1", paraKodLbl.Text);
                            SqlDataReader dataReader = sql.ExecuteReader();
                            if (dataReader.Read())
                            {
                                paraLbl.Text = dataReader["Coin"].ToString();
                                dataReader.Close();
                            }

                            MessageBox.Show("İşlem başarı ile gerçekleşti..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else
                        {
                            MessageBox.Show("Yetersiz coin!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı!!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    connection.Close();
                }
            }catch(Exception ex)
            {
                mesajlar.HataMesaji();
                Console.WriteLine(ex);
            }
            
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gkodTxt_TextChanged(object sender, EventArgs e)
        {
            
                gkodTxt.Text = gkodTxt.Text.ToUpper();
                gkodTxt.SelectionStart = gkodTxt.Text.Length;
            
        }
    }
}
