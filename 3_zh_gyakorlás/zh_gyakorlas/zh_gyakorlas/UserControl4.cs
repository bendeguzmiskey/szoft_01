using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_gyakorlas.Models;

namespace zh_gyakorlas
{
    public partial class UserControl4 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl4()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Courses.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Course course = new Course();
                course.Name = form2.textBox1.Text;
                course.Code = form2.textBox2.Text;

                context.Courses.Add(course);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.Message);
                }
            }
            dataGridView1.DataSource = context.Courses.ToList();
              
        }
    }
}
