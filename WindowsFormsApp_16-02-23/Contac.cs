using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_16_02_23;

namespace WindowsFormsApp_16_02_23
{
    internal class Contac : Person
    {
        private String telephone;

        public string Telephone
        {
            get { return telephone; }
            set
            {
                telephone = value.Replace(" ", "").Replace("-", "");
            }
        }

        public Contac() : base()
        {
            telephone = string.Empty;
        }

        public Contac(string name, DateTime? birthdate, string telephone) : base(name, birthdate)
        {
            this.telephone = telephone;
        }

        public override string ToString()
        {
            return base.ToString() + " Telefono: " + telephone;
        }

    }
}