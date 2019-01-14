using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThanksgivingConsole;

namespace Value_Types
{
    [TestClass]
    public class Thanksgiving_Tests
    {
        [TestMethod]
        public void ThanksgivingTest_SetTurkey_ShouldBeCorrect()
        {
            //--Arrange
            Thanksgiving dinner = new Thanksgiving("turkey",true,4,true);

            //--Act
            string actualTurkey = dinner.MainCourse;
            bool actualMashedPotatoes = dinner.MashedPotatoes;
            int actualSideDishes = dinner.NumberOfSideDishes;
            bool actualPilgrimHats = dinner.PilgrimHats;

            string expectedTurkey = "turkey";
            bool expectedMashedPotatoes = true;
            int expectedSideDishes = 4;
            bool expectedPilgrimHats = true;

            //--Assert
            Assert.AreEqual(actualTurkey, expectedTurkey);
            Assert.AreEqual(actualMashedPotatoes, expectedMashedPotatoes);
            Assert.AreEqual(actualSideDishes, expectedSideDishes);
            Assert.AreEqual(actualPilgrimHats, expectedPilgrimHats);

        }
    }
}