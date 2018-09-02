using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___OOP
{
    class Student
    {
        private int _sid;
        private string _name;
        private string _department;
        private double _gpa;

        public int SID
        {
            get
            {
                return _sid;
            }

            set
            {
                _sid = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        public double GPA
        {
            get
            {
                return _gpa;
            }

            set
            {
                _gpa = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0, -5} {1, -15} {2, -10} {3}", _sid, _name, _department, _gpa);
        }
    }
}
