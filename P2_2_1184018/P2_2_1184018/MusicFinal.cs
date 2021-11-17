using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184018
{
    class MusicFinal
    {
        static void Main(String[] args)
        {
            Genre play1 = new Genre("Produksi", "R&B, Hip-Hop dan Dance", "SMTOWN");
            Artist play2 = new Artist("EXO, NCT dan lainnya", "R&B, Hip-Hop dan Dance");

            Console.WriteLine("Music {0} dengan Genre {1} sering di produksi oleh {2} atau SM Entertaiment", play1.Mykategori, play1.Mygelar, play1.JenisMusik);

            Console.WriteLine("SMTOWN memiliki {0} seperti {1} yang mamakai genre {2} pada Music mereka", play2.Mykategori, play2.Mygelar, play2.Production);
        }
    }
}
