using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikGyak
{
    internal class szinezoGomb : Button    
    {
        public szinezoGomb()
        {
            Width = 20;
            Height = 20;
            Click += szinezoGomb_Click;
        }

        private void szinezoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }
    }
}
