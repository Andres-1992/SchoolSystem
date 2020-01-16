using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Course
    {
        private int CourseID { get; set; }
        public string Name { get; set; }
        private float HP { get; set; }
        private List<Student> Students = new List<Student>();
        private List<Teacher> TeacherTeam = new List<Teacher>();

        public Course(string name, float hp)
        {
            CourseID = new Random().Next(201, 300);
            this.Name = name;
            this.HP = hp;
        }
        public void AddStudentToCourse(Student s)
        {
            if (!s.Equals(null))
            {
                Students.Add(s);
            }
        }
        public List<Student> Getstudent()
        {
            return Students;
        }
        public List<Teacher> GetTeachers()
        {
            return TeacherTeam;
        }
        public string[] ListCourses()
        {
            var rad = new string[] { CourseID.ToString(), HP.ToString(), Name };
            return rad;
        }
        public void AddTeacherToCourse(Teacher t)
        {
            if (!t.Equals(null))
            {
                TeacherTeam.Add(t);
            }
        }
        public int GetID()
        {
            return CourseID;
        }
        public void DeleteStudent(Student s)
        {
            Students.Remove(s);
        }

        public void DeleteTeacher(Teacher t)
        {
            TeacherTeam.Remove(t);
        }

    }
}
