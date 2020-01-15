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
        private string Betyg;
        private Student student;
        private Course Kurs;
        public Lab(string namn,Course c)
        {
            this.Namn = namn;
            this.Kurs = c;
        }
        public int GetID()
        {
            return LabID;
        }
        public void AddStudentAndBetyg(Student s, string betyg)
        {
            student = s;
            this.Betyg = betyg;
        }
        public string[] ListaAllalabbar()
        {
            var rad = new string[] { LabID.ToString(), Namn,Kurs.Name };
            return rad;
        }
        public Course GetCourse()
        {
            return Kurs;
        }
        public Student GetStudent()
        {
            return student;
        }
        public string PrintInfo()
        {
            return $"Student: {student.Name} Lab: {Namn} Kurs: {Kurs.Name} Betyg: {Betyg}";
        }
    }

}
