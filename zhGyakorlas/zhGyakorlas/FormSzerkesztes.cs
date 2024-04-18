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
    public partial class FormSzerkesztes : Form
    {
        public Futok futok;
        public FormSzerkesztes()
        {
            InitializeComponent();
        }

        private void FormSzerkesztes_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = futok;
        }
    }
}
