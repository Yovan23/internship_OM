using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------> Find out your age..!");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your DOB (yyyy-mm-dd):");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------> Your details are <-----------------------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine();
        }   
    }
}

