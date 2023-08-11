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
//kod1 null çöz
namespace GeriDonusumUygulamasi
{
    public partial class GirisEkrani : Form
    {
        //Veritabanı Bağlantısı
       
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımSinamOdev;Integrated Security=True");
        public String kod = "";
        Mesajlar mesajlar = new Mesajlar();
        
        int j = 0;
        //private String kod1 = "";
       
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void kodAlBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Bir seferde bir kod oluşturmak
                if (j == 0)
                {


                    kodOlustur();

                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into Tbl_Kullanicilar (Kod) values (@p1)", connection);
                    command.Parameters.AddWithValue("@p1", kod);

                    command.ExecuteNonQuery();
                    connection.Close();


                }
                else
                {
                    MessageBox.Show("Bir seferde sadece bir kod oluştutabilirsiniz!!" + "\n Kodunuz : " + kod, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                mesajlar.HataMesaji();
            }
           

        }
        private void kodOlustur()
        {
            //SHA-256 kodunu oluşturma
            try
            {
                Random rastgele = new Random();
                
                for (int i = 1; i <= 6; i++)
                {
                    int sayi1 = rastgele.Next(65, 91);
                    //65 dahil, 91 dahil değil A ile Z arasında
                    kod += Convert.ToString((char)sayi1);
                    
                }
                MessageBox.Show("SHA-256 Kodunuz: " + kod+"\nLütfen Not ediniz!!!", "SHA-256 Kodu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                j++;
              

            }
            catch (Exception)
            {
             
                
            };

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kodTxt.Text = kodTxt.Text.ToUpper();
            kodTxt.SelectionStart = kodTxt.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (kodTxt.Text != "")
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Tbl_Kullanicilar where Kod = @p1", connection);
                    cmd.Parameters.AddWithValue("@p1", kodTxt.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        AnaEkran ekran = new AnaEkran();

                        ekran.kodLbl.Text = kodTxt.Text;
                        ekran.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı!!", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen kodunuzu giriniz!!", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();

            }
            catch
            {
                mesajlar.HataMesaji();
            }




        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            this.Text = "Giriş Ekranı";
           
            
        }

        private void txt_sadece_harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harf girişi

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiris giris = new AdminGiris();
            giris.Show();
            this.Hide();
        }
    }
   
}
