using System;
using Cpsc1012;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Purpose:  - Write a program to keep track of revenue of a one-person taxi company. Must use menu.
             * 
             * Input:   distanceTravelled, timeOfTrip, fare, tip
             * 
             * Output:  totalGrossIncome
             * 
             */

            //user Input
            int menuSelected = 0;

            //result
            double totalGrossIncome = 0;
            

            while (menuSelected > 1 || menuSelected < 4)
            {
                Console.Clear();

                Console.WriteLine($"{totalGrossIncome:c2}");
                Console.WriteLine("Revenue Calculator");
                Console.WriteLine();
                Console.WriteLine("1 > Airport Trip");
                Console.WriteLine("2 > Regular Fare");
                Console.WriteLine("3 > Flat Rate");
                Console.WriteLine("4 > Exit Program / End the day");    //display total gross income
                menuSelected = Utilities.PromptForPositiveNumber(1, 4, "Enter a number 1-4: ");

                switch (menuSelected)
                {
                    case 1:
                        totalGrossIncome += CalculateAirportCharge();
                        break;

                    case 2:
                        totalGrossIncome += CalculateRegularFareCharge();
                        break;

                    case 3:
                        totalGrossIncome += CalculateFlatRate();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Total gross income: {totalGrossIncome:c}");
                        Console.WriteLine();
                        Console.WriteLine("Exiting . . . .");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            
            static double CalculateAirportCharge()
            {
                Console.Clear();
                double chargePerTrip = 25;
                double totalAirportCharge = 0;

                Console.WriteLine($"Airport Charge: {chargePerTrip:c}");
                double tip = Utilities.PromptForDoublePositiveOrZero("Tip: ");

                //calculate total of airport fares
                totalAirportCharge += (tip + chargePerTrip);
                return totalAirportCharge;
            }

            static double CalculateRegularFareCharge()
            {
                double distanceTravelled = 0;
                double timeOfTrip = 0;
                double tip = 0;

                double chargePerKM = 1.1;
                double chargePerMin = 0.2;
                double totalRegularFareCharge = 0;


                Console.Clear();
                distanceTravelled = Utilities.PromptForDoublePositiveOrZero("Enter distance travelled(in km): ");
                timeOfTrip = Utilities.PromptForDoublePositiveOrZero("Enter time of trip(in minutes): ");
                tip = Utilities.PromptForDoublePositiveOrZero("Enter tip: ");

                //calculate regular fare
                totalRegularFareCharge = (distanceTravelled * chargePerKM) + (timeOfTrip * chargePerMin) + tip;
                return totalRegularFareCharge;
            }

            static double CalculateFlatRate()
            {
                double flatRateTotal = 0;
                double flatRate = 0;
                double tip = 0;

                Console.Clear();
                flatRate = Utilities.PromptForDoublePositiveOrZero("Enter flat rate: ");
                tip = Utilities.PromptForDoublePositiveOrZero("Enter tip: ");

                //calculate flat rate
                flatRateTotal = flatRate + tip;
                return flatRateTotal;
            }
        }

        
    }
}
