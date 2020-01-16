using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
   public class Student : Person
    {
        private static List<bool> UsedCounter = new List<bool>();
        private int StudentID { get; set; }

        public Student(string name, string email, string personNummer)
        {    
                int nextIndex = -1;
                if (nextIndex == -1)
                {
                    nextIndex = UsedCounter.Count;
                    UsedCounter.Add(true);
                }
                StudentID = nextIndex;       
            this.Name = name;
            this.Email = email;
            this.PersonNummer = personNummer;
        }
 
        public override int GetID()
        {
            return this.StudentID;
        }
        public override string[] ListToPrint()
        {
            var rad = new string[] { StudentID.ToString(), Name, Email, PersonNummer };
            return rad;
        }

    }
}
