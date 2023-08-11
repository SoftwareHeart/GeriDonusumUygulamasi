using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriDonusumUygulamasi
{
    public class Mesajlar
    {

        public void HataMesaji()
        {
            MessageBox.Show("Bir şeyler yanlış gitti", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
