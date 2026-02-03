using System;

namespace TempDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Fahrenheit: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            if (input >= 0 && input <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Freezing Weather");
            }
            else if (input >= 11 && input <= 21)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Very Cold Weather");
            }
            else if (input >= 21 && input <= 35)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Cold Weather");
            }
            
            else if (input >= 36 && input <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Normal in Temp");
            }
            
            else if (input >= 51 && input <= 65) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Its Hot");
            }
            else if (input >= 66 && input <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Its Very Hot");
            }
            else if  (input > 80)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Its Extremely Hot");
            }
            Console.ResetColor();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
