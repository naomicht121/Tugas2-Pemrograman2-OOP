using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184018
{
    public class Genre : Music
    {
        protected string jenisMusik;

        public Genre(string kategori, string gelar, string jenismusik)
            : base(kategori, gelar)
        {
            this.jenisMusik = jenismusik;
        }

        public string JenisMusik
        {
            get
            {
                return jenisMusik;
            }
            set
            {
                jenisMusik = value;
            }
        }
    }
}
