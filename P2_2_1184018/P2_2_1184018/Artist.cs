using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184018
{
    public class Artist : Music
    {
        protected string production;
        public Artist(string gelar, string production)
        {
            this.Mygelar = gelar;
            this.Production = production;
            this.Mykategori = "Artist";

            //Console.WriteLine("Ini adalah class Artist");
        }

        public string Production
        {
            get
            {
                return production;
            }
            set
            {
                production = value;
            }
        }
    }
}
