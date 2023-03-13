using System.Threading;
using CSharp_Console_Apps.HelloWorld;
using CSharp_Console_Apps.Calculator;
using CSharp_Console_Apps.TemperatureConverter;

class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    public static void MainMenu()
    {
        // #The Different Class Objects
        HelloWorld hw = new HelloWorld();
        Calculator cal = new Calculator();
        TemperatureConverter temp = new TemperatureConverter();

        IntroductionPart();

        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("\nPick a program option:");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > 6)
            {
                Console.WriteLine("\nPlease pick a number from the list above.");
                ResetScreen(1500);
                MainMenu();
                return;
            }

            switch (choice)
            {
                case 1:
                    ResetScreen(1200);
                    continueLoop = false;
                    hw.Main();
                    break;
                case 2:
                    ResetScreen(1200);
                    continueLoop = false;
                    cal.Main();
                    break;
                case 3:
                    ResetScreen(1200);
                    continueLoop = false;
                    temp.Main();
                    break;
            }
        }

    }

    public static void ResetScreen(int seconds)
    {
        Thread.Sleep(seconds);
        Console.Clear();
    }

    // # Intro to the main menu
    public static void IntroductionPart()
    {
        Console.WriteLine(">> | MAIN MENU | <<\n");
        Console.WriteLine("Hello and welcome to XiaCodes' C# Console Applications Collection!");
        Console.WriteLine("Here are the available programs: \n");

        string[] programs = { "Hello World", "Calculator", "Temperature Converter", "Interest Calculator", "Grade Calculator", "Array Sum Calculator", "Exit program" };
        for (int i = 0; i < programs.Length; i++)
        {
            int num = i + 1;
            Console.WriteLine($"[ {num} ] {programs[i]}\n");
        }
    }

    // # After each program, show the options
    public static void EndOfProgram()
    {
        Console.WriteLine("\n ------------------- \n");
        Console.WriteLine("\n[ 1 ] - Return to main menu\n");
        Console.WriteLine("[ 2 ] - Quit program entirely\n");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                ResetScreen(1200);
                MainMenu();
                break;
            case "2":
                ResetScreen(1200);
                Environment.Exit(0);
                break;
        }
    }
}