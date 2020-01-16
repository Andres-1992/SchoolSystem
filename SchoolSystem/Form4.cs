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

        public void SetAll(List<Student> s, List<Teacher> t, List<Course> c)
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
                var listView = new ListViewItem(item.ListCourses());
                listViewCourses.Items.Add(listView);
            }
        }

        private void addToCoursebutton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(courseIDbox.Text))
            {
                Course c = courses.Find(x => (x.GetID().Equals(int.Parse(courseIDbox.Text))));
                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(teacherIDbox.Text))
                {                                      
                        Teacher t = teachers.Find(x => (x.GetID().Equals(int.Parse(teacherIDbox.Text))));
                        if (t == null || c == null)
                        {
                            MessageBox.Show("fel");
                        }
                        else
                        {
                            c.AddTeacherToCourse(t);
                            MessageBox.Show("Teacher: " + t.Name + "\nWas added to course " + c.Name);
                        }
                        teacherIDbox.Clear();                    
                }
                else if (checkBox1.Checked && string.IsNullOrEmpty(teacherIDbox.Text))
                {
                    MessageBox.Show("Fill teacherID");
                }               
                    if (checkBox2.Checked && !string.IsNullOrWhiteSpace(studentIDbox.Text))
                    {
                        Student s = students.Find(x => (x.GetID().Equals(int.Parse(studentIDbox.Text))));
                        if (s == null || c == null)
                        {
                            MessageBox.Show("fel");
                        }
                        else
                        {
                            c.AddStudentToCourse(s);
                            MessageBox.Show("Student: " + s.Name + "\nWas added to course " + c.Name);
                        }
                        studentIDbox.Clear();
                    }

                else if (checkBox2.Checked && string.IsNullOrWhiteSpace(studentIDbox.Text))
                {
                    MessageBox.Show("Fill StudentID");
                }
                else if (c== null)
                {                    
                       MessageBox.Show("Course ID: " + courseIDbox.Text+ " does not exist");
                }
            }  
            else
            {
                MessageBox.Show("You havent done anything");
            }        

        }
        private void deleteCoursebutton_Click(object sender, EventArgs e)
        {
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(IDbox.Text))));
            courses.Remove(c);

            listViewCourses.Items.Clear();

            foreach (Course s in courses)
            {
                var listView = new ListViewItem(s.ListCourses());
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
            if (c != null)
            {
                foreach (Student item in c.Getstudent())
                {
                    allStudentsinCourse.Items.Add("Course : " + c.Name + "\tStudentname: " + item.Name);
                }

            }
            else if (c==null)
            {
                MessageBox.Show("StudentId: "+ cIDbox3.Text + " does not exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherTeaminCourse.Items.Clear();
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(cIDbox4.Text))));
            if (c != null)
            {
                foreach (Teacher item in c.GetTeachers())
                {
                    teacherTeaminCourse.Items.Add("Course : " + c.Name + "\t Teachername: " + item.Name);
                }
            }
            else if (c == null)
            {
                MessageBox.Show("Course ID: "+ cIDbox4.Text + " does not exist");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                teacherIDbox.Enabled = true;
            }
            else
            {
                teacherIDbox.Enabled = false;
                teacherIDbox.BackColor = SystemColors.Window;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                studentIDbox.Enabled = true;
            }
            else
            {
                studentIDbox.Enabled = false;
                studentIDbox.BackColor = SystemColors.Window;
            }
        }
    }
}
