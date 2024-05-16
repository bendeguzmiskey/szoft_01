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
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            FillData();
            listBox1.DisplayMember = "Name";
        }

        private void FillData()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor instructor = (Instructor)listBox1.SelectedItem;
            var lessons = from i in context.Lessons
                          where i.InstructorFk == instructor.InstructorSk
                          select new
                          {
                              Nap = i.DayFkNavigation.Name,
                              Sav = i.TimeFkNavigation.Name,
                              Kurzus = i.CourseFkNavigation.Name
                          };
            dataGridView1 .DataSource = lessons.ToList();
        }
    }
}
