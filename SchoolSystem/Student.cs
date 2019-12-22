using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Student : Person
    {
        private int StudentID = new Random().Next(1, 1000);
       // public List<Student> studenter = new List<Student>();
        
        public Student(string name,string email,string personNummer)
        {
           
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personNummer;
        }

        //public string PrintID()
        //{
        //    return $"{ this.StudentID }\n{this.Name}\n{this.Email}\n{this.PersonNummer}";

        //}
        public string[] listaAttPrinta(List<Student> lista)
        {

             string[] rad = new string[lista.Count]; // { StudentID.ToString(), Name, Email, PersonNummer };
            foreach (Student item in lista)
            {
                rad = new string[] { item.StudentID.ToString(), item.Name, item.Email, item.PersonNummer };
                
            }
           
            return rad;
            
        }


    }
}
