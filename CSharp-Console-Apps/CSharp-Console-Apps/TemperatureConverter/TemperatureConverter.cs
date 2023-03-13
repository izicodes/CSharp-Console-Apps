using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Apps.TemperatureConverter
{
    internal class TemperatureConverter
    {
        public void Main()
        {
            Console.WriteLine(">> | Temperature Converter | <<\n");

            // Intro
            Console.WriteLine("This temperature converter console app can convert: \n");


            // The options
            string[] conversionChoices = { "Celsius to Fahrenheit", "Celsius to Kelvin ", "Fahrenheit to Celsuis", "Fahrenheit to Kelvin", "Kelvin to Celsuis", "Kelvin to Fahrenheit", "Back to main menu" };
            for (int i = 0; i < conversionChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($"[ {num} ] {conversionChoices[i]}\n");
            }
            Console.WriteLine("\nPick a conversion:");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                CToF();
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
            }
            else if (choice == 6)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
            }
            else if (choice == 7)
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

        public void CToF()
        {
            Console.WriteLine(">> | Temperature Converter | <<\n");
            Console.WriteLine("[ 1 ] Celsius to Fahrenheit\n");
            Console.WriteLine("Enter the temperature in degrees Celsius (°C):");
            int temp = Convert.ToInt32(Console.ReadLine());

            int convertedNumber = (int)(temp * 1.8);
            convertedNumber += 32;

            Console.WriteLine(" ------------------- \n");
            string answer = temp + "°C = " + convertedNumber + "°F";
            Console.WriteLine(answer);

        }
    }
}
