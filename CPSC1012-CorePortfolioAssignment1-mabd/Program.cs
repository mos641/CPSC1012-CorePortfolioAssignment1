// File:    Program.cs
// Purpose: Calculate the full charge of a meal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_CorePortfolioAssignment1_mabd
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double mealCharge;
            double taxAmount, taxRate;
            int menuSelection;
            double tipAmount = 0, tipPercent = 0, tipFinal, tipMenu;
            double chargeTotal;

            // display purpose
            Console.WriteLine("Restaurant Bill");
            Console.WriteLine("---------------");
            Console.WriteLine("This program computes the tax and tip on a restaurant bill.");
            Console.WriteLine("");

            // ask for input for the meal charge and capture
            Console.WriteLine("Enter the charge for the meal in dollars and cents: ");
            mealCharge = double.Parse(Console.ReadLine());

            // ask for input for the tax rate and capture
            Console.WriteLine("Enter the tax rate (as a percent of 100): ");
            taxRate = double.Parse(Console.ReadLine());

            // ask for input for tipping preference and capture
            Console.WriteLine("Enter a number for your tipping preference: ");
            Console.WriteLine("1) %");
            Console.WriteLine("2) $");
            menuSelection = int.Parse(Console.ReadLine());

            // show the correct menu in respect to their choice
            if (menuSelection == 1)
            {
                // ask for input (from menu) on tip percent and capture
                Console.WriteLine("Enter a number for the tip percentage: ");
                Console.WriteLine("1) 10% (${0:n2})", tipMenu = mealCharge * 0.10);
                Console.WriteLine("2) 15% (${0:n2})", tipMenu = mealCharge * 0.15);
                Console.WriteLine("3) 20% (${0:n2})", tipMenu = mealCharge * 0.20);
                Console.WriteLine("4) Custom");
                menuSelection = int.Parse(Console.ReadLine());

                // create case structure to implement menu choice
                switch (menuSelection)
                {
                    case 1:
                        tipPercent = 10;
                        break;
                    case 2:
                        tipPercent = 15;
                        break;
                    case 3:
                        tipPercent = 20;
                        break;
                    case 4:
                        // ask for a custom percent and capture
                        Console.WriteLine("Enter the tip percent (as a percent of 100): ");
                        tipPercent = double.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("The number {0} is not a menu choice.", menuSelection);
                        break;
                }
            }
            else if (menuSelection == 2)
            {
                // ask for a tip amount and capture
                Console.WriteLine("Enter the tip amount: ");
                tipAmount = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("The number {0} is not a menu choice.", menuSelection);
            }

            //calculate tip final, tax amount and total charge
            tipFinal = tipAmount + (tipPercent / 100 * mealCharge);
            taxAmount = (taxRate / 100) * mealCharge;
            chargeTotal = mealCharge + taxAmount + tipFinal;

            // display all the collected and calculated information
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0,-40}{1,12:C2}", "Meal Charge:", mealCharge);
            Console.WriteLine("{0,-40}{1,12:C2}", "Tax Amount:", taxAmount);
            Console.WriteLine("{0}({1,-6:P2}{2,-22}{3,12:C2}", "Tip Amount: ", tipPercent = (mealCharge / tipFinal), ")", tipFinal);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0,-40}{1,12:C2}", "Total Bill:", chargeTotal);

            // keep the console window open
            Console.ReadLine();
        }
    }
}
