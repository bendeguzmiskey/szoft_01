using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Elem
    {
            public int Sorszám { get; set; }
            public long Érték { get; set; }

        public Elem(int tsorszam, long Érték)
        {
            Sorszám = tsorszam;
            this.Érték = Érték;
        }


    }

}
