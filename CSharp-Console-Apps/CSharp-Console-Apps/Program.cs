
class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    private static void MainMenu()
    {
        Console.WriteLine(">> | MAIN MENU | <<\n");
        Console.WriteLine("Hello and welcome to XiaCodes' C# Console Applications Collection!");
        Console.WriteLine("Pick a program option: \n");

        string[] programs = { "HelloWorld", "Calculator", "TemperatureConverter", "InterestCalculator", "GradeCalculator", "ArraySumCalculator" };
        for (int i = 0; i < programs.Length; i++)
        {
            Console.WriteLine($"[ {i} ] {programs[i]}\n");
        }


        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(choice.ToString());



    }
}