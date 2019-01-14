using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadLine();

            //string hello = "Hello";

            //Console.WriteLine(hello + " World");
            //Console.ReadLine();

            //string firstName = "Thomas";
            //string lastName = "Edison";

            //Console.WriteLine(firstName + " " + lastName);
            //Console.ReadLine();

            //Console.WriteLine($"{hello} {firstName} {lastName}");
            //Console.ReadLine();

            //string greeting = hello + " " + firstName + " " + lastName;

            //Console.WriteLine(greeting);
            //Console.ReadLine();

            //Console.WriteLine("What is your age?");
            //string age = Console.ReadLine();

            //Console.WriteLine($"{hello}, {firstName} {lastName}. You are {age} years old.");
            //Console.ReadLine();

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Your full name is " + firstName + " " + lastName);
            Console.ReadLine();

        }
    }
}
