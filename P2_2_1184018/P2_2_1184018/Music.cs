using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184018
{
    public class Music
    {
        private string myKategori;
        private string myGelar;
        public Music()
        {

        }

        public Music(string kategori, string gelar)
        {
            this.myKategori = kategori;
            this.myGelar = gelar;
        }

        public string Mykategori
        {
            get
            {
                return myKategori;
            }

            set
            {
                myKategori = value;
            }
        }
        public string Mygelar
        {
            get
            {
                return myGelar;
            }

            set
            {
                myGelar = value;
            }
        }
    }
}
