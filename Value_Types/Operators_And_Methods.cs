using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void UsingOperators()
        {
            int number = 10;
            int numberTwo = 10;

            int c = number + numberTwo;
            Assert.AreEqual(20, c);

            int numberThree = 1;
            int numberFour = 2;

            Assert.AreNotEqual(numberThree, numberFour);

            int numberFive = numberFour - numberThree;
            Assert.AreEqual(1, numberFive);

            int g = number % numberTwo;
            Assert.AreEqual(0, g);
        }

        [TestMethod]
        public void UsingAMethod()
        {
            int a = 12;
            int b = 300;

            int c = AddTwoNumbers(a,b);
            Assert.AreEqual(312, c);

            int d = SubtractTwoNumbers(b, a);
            Assert.AreEqual(288, d);

            int e = MultiplyTwoNumbers(a, b);
            Assert.AreEqual(3600, e);

            int f = DivideTwoNumbers(b, a);
            Assert.AreEqual(25, f);
        }

        private int AddTwoNumbers(int kung, int fu)
        {
            int kungFu = kung + fu;
            return kungFu;
        }

        private int SubtractTwoNumbers(int kung, int fu)
        {
            int kungFu = kung - fu;
            return kungFu;
        }

        private int MultiplyTwoNumbers(int kung, int fu)
        {
            int kungFu = kung * fu;
            return kungFu;
        }
        
        private int DivideTwoNumbers(int kung, int fu)
        {
            int kungFu = kung / fu;
            return kungFu;
        }
    }
}
