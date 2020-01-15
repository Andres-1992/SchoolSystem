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
            bool kontroll = true;
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(courseIDbox.Text))));
            Student s = students.Find(x => (x.GetID().Equals(int.Parse(studentIDbox.Text))));
            if (!string.IsNullOrWhiteSpace(studentIDbox.Text))
            {
            c.AddStudentToCourse(s);
            }
           
            Teacher t = teachers.Find(x => (x.GetID().Equals(int.Parse(teacherIDbox.Text))));
            if (!string.IsNullOrWhiteSpace(teacherIDbox.Text))
            {
             c.AddTeacherToCourse(t);
            }
            if (s == null || t == null)
            {
                kontroll = false;
                MessageBox.Show("något gick fel");
            }

            if (kontroll)
            {
              MessageBox.Show("Student: " + s.Name + "\nLärare: " + t.Name + "\nHar lagts till i följande kurs: " + c.Name);
            }
        }

        private void deleteCoursebutton_Click(object sender, EventArgs e)
        {
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(IDbox.Text))));
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
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox1.Text))));
            Student s = students.Find(x => (x.GetID().Equals(int.Parse(sIDbox.Text))));
            c.DeleteStudent(s);
        }

        private void deleteTeacherbutton_Click(object sender, EventArgs e)
        {
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox2.Text))));
            Teacher t = teachers.Find(x => (x.GetID().Equals(int.Parse(tIDbox.Text))));
            c.DeleteTeacher(t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allStudentsinCourse.Items.Clear();
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox3.Text))));

            foreach (Student item in c.Getstudent())
            {
                allStudentsinCourse.Items.Add("Kurs : "+c.Name+ "\tStudennamn: "+item.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherTeaminCourse.Items.Clear();
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox4.Text))));
            foreach (Teacher item in c.GetTeachers())
            {
                teacherTeaminCourse.Items.Add("Kurs : " + c.Name + "\t Lärarnamn: " + item.Name);
            }
        }
    }
}
