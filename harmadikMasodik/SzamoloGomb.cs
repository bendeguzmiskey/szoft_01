using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikMasodik
{
    internal class SzamoloGomb : Button
    {
        public int szam = 0;
        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;

            Click += SzamoloGomb_Click;

        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            if (szam < 5)
            {
                szam++;
            }
            else
            {
                szam = 0;
            }
            Text = szam.ToString();
        }
    }
}
