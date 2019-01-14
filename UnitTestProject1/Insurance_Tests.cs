using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Insurance;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for InsuranceTests
    /// </summary>
    [TestClass]
    public class Insurance_Tests
    {
        [TestMethod]
        public void InsuranceTests_AddingContent_ShouldBeCorrect()
        {
            //Arrange
            Car carOne = new Car
            {
                BrandOfCar = "Autobots",
                ModelOfCar = "Camero",
                YearOfCar = 1984,
                TypeOfCar = "car",
                ColorOfCar = "yellow",
                NumberOfWheels = 4,
                BeenInAccident = true,
                NumberOfOwners = 0,
            };

            Car carTwo = new Car("Ford", "Pinto", 1986, "car", "rust", 3, true, 1);

            //Act

            // ? Don't need to act on this one, I guess.

            //Assert
            Assert.AreEqual("Autobots", carOne.BrandOfCar);
            Assert.AreEqual("yellow", carOne.ColorOfCar);
            Assert.AreEqual("3", carTwo.NumberOfWheels);
            Assert.AreEqual("Ford", carTwo.BrandOfCar);

        }

        [TestMethod]
        public void InsuranceTests_InsuranceCalculation1989_ShouldBeCorrect()
        {
            CarContentRepository insuranceRepo = new CarContentRepository();

            decimal actualValue = insuranceRepo.InsuranceCost(1989);
            decimal expected = 150m;

            Assert.AreEqual(expected,actualValue);
        }

        [TestMethod]
        public void InsuranceTests_InsuranceCalculation1950_ShouldBeCorrect()
        {
            CarContentRepository insuranceRepo = new CarContentRepository();

            decimal actualValue = insuranceRepo.InsuranceCost(1950);
            decimal expected = 2000m;

            Assert.AreEqual(expected, actualValue);
        }


        [TestMethod]
        public void InsuranceTests_AddCarToList_ShouldBeCorrect()
        {

            // next code is to add cars to the list "Car"
            // that we made in CarContent.cs
            // We are doing this by calling up our AddContentToList method
            // that we made in CarContentRepository.cs

            Car pinto = new Car("Ford", "Pinto", 1986, "car", "rust", 3, true, 1);
            Car explorer = new Car("Ford", "Explorer", 1996, "SUV", "black", 4, false, 2);
            CarContentRepository repo = new CarContentRepository();

            repo.AddContentToList(pinto);
            repo.AddContentToList(explorer);

            int actual = repo.GetContentFromList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        
    }
}
