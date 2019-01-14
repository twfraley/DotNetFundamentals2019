using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loop_Examples
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void ExampleOne()
        {
            // for (Start; Condition; What we do between each loop)
            for (int i = 1; i <10; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ExampleTwo()
        {
            // if i is a multiple of 3 write out fizz
            // if i is a multiple of 5 write out buzz
            // if i is a multiple of both write out fizzbuzz
            // if i is none of the above write out the number

            int number = 100;

            for(int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("fizzbuzz");

                else if (i % 3 == 0)
                    Console.WriteLine("fizz");

                else if (i % 5 == 0)
                    Console.WriteLine("buzz");

                else
                    Console.WriteLine(i);
            }

            //Console.ReadLine();
        }

        [TestMethod]
        public void CountNonSpaceChars()
        {
            string myString = "Count the letters that are in the sentence You are doing awesome";
            int counter = 0;
            foreach (char c in myString)
            {
                if (char.IsLetter(c))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
