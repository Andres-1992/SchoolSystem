using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Lab
    {
        private int LabID { get; set; }
        private string Namn { get; set; }
        private string Betyg;
        private Student student;
        private Course Kurs;
        public Lab(string namn,Course c)
        {
            this.Namn = namn;
            this.Kurs = c;

        }
        public void AddCourse(Course c)
        {
            Kurs = c;
        }
        public void AddStudentAndBetyg(Student s, string betyg)
        {
            student = s;
            this.Betyg = betyg;
        }
    }

}
