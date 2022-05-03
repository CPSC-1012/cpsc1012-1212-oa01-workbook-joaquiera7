using System;

namespace RoomCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a  rectangle object (instance) for thge four sides of the room
            /*Rectangle leftWall = new Rectangle(10, 8);
            Rectangle rightWall = new Rectangle(10, 8);
            Rectangle frontWall = new Rectangle(12, 8);
            Rectangle backWall = new Rectangle(12, 8);

            Rectangle door = new Rectangle(7, 2.5);
            Rectangle window = new Rectangle(3, 4.5);
            Rectangle closet = new Rectangle(7, 5);*/

            //the default length is 4
            //default width is 5
            Rectangle defaultSize = new Rectangle();

            //double paintableWallArea = leftWall.Area() + rightWall.Area() + frontWall.Area() + backWall.Area() - door.Area() - window.Area() - closet.Area();

            //double paintableWallArea = ;

            //Console.WriteLine($"The paintable wall area should be 286.");
            //Console.WriteLine($"Actual area is {paintableWallArea}.");
            Console.WriteLine($"The width of the left wall is {defaultSize.Width}");
        }
    }
}
