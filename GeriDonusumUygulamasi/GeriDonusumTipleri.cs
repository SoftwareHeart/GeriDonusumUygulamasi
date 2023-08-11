using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GeriDonusumUygulamasi
{
    public class GeriDonusumTipleri
    {

        private static int Cam;
        private static int Plastik;
        private static int Aleminum;
        private static int Kagit;
        private static int Bakir;
        private static int Demir;

        public int Cam1 { get => Cam; set => Cam = value; }
        public int Plastik1 { get => Plastik; set => Plastik = value; }
        public int Aleminum1 { get => Aleminum; set => Aleminum = value; }
        public int Kagit1 { get => Kagit; set => Kagit = value; }
        public int Bakir1 { get => Bakir; set => Bakir = value; }
        public int Demir1 { get => Demir; set => Demir = value; }


        


    }
}
