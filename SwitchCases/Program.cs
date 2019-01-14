using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCases
{
    class Program
    {
        public enum Color { Red, Green, Blue}

        static void Main(string[] args)
        {
            //ask user 1-5 how they're feeling; provide feedback depending on their feedback

            Console.WriteLine("How are you feeling today on a scale from 1-5?");
            string howIFeel = Console.ReadLine();
            int feeling = int.Parse(howIFeel);


            if (feeling == 1)
            {
                Console.WriteLine("too bad");
            }
            else if (feeling == 2)
            {
                Console.WriteLine("meh");
            }
            else if (feeling == 3)
            {
                Console.WriteLine("cool");
            }
            else if (feeling == 4)
            {
                Console.WriteLine("great");
            }
            else if (feeling == 5)
            {
                Console.WriteLine("stupendous");
            }
            else
            {
                Console.WriteLine("you didn't read the instructions");
            }



            switch (feeling)
            {
                case 1:
                    Console.WriteLine("too bad");
                    break;
                case 2:
                    Console.WriteLine("meh");
                    break;
                case 3:
                    Console.WriteLine("cool");
                    break;
                case 4:
                    Console.WriteLine("great");
                    break;
                case 5:
                    Console.WriteLine("stupendous");
                    break;
                default:
                    Console.WriteLine("You didn't read the instructions.");
                    break;
            }


            Console.ReadLine();



            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown");
                    break;
            }



            string lastName = "Wagner";
            string firstName = "Kate";
            GenderType gender = GenderType.female;

            switch (gender)
            {
                case GenderType.male:
                    Console.WriteLine($"Welcome, Mr. {lastName}.");
                    break;
                case GenderType.female:
                    Console.WriteLine($"Welcome, Mrs. {lastName}.");
                    break;
                case GenderType.undeclared:
                    Console.WriteLine($"Welcome {firstName} {lastName}.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
