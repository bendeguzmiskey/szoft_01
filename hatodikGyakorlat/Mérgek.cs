using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatodikGyakorlat
{
    internal class Mérgek : PictureBox
    {
        public static int Méret = 20;

        public Mérgek()
        {
            Width = Mérgek.Méret;
            Height = Mérgek.Méret;
            BackColor = Color.Green;
        }
    }
}
