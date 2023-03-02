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
            Console.WriteLine("Pick a basic arithmetic operation:\n");
            int choice = Convert.ToInt32(Console.ReadLine());


        }
    }
}
