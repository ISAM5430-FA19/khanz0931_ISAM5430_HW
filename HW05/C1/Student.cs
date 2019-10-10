using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Student
    {
        public string lastName, firstName, major, classification;
        public int number;
        public double overallGPA;

        public Student()
        {
            lastName = "Khan";
            firstName = "Zaid";
            number = 1255242;
            major = "Management Information System";
            classification = "Freshmen";
        }

        public Student(double gpa) : this()
        {
            gpa = 3.2;
            overallGPA = gpa;
        }
    }
}
