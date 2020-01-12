using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Form5 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Course> courses = new List<Course>();
        List<Lab> labbar =new List<Lab>();
       public void SetAll(List<Student> s, List<Teacher>t, List<Course>c)
        {
            students = s;
            teachers = t;
            courses = c;
        }
        public Form5()
        {
            InitializeComponent();
        }
        private void createLabButton_Click(object sender, EventArgs e)
        {  
            foreach (Course item in courses)
            {
                if (item.GetID()==int.Parse(textBox2.Text))
                {
                    Lab l = new Lab(textBox1.Text,item);
                    //l.AddCourse(item);
                    labbar.Add(l);
                    break;
                }
            }                  
        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
