// Programmer: Ashley Hills
// Project: Tech Project 3a
// Date: 09/24/2020
// Description: A console program that demonstrates the use of a Method that prints to the Console:  "Hello user's name" using the users real name
using System;

namespace Tech_Project_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNameMethod();

            Console.ReadKey(true);
        }
        private static void GetNameMethod()
        {
            Console.WriteLine("Please enter your full Name: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("INVALID INPUT! Please enter your first and last name, CANNOT BE LEFT BLANK!");
                Console.WriteLine("Please exit the program and try again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            else
            {

                Console.WriteLine("Hello " + input + " - Go Bulls!");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);

            }
        }
    }
}
