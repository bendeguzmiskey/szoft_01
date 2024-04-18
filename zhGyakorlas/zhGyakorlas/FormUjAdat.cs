using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhGyakorlas
{
    public partial class FormUjAdat : Form
    {
        public Futok ujFutok;

        public FormUjAdat()
        {
            InitializeComponent();
            ujFutok = new Futok();
            bindingSource1.DataSource = ujFutok;
        }
    }
}
