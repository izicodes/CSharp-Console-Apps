using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Apps.InterestCalculator
{
    internal class InterestCalculator
    {
        public void Main()
        {
            Console.WriteLine(">> | Interest Calculator | <<\n");

            // Intro
            Console.WriteLine("An (simple) interest calculator that calculates the interest earned on a given principal amount over a specified period of time. Below shows what each factor means:\n");

            Console.WriteLine("- Simple Interest - The amount of interest earned on an investment or loan based on a fixed interest rate applied over a fixed time period.\n");
            Console.WriteLine("- Principal Amount: The initial amount of money invested or borrowed.\n");
            Console.WriteLine("- Interest Rate: The annual interest rate as a percentage.\n");
            Console.WriteLine("- Number of Years: The number of years the principal amount is invested or borrowed for.\n");

            Console.WriteLine(" ------------------- \n");

            Console.WriteLine("Here are the calculator's options:\n");

            // The options
            string[] operationsChoices = { "Find the Simple Interest", "Find the Principal Amount", "Find the Interest Rate", "Find the Number of Years", "Back to main menu" };
            for (int i = 0; i < operationsChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($" [ {num} ] {operationsChoices[i]}\n");
            }
            Console.WriteLine("\nPick a basic arithmetic operation:");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                SimpleInterest();
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
            }
            else if (choice == 5)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                Program.MainMenu();
            }
            else
            {
                Console.WriteLine("\nSorry, but you didn't pick an option from the list.\n\nTry again.");
                Program.ResetScreen(1500);
                Main();
            }

        }

        public void SimpleInterest()
        {
            Console.WriteLine(">> | Interest Calculator | <<\n");
            Console.WriteLine("[ 1 ] Find the Simple Interest\n");

            Console.WriteLine("Enter a valid currency symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("How much was the Principal Amount?");
            double principalAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWhat was the Interest Rate? (as a percentage, do not include the '%')");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWhat are the number of years the principal amount is invested or borrowed for?");
            double numberOfYears = Convert.ToDouble(Console.ReadLine());

            //Calculate the Simple Interest
            double answer = (principalAmount * interestRate * numberOfYears) / 100;
            Console.WriteLine(symbol + Convert.ToString(answer));

        }
    }
}
