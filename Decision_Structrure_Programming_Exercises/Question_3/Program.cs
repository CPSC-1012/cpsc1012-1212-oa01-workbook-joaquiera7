/*Purpose:   A program that plays Rock-Paper-Scissors game
 * 
 * input:    userPick
 * 
 * output:   result
 * 
 * Algorithm:1)prompt for user pick (userPick)
 *           2)check if user win or loses
 *           3)display result
 */

using System;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock Paper Scissors Game");

            //assign choices
            

            //prompt for user pick (userPick)
            Console.WriteLine("Rock (0), Paper (1), Scissors(2)");
            Console.Write("Your pick >");
            int userPick = int.Parse(Console.ReadLine());

            //generate random number for computer
            Random rnd = new Random();
            int computerPick = rnd.Next(0, 3);


            //check
            //result message
            string youWin = "You WIN.";
            string youLose = "You LOSE.";
            string draw = "It's a DRAW.";

            //
            Console.WriteLine(computerPick);

            if (userPick < 3)
            {
                if (userPick > computerPick || userPick == 0)    //user win
                {
                    if (userPick == 0 && computerPick == 1) //user lose
                    {
                        Console.WriteLine("You picked Rock. The computer picked Paper.");
                        Console.WriteLine(youLose);
                    }
                    else if (userPick == 1 && computerPick == 2)    //user lose
                    {
                        Console.WriteLine("You picked Paper. The computer picked Scissors.");
                        Console.WriteLine(youLose);
                    }
                    else
                    {
                        Console.WriteLine(youWin);
                    }
                }
                else if (userPick < computerPick)
                {
                    Console.WriteLine(youLose);
                }
                else if (userPick == computerPick)  //if draw
                {
                    if (userPick == 0)          //if both rock
                    {
                        Console.WriteLine("You picked Rock. The computer picked Rock.");
                        Console.WriteLine(draw);
                    }
                    else if (userPick == 1)     //if both paper
                    {
                        Console.WriteLine("You picked Paper. The computer picked Paper.");
                        Console.WriteLine(draw);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

            /*if (userPick > computerPick)    //user win
            {
                if (userPick == 0 && computerPick == 1) //user lose
                {
                    Console.WriteLine("You picked Rock. The computer picked Paper.");
                    Console.WriteLine(youLose);
                }
                else if (userPick == 1 && computerPick == 2)    //user lose
                {
                    Console.WriteLine("You picked Paper. The computer picked Scissors.");
                    Console.WriteLine(youLose);
                }
                else
                {
                    Console.WriteLine(youWin);
                }
            }
            else if (userPick < computerPick)
            {
                Console.WriteLine(youLose);
            }
            else if (userPick == computerPick)  //if draw
            {
                if (userPick == 0)          //if both rock
                {
                    Console.WriteLine("You picked Rock. The computer picked Rock.");
                    Console.WriteLine(draw);
                }
                else if (userPick == 1)     //if both paper
                {
                    Console.WriteLine("You picked Paper. The computer picked Paper.");
                    Console.WriteLine(draw);
                }
            }*/
            Console.ReadLine();
        }
    }
}
