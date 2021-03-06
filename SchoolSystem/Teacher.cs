﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Teacher : Person, ITeacher
    {
        private static List<bool> UsedCounter = new List<bool>();
        private int TeacherID { get; set; }
        private int Salary { get; set; }
        private List<Course> Courses = new List<Course>();
        public Teacher(string name, string email, string personnummer, int salary)
        {
            int nextIndex = -1;
            if (nextIndex == -1)
            {
                nextIndex = UsedCounter.Count;
                UsedCounter.Add(true);
            }

            TeacherID = nextIndex;
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personnummer;
            this.Salary = salary;

        }
        public string[] ListToPrint()
        {
            var rad = new string[] { TeacherID.ToString(), Name, Email, PersonNummer, Salary.ToString() };
            return rad;
        }

        public int GetID()
        {
            return TeacherID;
        }

        public void AddCourse(Course c)
        {
            Courses.Add(c);
        }
    }
}
