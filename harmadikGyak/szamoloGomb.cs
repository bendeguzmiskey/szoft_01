using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikGyak
{
    internal class szamoloGomb : Button
    {
        public static int szam = 0;
        public szamoloGomb()
        {
            Height = 20;
            Width = 20;

            Click += szamoloGomb_Click; 
        }

        private void szamoloGomb_Click(object? sender, EventArgs e)
        {
            if (szam == 5)
            {
                szam = 1;
            }
            else {
                szam++;
            }
            Text = szam.ToString();

        }
    }
}
