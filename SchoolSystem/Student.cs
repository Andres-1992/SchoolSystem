using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Student : Person
    {
        private int StudentID { get; set; }
        // public List<Student> studenter = new List<Student>();

        public Student(string name, string email, string personNummer)
        {
            StudentID = new Random().Next(1, 1000);
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personNummer;
        }
        //public string PrintID()
        //{
        //    return $"{ this.StudentID }\n{this.Name}\n{this.Email}\n{this.PersonNummer}";

        //}
        public string[] listaAttPrinta()
        {

            var rad = new string[] { StudentID.ToString(), Name, Email, PersonNummer };
            return rad;
        }


    }
}
