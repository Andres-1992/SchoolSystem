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
        List<Lab> labs =new List<Lab>();
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
            Course c = courses.Find(x => (x.GetID().Equals(int.Parse(textBox2.Text))));
            Lab l = new Lab(textBox1.Text, c);
            labs.Add(l);
            listViewLab.Items.Clear();

            foreach (Lab item in labs)
            {
                var listView = new ListViewItem(item.ListaAllalabbar());
                listViewLab.Items.Add(listView);
            }
        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab  l = labs.Find(x => x.LabID.Equals(int.Parse(lIDtextBox.Text)));
            Student s = students.Find(x => x.GetID().Equals(int.Parse(sIDtextBox.Text)));
            l.GetCourse();
            l.AddStudentAndBetyg(s, betygtextBox.Text);
            MessageBox.Show("Grade: " + betygtextBox.Text + "\nStudent: " + s.Name + "\nLab: " +l.Namn+"\nCourse: " + l.GetCourse().Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in labs.FindAll(x => x.GetStudent().GetID().Equals(int.Parse(textBox3.Text))))
            {
               listBox1.Items.Add( item.PrintInfo());
            }              
            
        }
    }
}
