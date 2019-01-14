using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Reference_Types_And_Collections
    {
        // testm + tab + tab = new test method
        [TestMethod]
        public void ReferenceTypes()
        {
            string hello = "Why are we doing this?";
        }
        [TestMethod]
        public void Collections()
        {
            string[] arrayOfStrings = { "This", " isn't", " helping", " me", " yet." };
            List<string> listOfStrings = new List<string>();
            Queue<string> firstInFirstOut = new Queue<string>();
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();

        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
