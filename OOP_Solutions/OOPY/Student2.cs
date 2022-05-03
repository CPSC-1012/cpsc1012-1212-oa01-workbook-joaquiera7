using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPY
{
    public class Student2 : Student
    {
        public void Trythis()
        {
            Console.WriteLine($"ID: {StudentID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
        }

        public void ShowThis2()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine($"Name: {Name}, StudentID: {StudentID}, Address: {Address}");
        }
    }
}
