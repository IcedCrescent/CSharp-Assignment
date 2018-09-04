using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced___LINQ
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2:MM/dd/yyyy}", ID, Name, Birthday);
        }
    }
}
