using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Lab : ILab
    {
        public int LabID { get; set; }
        public string Namn { get; set; }
        private string Grade;
        private Student student;
        private Course Course;
        public Lab(string namn, Course c)
        {
            this.LabID = new Random().Next(1, 9);
            this.Namn = namn;
            this.Course = c;
        }

        public void GradeStudent(Student s, string grade)
        {
            student = s;
            this.Grade = grade;
        }
        public string[] ListAllLabs()
        {
            var rad = new string[] { LabID.ToString(), Namn, Course.Name };
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
