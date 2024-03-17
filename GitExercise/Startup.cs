using System;

namespace GitExercise
{
    public class Startup
    {
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain access: ");
            return Console.ReadLine() == "abcd1234";
        }

        public static void Main()
        {
            if (!CheckCredentials())
            {
                Console.WriteLine("Access denied.");
                Console.ReadKey(true);
                return;
            }
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }

                Console.Write("Option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Subtract(a, b);
                        break;
                    case "m":
                        OptionsManager.Multiply(a, b);
                        break;
                    case "d":
                        OptionsManager.Divide(a, b);
                        break;
                    case "sabs":
                        OptionsManager.SubtractABS(a, b);
                        break;
                    case "exit":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey(true);
                        return;
                    case "pow":
                        OptionsManager.Power(a, b);
                        break;
                    case "log":
                        OptionsManager.Log(a, b);
                        break;
                    case "fact":
                        OptionsManager.Factorial((int)a, (int)b);
                        break;

                }
                Console.WriteLine("Pres any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
