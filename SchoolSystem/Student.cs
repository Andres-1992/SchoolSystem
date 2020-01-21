using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student : Person, IStudent
    {
        private static List<bool> UsedCounter = new List<bool>();
        private int StudentID { get; set; }
        private List<Course> Courses = new List<Course>();
        public Student(string name, string email, string personNummer)
        {
            int nextIndex = -1;
            if (nextIndex == -1)
            {
                nextIndex = UsedCounter.Count;
                UsedCounter.Add(true);
            }
            StudentID = nextIndex;
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personNummer;
        }
        public int GetID()
        {
            return this.StudentID;
        }
        public string[] ListToPrint()
        {
            var rad = new string[] { StudentID.ToString(), Name, Email, PersonNummer };
            return rad;
        }
        public void AddCourse(Course c)
        {
            Courses.Add(c);
        }
    }
}
