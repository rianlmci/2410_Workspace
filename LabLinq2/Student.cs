using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLinq2
{
    /// <summary>
    /// Student defined by its name, major, graduation year,
    /// and whether the student is an honor student or not.
    ///
    /// author: CSIS 2420 - do not modify
    /// </summary>
    public class Student
    {
        public string Name { get; }
        public string Major { get; }
        public int Year { get; }
        public bool Honor { get; }

        public Student(string n, string m, int y, bool h)
        {
            Name = n;
            Major = m;
            Year = y;
            Honor = h;
        }

        public override string ToString()
        {
            return string.Format("{0}{1} ({2}) .. {3}", Honor ? "*" : " ", Name, Year, Major);
        }
    }

}
