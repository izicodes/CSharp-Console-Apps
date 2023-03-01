using System.Threading;
class Program
{

    string[] programs = { "HelloWorld", "Calculator", "TemperatureConverter", "InterestCalculator", "GradeCalculator", "ArraySumCalculator" };

    static void Main(string[] args)
    {
        MainMenu();
    }

    private static void MainMenu()
    {
        IntroductionPart();

        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("\nPick a program option:");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > 6)
            {
                Console.WriteLine("\nPlease pick a number from the list above.");
                Thread.Sleep(1500);
                Console.Clear();
                MainMenu();
                return;
            }
            else if (choice == 1){
                Console.WriteLine("\nHello!");
                continueLoop = false;
            }
        }






    }

    private static void IntroductionPart()
    {
        Console.WriteLine(">> | MAIN MENU | <<\n");
        Console.WriteLine("Hello and welcome to XiaCodes' C# Console Applications Collection!");
        Console.WriteLine("Here are the available programs: \n");

        string[] programs = { "HelloWorld", "Calculator", "TemperatureConverter", "InterestCalculator", "GradeCalculator", "ArraySumCalculator" };
        for (int i = 0; i < programs.Length; i++)
        {
            int num = i + 1;
            Console.WriteLine($"[ {num} ] {programs[i]}\n");
        }
    }
}