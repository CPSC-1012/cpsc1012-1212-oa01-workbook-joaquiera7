using System;

namespace OOPY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Jongie Oaquiera";
            student.StudentID = 2011201;
            student.Address = "104 28a ave nw. Edmonton AB";

            student.ShowDetails();

            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Student ID: ");
            student.StudentID = int.Parse(Console.ReadLine());

            Console.Write("Address:");
            student.Address = Console.ReadLine();

            student.ShowDetails();

            Student2 student2 = new Student2();
            student2.Name = "second";
            student2.StudentID = 123551;
            student2.Address = "anywhere";
            student2.Trythis();
        }
    }
}
