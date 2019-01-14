using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void Calculator_AddTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            //The following code tells the program that it is a
            // new value USING the CalculatorRepository.
            // This value is stored in RAM until overwritten by other "new"s

            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.AddTwoNumbers(3, 4);
            int expected = 7;

            //Assert
            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_SubtractTwoNumbers_ShouldBeCorrectValue()
        {
            // because the below code is in a new bracket thing, 
            // I can reuse variable names (calcRepo, actualValue, expected, etc)

            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValue = calcRepo.SubtractTwoNumbers(4, 3);
            int expected = 1;

            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_MultiplyTwoNumbers_ShouldBeCorrectValue()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValue = calcRepo.MultiplyTwoNumbers(4, 3);
            int expected = 12;

            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_DivideTwoNumbers_ShouldBeCorrectValue()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();

            int actualValue = calcRepo.DivideTwoNumbers(12, 3);
            int expected = 4;

            Assert.AreEqual(expected, actualValue);
        }
    }
}
