//Purpose : Find the length of the hypotenuse of a right triangle using Pythagorean Theorem
//input :   base, height,
//output:   hypotenuse
//Algorithm:Step 1)get user input for base and height
//          Step 2)calculate for hypotenuse using Pythagorean theorem "c = sqrt(a^2 + b^2)"
//          Step 3)Display result

using System;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pythagorean Theorem(solving for hypotenuse)\n");
            
            //get user input for base and height
            Console.Write("Enter the base: ");
            double baseTriangle = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            double heightTriangle = double.Parse(Console.ReadLine());

            //calculate
            double hypotenuse = Math.Sqrt((Math.Pow(baseTriangle, 2) + Math.Pow(heightTriangle, 2)));

            //display result
            Console.WriteLine($"The hypotenuse is {hypotenuse}.");
        }
    }
}
