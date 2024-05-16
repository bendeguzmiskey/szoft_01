using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_gyakorlas.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zh_gyakorlas
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new();
        public UserControl3()
        {
            InitializeComponent();

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            var instructors = from l in context.Instructors
                          select new
                          {
                              Salut = l.Salutation,
                              Nam = l.Name,
                              Statusz = l.StatusFkNavigation.Name,
                              employment = l.EmployementFkNavigation.Name
                          };
            dataGridView1.DataSource = instructors.ToList();
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
