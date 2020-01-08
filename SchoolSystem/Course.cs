using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Course
    {
        private int KursID { get; set; }
        private string Name { get; set; }
        private int DurationInWeeks { get; set; }
        private List<Student> Students { get; set; }
        private List<Teacher> TeacherTeam { get; set; }

        public Course(string name, int durationInWeeks)
        {
            KursID = new Random().Next(5, 9888);
            this.Name = name;
            this.DurationInWeeks = durationInWeeks;
        }
        void AddStudent(Student s)

        {
            if (!s.Equals(null))
            {
                Students.Add(s);
            }

        }
        void AddTeacher(Teacher t)
        {
            if (!t.Equals(null))
            {
            TeacherTeam.Add(t);
            }
        }
    }
}
