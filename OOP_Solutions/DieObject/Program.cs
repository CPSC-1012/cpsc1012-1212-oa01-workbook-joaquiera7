using System;

namespace DieObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Die sixSidedDie = new Die(5);

            Die twelveSidedDie = new Die();

            Console.WriteLine($"{sixSidedDie.Value} {twelveSidedDie.Value, 10}");

            //simulate rolling the two dice 5 times
            Console.WriteLine("Rolling the two dice 5 times");
            for (int counter = 1; counter <= 5; counter++)
            {
                sixSidedDie.Roll();
                twelveSidedDie.Roll();
                Console.WriteLine($"{sixSidedDie.Value,10} {twelveSidedDie.Value,10}");
            }

            
        }
    }
}
