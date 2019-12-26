using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Teacher: Person
    {
        private int TeacherID { get; set; }
        private int Salary { get; set; }
        public Teacher(string name, string email, string personnummer,int salary)
        {
            TeacherID = new Random().Next(9000, 10000);
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personnummer;
            this.Salary = salary;
            
        }
        public override string[] ListaAttPrinta()
        {
            var rad = new string[] { TeacherID.ToString(), Name, Email, PersonNummer, Salary.ToString() };
            return rad;
        }
    }
}
