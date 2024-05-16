using CsvHelper;
using gyak1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak1
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            var oktatok = from i in context.Instructors
                          select new
                          {
                              salut = i.Salutation,
                              nev = i.Name,
                              satus = i.StatusFkNavigation.Name,
                              employ = i.EmployementFkNavigation.Name
                          };
            dataGridView1.DataSource = oktatok.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                var instructors = from l in context.Instructors
                                  select new
                                  {
                                      Salutation = l.Salutation,
                                      Name = l.Name,
                                      Statusz = l.StatusFkNavigation.Name,
                                      employment = l.EmployementFkNavigation.Name
                                  };
                csv.WriteRecords(instructors.ToList());
                sw.Close();
            }
        }
    }
}
