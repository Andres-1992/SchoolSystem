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
	public partial class Form3 : Form
	{
		List<Teacher> teachers= new List<Teacher>();
		public Form3()
		{
			InitializeComponent();
		}
        public void SetAllTeachers(List<Teacher> t)
        {
            teachers = t;
        }

        private void buttonCloseForm2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Owner.Show();
		}

		private void addTeacherButton_Click(object sender, EventArgs e)
		{
			string name = TfirstnameBox.Text + " " + TlastnameBox.Text;
			Teacher t = new Teacher(name, TemailBox.Text, TpersNrBox.Text, int.Parse(salaryBox.Text)); ;
			teachers.Add(t);
			TfirstnameBox.Clear();
			TlastnameBox.Clear();
			TemailBox.Clear();
			TpersNrBox.Clear();
			salaryBox.Clear();

			listViewTeachers.Items.Clear();
			foreach (Teacher item in teachers)
            {
				var listView = new ListViewItem(item.ListaAttPrinta());
                listViewTeachers.Tag = item;
                listViewTeachers.Items.Add(listView);
			}
		}


        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {

            Teacher t = teachers.Find(x => (x.GetID().Equals(int.Parse(IDbox.Text))));
            teachers.Remove(t);

            listViewTeachers.Items.Clear();
            IDbox.Clear();
            foreach (Teacher item in teachers )
            {
                var listView = new ListViewItem(item.ListaAttPrinta());
                listView.Tag = item;
                listViewTeachers.Items.Add(listView);
            }
           
        }
    }
}
