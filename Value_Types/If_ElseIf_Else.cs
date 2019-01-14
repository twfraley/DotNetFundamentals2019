using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class If_ElseIf_Else
    {
        [TestMethod]
        public void If_Else()
        {
            //if (1 != 2)
            //{
            //    Console.WriteLine("Duh");
            //}


            DateTime birthday = new DateTime(1989, 01, 23);
            DateTime date = DateTime.Now;

            if(birthday.Month == date.Month && birthday.Day == date.Day)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else
            {
                Console.WriteLine("It's not your birthday, loser.");
            }



            int age = 23;

            if (age < 18)
            {
                Console.WriteLine("You're too young to watch the spongebob movie.");
            }
            else if (age >= 18 && age < 50)
            {
                Console.WriteLine("Congrats.  You are old enough to watch the spongebob movie.");
            }
            else
            {
                Console.WriteLine("You're too old to watch the spongebob movie.");
            }



            bool coder = false;

            if (coder == true)
            {
                Console.WriteLine("You're a coder. Oh good! Can you fix my computer?");
            }
            else
            {
                Console.WriteLine("You're not a coder. Oh dang. Well can you fix my computer anyway?");
            }
        }

        [TestMethod]
        public void Tax_Challenge()
        {
            int a = 450;

            double totalPlusTax = (a * 1.07);

            Assert.AreEqual(481.5, totalPlusTax);
        }
    }
}
