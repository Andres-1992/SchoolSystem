using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public abstract class Person :IPerson
    {
        public string Name { get; set; }
        protected string Email { get; set; }
        protected string PersonNummer { get; set; }

        public abstract int GetID();

        public abstract string[] ListToPrint();

    }
}
