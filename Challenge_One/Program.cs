using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}! How old are you?");
            string age = Console.ReadLine();
            Convert.ToInt16(age);

            Console.WriteLine($"Great!  What is your favorite food?");
            string favoriteFood = Console.ReadLine();

            Console.WriteLine($"Interesting.  Why do you enjoy {favoriteFood}?");
            string reasonForFavoriteFood = Console.ReadLine();

            Console.WriteLine("I wish I knew what you were talking about.");
            Console.WriteLine("Unfortunately I'm only a computer and can't taste things.");
            Console.WriteLine($"Oh well. Have a great day as a {age} year old! I probably won't murder you in your sleep!");
            Console.ReadLine();
        }
    }
}
