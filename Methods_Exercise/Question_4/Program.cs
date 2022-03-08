using System;

using Cpsc1012;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Purpose:  - Write a program to calculate and display the surface area and volume of a rectangle.
             *          - Use the method CalculateArea() and CalculateVolume() which will passed in length, width and height.
             *          - Validation required to ensure a negative value is not allowed.
             *          
             *Input:    length, width, height
             *
             *Output:   resultArea, resultVolume
             * 
             */

            //user input
            double length, width, height;

            //result
            double resultArea, resultVolume;

            //prompt for input
            Console.WriteLine("Area of Rectangle Calculator");
            Console.WriteLine();
            length = Utilities.PromptForPositiveNumber("Length: ");
            width = Utilities.PromptForPositiveNumber("Width: ");
            height = Utilities.PromptForPositiveNumber("Height: ");

            //Calculate area by calling CalculateArea()
            resultArea = CalculateArea(length, width);

            //Calculate surface area by calling CalculateSurfaceArea()
            resultVolume = CalculateVolume(length, width, height);

            //display result
            Console.WriteLine();
            Console.WriteLine($"The area is {resultArea}");
            Console.WriteLine($"The volume is {resultVolume}");

        }

        static double CalculateArea(double length, double width)
        {
            double area;

            //calculate area
            area = length * width;

            return area;
        }

        static double  CalculateVolume(double length, double width, double height)
        {
            double volume;
            
            //calculate
            volume = length * width * height;

            return volume;
        }
    }
}
