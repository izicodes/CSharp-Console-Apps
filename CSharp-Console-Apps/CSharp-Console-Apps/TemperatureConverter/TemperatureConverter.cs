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
                CToK();
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                FToC();
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                FToK();
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
            Console.WriteLine("Enter the temperature in Degrees Celsius (°C):");
            double temp = Convert.ToInt32(Console.ReadLine());

            double convertedNumber = temp * 1.8;
            convertedNumber += 32;
            convertedNumber = Math.Round(convertedNumber, 2);

            Console.WriteLine(" ------------------- \n");
            string answer = temp + "°C = " + convertedNumber + "°F";
            Console.WriteLine(answer);
            Return();

        }

        public void CToK()
        {
            Console.WriteLine(">> | Temperature Converter | <<\n");
            Console.WriteLine("[ 2 ] Celsius to Kelvin\n");
            Console.WriteLine("Enter the temperature in Degrees Celsius (°C):");
            double temp = Convert.ToDouble(Console.ReadLine());

            double convertedNumber = (temp + 273.15);
            convertedNumber += 32;
            convertedNumber = Math.Round(convertedNumber, 2);

            Console.WriteLine(" ------------------- \n");
            string answer = temp + "°C = " + convertedNumber + "K";
            Console.WriteLine(answer);
            Return();

        }

        public void FToC()
        {
            Console.WriteLine(">> | Temperature Converter | <<\n");
            Console.WriteLine("[ 3 ] Fahrenheit to Celsius\n");
            Console.WriteLine("Enter the temperature in Fahrenheit (°F):");
            double temp = Convert.ToInt32(Console.ReadLine());

            double convertedNumber = temp - 32;
            convertedNumber = convertedNumber * 5/9;
            convertedNumber = Math.Round(convertedNumber, 2);

            Console.WriteLine(" ------------------- \n");
            string answer = temp + "°F = " + convertedNumber + "°C";
            Console.WriteLine(answer);
            Return();

        }

        public void FToK()
        {
            Console.WriteLine(">> | Temperature Converter | <<\n");
            Console.WriteLine("[ 4 ] Fahrenheit to Kelvin\n");
            Console.WriteLine("Enter the temperature in Fahrenheit (°F):");
            double temp = Convert.ToInt32(Console.ReadLine());

            double convertedNumber = temp - 32;
            convertedNumber = convertedNumber * 5 / 9;
            convertedNumber += 273.15;
            convertedNumber = Math.Round(convertedNumber, 2);

            Console.WriteLine(" ------------------- \n");
            string answer = temp + "°F = " + convertedNumber + "K";
            Console.WriteLine(answer);
            Return();

        }


        //## Method that gives a small menu on what to do next
        public void Return()
        {
            Console.WriteLine("\n ------------------- \n\n");
            Console.WriteLine("[ 1 ] - Return to Temperature Converter's main menu\n");
            Console.WriteLine("[ 2 ] - Return to main menu\n");
            Console.WriteLine("[ 3 ] - Quit program entirely\n");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Program.ResetScreen(1200);
                    Main();
                    break;
                case "2":
                    Program.ResetScreen(1200);
                    Program.MainMenu();
                    break;
                case "3":
                    Program.ResetScreen(1200);
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
