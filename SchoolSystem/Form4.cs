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
    public partial class Form4 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Course> courses = new List<Course>();
            
        public void SetAll(List<Student> s,List<Teacher> t,List<Course> c)
        {
            students = s;
            teachers = t;
            courses = c;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void addCoursebutton_Click(object sender, EventArgs e)
        {
            Course c = new Course(courseNameBox.Text, float.Parse(HPbox.Text));
            courses.Add(c);
            courseNameBox.Clear();
            HPbox.Clear();
            listViewCourses.Items.Clear();
            foreach (Course item in courses)
            {
                var listView = new ListViewItem(item.ListaKurser());
                listViewCourses.Items.Add(listView);

            }
        }

        private void addToCoursebutton_Click(object sender, EventArgs e)
        {
            foreach  (Course item in courses)
            {
                if (item.GetID()==int.Parse(courseIDbox.Text))
                {
                    foreach (Student s in students)
                    {
                        if (s.GetID()==int.Parse(studentIDbox.Text))
                        {
                          item.AddStudentToCourse(s);
                            break;
                        }                       
                    }
                    foreach (Teacher t in teachers)
                    {
                        if (t.GetID()== int.Parse(teacherIDbox.Text))
                        {
                            item.AddTeacherToCourse(t);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void deleteCoursebutton_Click(object sender, EventArgs e)
        {
            foreach (Course item in courses)
            {
                if (item.GetID() == int.Parse(IDbox.Text))
                {
                    courses.Remove(item);
                    break;
                }
            }
            listViewCourses.Items.Clear();

            foreach (Course s in courses)
            {
                var listView = new ListViewItem(s.ListaKurser());
                listView.Tag = s;
                listViewCourses.Items.Add(listView);
            }
        }

        private void deleteStudentbutton_Click(object sender, EventArgs e)
        {
            foreach (Course item in courses)
            {
                if (item.GetID()==int.Parse(cIDbox1.Text))
                {
                    foreach (Student s in students)
                    {
                        if (s.GetID()==int.Parse(sIDbox.Text))
                        {
                            item.DeleteStudent(s.GetID());
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void deleteTeacherbutton_Click(object sender, EventArgs e)
        {
            foreach (Course item in courses)
            {
                if (item.GetID() == int.Parse(cIDbox2.Text))
                {
                    foreach (Teacher s in teachers)
                    {
                        if (s.GetID() == int.Parse(tIDbox.Text))
                        {
                            item.DeleteTeacher(s.GetID());
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
