using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Apps.GradeCalculator
{
    internal class GradeCalculator
    {
        public void Main()
        {
            Console.WriteLine(" >> | Grade Calculator | <<\n");

            // Intro
            Console.WriteLine(" Welcome to the Grade Calulator!\n ");

            // Saving the student's name
            Console.WriteLine(" Before we start, please enter your name:\n");
            string studentName = Console.ReadLine();

            Console.WriteLine(" Here are the calculator's options:\n");

            // The options
            string[] operationsChoices = { "Add one subject then see grade", "Add subjects then see overall grade", "Back to main menu" };
            for (int i = 0; i < operationsChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($" [ {num} ] {operationsChoices[i]}\n");
            }
            Console.WriteLine("\nPick an option:");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("\nLoading. . .");
                Program.ResetScreen(1200);
                SingleGrade(studentName);
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

        public void SingleGrade(string studentName)
        {
            Console.WriteLine(">> | Grade Calculator | <<\n");
            Console.WriteLine("[ 1 ] Add one subject then see grade\n");
            Console.WriteLine($"Hello {studentName}! You chose the option to see your final grade for a chosen subject!\n");
            Console.WriteLine("Please answer the following:\n");

            // The questions
            Console.WriteLine("Enter the subject's name:");
            string subject = Console.ReadLine();
            Console.WriteLine("\nEnter the subject grade percentage, in 2 decimal places:");
            double percentage = Convert.ToDouble(Console.ReadLine());

            // The calculation
            if (percentage > 0)
            {
                Console.WriteLine("Enter the subject's name:");
            }


        }


        #region Other Methods
        public void Return()
        {
            Console.WriteLine("\n ------------------- \n\n");
            Console.WriteLine(" [ 1 ] - Return to Interest Calculator's main menu\n");
            Console.WriteLine(" [ 2 ] - Return to main menu\n");
            Console.WriteLine(" [ 3 ] - Quit program entirely\n");

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
        #endregion
    }
}
