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
            Course c;
            c = courses.Find(x => (x.GetID().Equals(int.Parse(courseIDbox.Text))));

            Student s;
            s = students.Find(x => (x.GetID().Equals(int.Parse(studentIDbox.Text))));
            c.AddStudentToCourse(s);

            Teacher t;
            t = teachers.Find(x => (x.GetID().Equals(int.Parse(teacherIDbox.Text))));
            c.AddTeacherToCourse(t);
        }

        private void deleteCoursebutton_Click(object sender, EventArgs e)
        {
            Course c;
            c = courses.Find(x => (x.GetID().Equals(int.Parse(IDbox.Text))));
            courses.Remove(c);        
    
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
            Course c;
            c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox1.Text))));
            Student s;
            s = students.Find(x => (x.GetID().Equals(int.Parse(sIDbox.Text))));
            c.DeleteStudent(s);
        }

        private void deleteTeacherbutton_Click(object sender, EventArgs e)
        {
            Course c;
            c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox2.Text))));
            Teacher t;
            t = teachers.Find(x => (x.GetID().Equals(int.Parse(tIDbox.Text))));
            c.DeleteTeacher(t);
        }
    }
}
