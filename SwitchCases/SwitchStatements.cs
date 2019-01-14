using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCases
{
    public enum GenderType { male, female, undeclared }

    class SwitchStatements
    {
        public void SwitchAndEnum()
        {
            string lastName = "Wagner";
            string firstName = "Kate";
            GenderType gender = GenderType.female;
            switch (gender)
            {
                case GenderType.male:
                    Console.WriteLine($"Welcome, Mr. {lastName}.");
                    break;
                case GenderType.female:
                    Console.WriteLine($"Welcome, Mrs. {lastName}.");
                    break;
                case GenderType.undeclared:
                    Console.WriteLine($"Welcome {firstName} {lastName}.");
                    break;
            }
        }
    }
}
