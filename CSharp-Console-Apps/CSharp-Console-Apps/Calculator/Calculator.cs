using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Apps.Calculator
{
    internal class Calculator
    {
        public void Main()
        {
            Console.WriteLine(">> | Calculator | <<\n");

            // Intro
            Console.WriteLine("This calculator console app can do: \n");
            

            // The options
            string[] operationsChoices = { "Addition", "Subtraction", "Multiplication", "Division" };
            for (int i = 0; i < operationsChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($"[ {num} ] {operationsChoices[i]}\n");
            }
            Console.WriteLine("\nPick a basic arithmetic operation:\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nLoading. . .");
            

            if (choice == 1)
            {
                Program.ResetScreen(1200);
                Addition();
            }

        }

        public void Addition()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 1 ] Addition\n");
            Console.WriteLine("How many numbers do you want to add together?");
            int numberLength = Convert.ToInt32(Console.ReadLine());
            List<int> numbersList = new List<int>();

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            for (int i = 0; i < numberLength; i++)
            {
                int num = i + 1;
                Console.WriteLine($"Input no.{num} number needed:");
                numbersList.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nThank you.");
        }
    }
}
