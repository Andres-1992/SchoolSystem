using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Lab
    {
        public int LabID = new Random().Next(1, 8);
        public string Namn { get; set; }
        private string Grade;
        private Student student;
        private Course Course;
        public Lab(string namn,Course c)
        {
            this.Namn = namn;
            this.Course = c;
        }
        public int GetID()
        {
            return LabID;
        }
        public void AddStudentAndBetyg(Student s, string grade)
        {
            student = s;
            this.Grade = grade;
        }
        public string[] ListaAllalabbar()
        {
            var rad = new string[] { LabID.ToString(), Namn,Course.Name };
            return rad;
        }
        public Course GetCourse()
        {
            return Course;
        }
        public Student GetStudent()
        {
            return student;
        }
        public string PrintInfo()
        {
            return $"Student: {student.Name} Lab: {Namn} Course: {Course.Name} Grade: {Grade}";
        }
    }

}
