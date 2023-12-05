using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string firstName = "John";
            int age = 10;

            // Display information
            Console.WriteLine("Hi " + firstName + ", you are " + age);

            // Update variables
            firstName = "Noma";
            age = 90;

            // Display updated information
            Console.WriteLine("Hi " + firstName + ", you are " + age);

            // Declare and initialize another variable
            string lastName = "Thomas";

            // Display combined information
            Console.WriteLine("Hi " + firstName + " " + lastName + ", you are " + age);

            // Freeze console
            Console.ReadLine();
        }
    }
}
