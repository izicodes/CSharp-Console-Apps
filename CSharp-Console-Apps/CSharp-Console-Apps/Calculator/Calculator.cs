using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Apps.Calculator
{
    public class Calculator
    {
        public void Main()
        {
            Console.WriteLine(">> | Calculator | <<\n");

            // Intro
            Console.WriteLine("This calculator console app can do: \n");
            

            // The options
            string[] operationsChoices = { "Addition", "Subtraction", "Multiplication", "Division", "Back to main menu"};
            for (int i = 0; i < operationsChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($"[ {num} ] {operationsChoices[i]}\n");
            }
            Console.WriteLine("\nPick a basic arithmetic operation:");
            int choice = Convert.ToInt32(Console.ReadLine());
            

            if (choice == 1)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                Addition();
            } 
            else if (choice == 2)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                Subtraction();
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                Multiply();
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                Division();
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

        public void Addition()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 1 ] Addition\n");
            Console.WriteLine("How many numbers do you want to add together?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 0;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score += number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " + ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

            Return();
        }

        public void Subtraction()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 2 ] Subtraction\n");
            Console.WriteLine("How many numbers do you want to subtract from each other?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 0;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score -= number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " - ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

            Return();

        }

        public void Multiply()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 3 ] Multiplication\n");
            Console.WriteLine("How many numbers do you want to multiply together?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 1;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score *= number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " × ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

            Return();

        }

        public void Division()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 4 ] Division\n");
            Console.WriteLine("How many numbers do you want to be divided from each other?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 1;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score /= number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " ÷ ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

            Return();

        }

        public void Return()
        {
            Console.WriteLine("\n ------------------- \n\n");
            Console.WriteLine("[ 1 ] - Return to Calculator's main menu\n");
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
