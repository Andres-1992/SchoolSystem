using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Course
    {
        private int KursID { get; set; }
        private string Name { get; set; }
        private float HP { get; set; }
        private List<Student> Students = new List<Student>();
        private List<Teacher> TeacherTeam = new List<Teacher>();

        public Course(string name, float hp)
        {
            KursID = new Random().Next(201, 300);
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
        public string[] ListaKurser()
        {
            var rad = new string[] { KursID.ToString(), HP.ToString(), Name };
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
            return KursID;
        }
        public void DeleteStudent(int ID)
        {
            foreach (Student item in Students)
            {
                if (item.GetID()==ID)
                {
                    Students.Remove(item);
                    break;
                }
            }
        }
        public void DeleteTeacher(int ID)
        {
            foreach (Teacher item in TeacherTeam)
            {
                if (item.GetID()==ID)
                {
                    TeacherTeam.Remove(item);
                    break;
                }
            }
        }
    }
}
