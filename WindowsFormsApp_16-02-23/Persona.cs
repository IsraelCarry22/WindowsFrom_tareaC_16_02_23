using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_16_02_23
{
    internal class Person
    {
        protected String name;
        protected DateTime? birthdate;

        public String Name
        {
            get { return name; } 
            set { name = value; }
        }
        public DateTime? Birthdate
        {
            get { return birthdate; } 
            set { birthdate = value; }
        }
        public int Age
        {
            get
            {
                int age;
                age = (DateTime.Now.Year - birthdate.Value.Year);
                return age;
            }
        }

        public Person()
        {
            name = String.Empty;
            birthdate = null;
        }
        public Person(String name, DateTime? birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

        public override string ToString()
        {
            return name.ToUpper() + " " + Age;
        }

    }
}