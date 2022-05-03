using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPY
{
    public class Student
    {
        //fields
        public int StudentID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine($"StudentID: {StudentID}, Name: {Name}, Address: {Address}");

        }
    }
}
