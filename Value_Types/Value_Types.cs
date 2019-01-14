using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Value_Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            // Char = one character
            char c = '$';

            // Bool = true/false
            bool b = true;

            // Byte = whole number btwn 0-255
            byte by = 255;

            // Short = whole number
            short sh = 32000;

            //Long = 64 bit number
            long lg = 98787;

            // Integer = whole number between min and max
            int intMin = -2147483648;
            int intMax = 2147483647;

            // Float = takes less space than decimal
            float floatExample = 1.978f;

            // Double = can include decimal point
            double doubleExample = 0.9998d;

            // Decimal = big huge numbers; can include decimal point
            decimal decimalExample = 9.8989m;

            // DateTime gives you two options to generate dates:
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1989, 1, 1);
        }

        [TestMethod]
        public void Declaration()
        {
            string garbage;
            int integerOne;
            double doubleDown;
            bool yes;
            bool no;
            decimal moneyMoneyMoney;
            short stop;

        }
        [TestMethod]
        public void DeclarationThenInitialization()
        {
            string garbage;
            int integerOne;
            double doubleDown;
            bool yes;
            bool no;
            decimal moneyMoneyMoney;
            short stop;

            garbage = "Yay garbage truck!";
            integerOne = 34092823;
            doubleDown = 356d;
            yes = false;
            no = false;
            moneyMoneyMoney = 20000000000000.00m;
            stop = 12;
        }
        [TestMethod]
        public void DeclarationAndInitialization()
        {
            string garbage = "Yay garbage truck!";
            int integerOne = 2452823;
            double doubleDown = 356d;
            bool yes = false;
            bool no = false;
            decimal moneyMoneyMoney = 20000000000000.00m;
            short stop = 12;
        }
    }
}