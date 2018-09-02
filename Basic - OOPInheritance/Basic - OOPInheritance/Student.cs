using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___OOPInheritance
{
    class Student : People
    {
        public int SID { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
        public override string ToString()
        {
            return string.Format("{0, -5} {1, -15} {2, -15} {3}", SID, Name, Department, GPA); ;
        }
    }
}
