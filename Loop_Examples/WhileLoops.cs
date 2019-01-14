using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loop_Examples
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Example1()
        {
            // "while" loops

            int i = 1;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++; // i = i + 1;
                // i--; // i = i - 1;
            }
        }

        [TestMethod]
        public void Example2()
        {
            int i = 0;
            while (true)
            {
                if (i < 10)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
