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
            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            //Console.WriteLine($"Hello, {firstName} {lastName}! How old are you?");
            //string age = Console.ReadLine();

            //bool success = Int32.TryParse(age, out int result);
            
            //if (success)
            //{
            //    Convert.ToInt16(age);
            //    Console.WriteLine($"Great!  What is your favorite food?");
            //}
            //else
            //{
            //    Console.WriteLine("Hmm. I don't think that's a real number.  What's your favorite food?");
            //}

            ////Console.WriteLine(result);
            ////Console.ReadLine();

            //string favoriteFood = Console.ReadLine();

            //Console.WriteLine($"Interesting.  Why do you enjoy {favoriteFood}?");
            //string reasonForFavoriteFood = Console.ReadLine();

            //Console.WriteLine("I wish I knew what you were talking about.");
            //Console.WriteLine("Unfortunately I'm only a computer and can't taste things.");
            //Console.WriteLine($"Oh well. Have a great day as a {age} year old! I probably won't murder you in your sleep!");
            //Console.ReadLine();



            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            // "Do... while..." seems promising
            // tryparse, while loops, bang operator - apparently my friends
            int result = 0;

            do
            {
                Console.WriteLine($"Hello, {firstName} {lastName}! How old are you?");
                string age = Console.ReadLine();

                bool success = Int32.TryParse(age, out result);

                if (success)
                {
                    Console.WriteLine($"Great!  What is your favorite food?");
                }
                else
                {
                    Console.WriteLine("Hmm. I don't think that's a real number.  What's your favorite food?");
                }
            } while (result == 0);
            

            //Console.WriteLine(result);
            //Console.ReadLine();

            string favoriteFood = Console.ReadLine();

            Console.WriteLine($"Interesting.  Why do you enjoy {favoriteFood}?");
            string reasonForFavoriteFood = Console.ReadLine();

            Console.WriteLine("I wish I knew what you were talking about.");
            Console.WriteLine("Unfortunately I'm only a computer and can't taste things.");
            Console.WriteLine($"Oh well. Have a great day as a {result} year old! I probably won't murder you in your sleep!");
            Console.ReadLine();

        }
    }
}
