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

        public Student(string name, string email, string personNummer)
        {
            StudentID = new Random().Next(1, 8500);
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personNummer;
        }

        public override string[] ListaAttPrinta()
        {
            var rad = new string[] { StudentID.ToString(), Name, Email, PersonNummer };
            return rad;
        }

        public override string PrintInfo()
        {
           return $"{ this.StudentID }\n{this.Name}\n{this.Email}\n{this.PersonNummer}"; 
        }
    }
}
