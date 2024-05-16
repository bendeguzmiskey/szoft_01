using gyak1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak1
{
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            FillData();
            listBox1.DisplayMember = "Name";
        }
        private void FillData()
        {
            listBox1.DataSource = (from i in context.Courses
                                   where i.Name.StartsWith(textBox1.Text)
                                   select i).ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course course = (Course)listBox1.SelectedItem;
            var lessons = from i in context.Lessons
                          where i.CourseFk == course.CourseSk
                          select new
                          {
                              Kurzus = i.CourseFkNavigation.Name,
                              Ido = i.TimeFkNavigation.Name,
                              Nap = i.DayFkNavigation.Name
                          };
            dataGridView1.DataSource = lessons.ToList();
        }
    }
}
