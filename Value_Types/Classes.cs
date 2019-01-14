using DotNet_Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Classes
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Cookies cookie = new Cookies
            {
                Name = "Snickerdoodles",
                GlutenFree = false,
                BatchSize = 24
            };

            Cookies cookieTwo = new Cookies
            {
                Name = "chocolate chip",
                GlutenFree = true,
                BatchSize = 65,
            };



            Assert.AreEqual("Snickerdoodles", cookie.Name);
            Assert.AreEqual(false, cookie.GlutenFree);
            Assert.AreEqual(24, cookie.BatchSize);

            Assert.AreEqual("chocolate chip", cookieTwo.Name);
            Assert.AreEqual(true, cookieTwo.GlutenFree);
            Assert.AreEqual(65, cookieTwo.BatchSize);
        }

        [TestMethod]
        public void MyTestMethodTwo()
        {
            Cookies cookie = new Cookies();
            cookie.Name = "Snickerdoodles";
            cookie.GlutenFree = false;
            cookie.BatchSize = 24;

            Assert.AreEqual("Snickerdoodles", cookie.Name);
            Assert.AreEqual(false, cookie.GlutenFree);
            Assert.AreEqual(24, cookie.BatchSize);
        }
    }
}
