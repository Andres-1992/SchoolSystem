using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public abstract class Person
    {
        public string Name { get; set; }
        protected string Email { get; set; }
        protected string PersonNummer { get; set; }

    }
}
