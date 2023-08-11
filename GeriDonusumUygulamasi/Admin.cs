using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriDonusumUygulamasi
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazılımSinamOdevDataSet.Tbl_Kullanicilar' table. You can move, or remove it, as needed.
            this.tbl_KullanicilarTableAdapter.Fill(this.yazılımSinamOdevDataSet.Tbl_Kullanicilar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarbonDuzenleme carbon = new CarbonDuzenleme();
            carbon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
            this.Close();
        }
    }
}
