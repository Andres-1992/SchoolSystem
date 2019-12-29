﻿using System;
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

		private void buttonCloseForm1_Click(object sender, EventArgs e)
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
				{
					Tag = item;

				}
				listViewTeachers.Items.Add(listView);

			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}
	}
}