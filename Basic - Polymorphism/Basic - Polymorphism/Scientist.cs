using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Polymorphism
{
    class Scientist : Person, ISalary
    {
        public string Role { get; set; }
        public int PublishedArticlesCount { get; set; }
        public int WorkedDay { get; set; }
        public int PayGrade { get; set; }

        public double GetSalary()
        {
            return WorkedDay * PayGrade;
        }

        public override string ToString()
        {
            return string.Format("{0, -10} {1:MM/dd/yyyy, -10} {2, -10} {3, -20} {4, -3} {5, -3} {6:C}", Name, DOB, Degree, Role, PublishedArticlesCount, WorkedDay, PayGrade);
        }
    }
}
