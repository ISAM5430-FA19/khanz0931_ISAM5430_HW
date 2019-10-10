using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine($"Student Name: {student.firstName} {student.lastName}");
            Console.WriteLine($"Student Number: {student.number}");
            Console.WriteLine($"Major: {student.major}");
            Console.WriteLine($"Classification: {student.classification}");
            Console.WriteLine($"Overall GPA: {student.overallGPA}");
        }
    }
}
