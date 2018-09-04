using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Polymorphism
{
    class LaboratoryEmployee : Person
    {
        public double Salary { get; set; }
        public override string ToString()
        {
            return string.Format("{0, -10} {1:MM/dd/yyyy, -10} {2, -10} {3:C}", Name, DOB, Degree, Salary);
        }
    }
}
