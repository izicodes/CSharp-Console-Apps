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
            Console.WriteLine(">> | Grade Calculator | <<\n");

            // Intro
            Console.WriteLine("Welcome to the Grade Calulator!\n ");

            // Saving the student's name
            Console.WriteLine("Before we start, please enter your name:\n");
            string studentName = Console.ReadLine();

            Console.WriteLine("\n-------------\n");

            Console.WriteLine("Here are the calculator's options:\n");

            // The options
            string[] operationsChoices = { "Add one subject then see the letter grade", "Add subjects then see overall letter grade", "Back to main menu" };
            for (int i = 0; i < operationsChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($"[ {num} ] {operationsChoices[i]}\n");
            }

            Console.WriteLine("-------------\n");

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
            Console.WriteLine("[ 1 ] Add one subject then see the letter grade\n");
            Console.WriteLine($"Hello {studentName}! You chose the option to see your final grade for a chosen subject!\n");
            Console.WriteLine("Please answer the following.\n");

            // The questions
            Console.WriteLine("Enter the subject's name:");
            string subject = Console.ReadLine();
            Console.WriteLine("\nEnter the subject grade percentage, in 2 decimal places:");
            double percentage = Convert.ToDouble(Console.ReadLine());

            // Start of the answers
            Console.WriteLine("\n\n\n-------------");
            Console.WriteLine($"Student Name: {studentName}\n");
            Console.WriteLine($"Subject: {subject}\n");
            Console.WriteLine($"Percentage Grade: {percentage}\n");

            // The calculation
            if (percentage > 90 && percentage < 100)
            {
                Console.WriteLine("Overall grade: A\n");

                Console.WriteLine("*Notes: \nCongratulations! You've done excellent work and should be proud of your accomplishments.\n");
                Return();
            } 
            else if (percentage > 80 && percentage < 89)
            {
                Console.WriteLine("Overall grade: B\n");

                Console.WriteLine("*Notes: \nGood job! You've demonstrated a solid understanding of the material and have shown consistent effort.\n");
                Return();
            }
            else if (percentage > 70 && percentage < 79)
            {
                Console.WriteLine("Overall grade: C\n");

                Console.WriteLine("*Notes: \nKeep up the good work! You've met the requirements for the course and have shown a satisfactory understanding of the material.\n");
                Return();
            }
            else if (percentage > 60 && percentage < 69)
            {
                Console.WriteLine("Overall grade: D\n");

                Console.WriteLine("*Notes: \nKYou've passed the course, but there is room for improvement. \nConsider seeking extra help or reviewing the material more thoroughly.\n");
                Return();
            }
            else if (percentage <= 59)
            {
                Console.WriteLine("Overall grade: F\n");

                Console.WriteLine("*Notes: \nUnfortunately, you have not met the requirements for passing the course. \nPlease speak with me to discuss your options moving forward.\n");
                Return();
            }

        }


        #region Other Methods
        public void Return()
        {
            Console.WriteLine("\n ------------------- \n\n");
            Console.WriteLine(" [ 1 ] - Return to the Grade Calculator's main menu\n");
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
