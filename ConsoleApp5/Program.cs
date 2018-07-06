using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Do you have any DUIs? true or false");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets?");
            byte speeding = byte.Parse(Console.ReadLine());
            person driver = new person(age, dui, speeding);
            driver.CanGetInsurance();
            Console.ReadLine();
        }
    }
}
