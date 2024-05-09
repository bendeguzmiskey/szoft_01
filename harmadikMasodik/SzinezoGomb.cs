using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace harmadikMasodik
{
    internal class SzinezoGomb : Button
    {
        public SzinezoGomb()
        {
            Width = 30;
            Height = 30;
            Click += SzinezoGomb_Click;
        }

        private void SzinezoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
