using System;

namespace CircleObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a circle with a radius of 1
            Circle circle1 = new Circle();
            //the radius of circle1 should be 1
            Console.WriteLine($"radius of circle1 = {circle1.Radius}");
            Console.WriteLine($"Area of circle1 = {circle1.Area():f2}");
            Console.WriteLine($"Perimeter of circle1 = {circle1.Perimeter():f2}");
            Console.WriteLine();
            //change radius of circle1 to 5
            circle1.Radius = -5;
            //the radius of circle1 should be 5
            Console.WriteLine($"radius of circle1 = {circle1.Radius}");
            Console.WriteLine($"Area of circle1 = {circle1.Area():f2}");
            Console.WriteLine($"Perimeter of circle1 = {circle1.Perimeter():f2}");
        }
    }
}
