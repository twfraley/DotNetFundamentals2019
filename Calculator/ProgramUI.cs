using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ProgramUI
    {
        public void Run()
        {
            bool endProgram = false;

            while (!endProgram)
            {
                Console.WriteLine("Welcome to calculator.  What would you like to do?");
                Console.WriteLine("type 'Add,' 'Subtract,' 'Multiply,' or 'Divide'");

                string whatCalculation = Console.ReadLine().ToLower();

                if (whatCalculation == "add")
                {
                    bool correctInput = false;
                    bool correctInputTwo = false;

                    float firstAddend = 0;
                    float secondAddend = 0;

                    while (!correctInput || !correctInputTwo)
                    {
                        Console.WriteLine("What is the first number you would like to add?");
                        string firstAddendString = Console.ReadLine();
                        Console.WriteLine($"What number would you like to add to {firstAddendString}?");
                        string secondAddendString = Console.ReadLine();

                        correctInput = float.TryParse(firstAddendString, out firstAddend);
                        correctInputTwo = float.TryParse(secondAddendString, out secondAddend);

                        while (!correctInput || !correctInputTwo)
                        {
                            Console.WriteLine("That isn't a number I can understand.  Please try again. \n");
                            break;
                        }

                    }

                    CalculatorRepository calcRepo = new CalculatorRepository();

                    float actualValue = calcRepo.AddTwoNumbers(firstAddend, secondAddend);

                    Console.WriteLine($"{firstAddend} + {secondAddend} = {actualValue}.");
                }
                else if (whatCalculation == "subtract")
                {
                    bool correctInput = false;
                    bool correctInputTwo = false;

                    float subtrahend = 0;
                    float minuend = 0;

                    while (!correctInput || !correctInputTwo)
                    {
                        Console.WriteLine("What number would you like to subtract from?");
                        string subtrahendString = Console.ReadLine();
                        Console.WriteLine($"What number would you like to subtract from {subtrahendString}?");
                        string minuendString = Console.ReadLine();

                        correctInput = float.TryParse(subtrahendString, out subtrahend);
                        correctInputTwo = float.TryParse(minuendString, out minuend);

                        while (!correctInput || !correctInputTwo)
                        {
                            Console.WriteLine("That isn't a number I can understand.  Please try again. \n");
                            break;
                        }
                    }
                    CalculatorRepository calcRepo = new CalculatorRepository();

                    float actualValue = calcRepo.SubtractTwoNumbers(subtrahend, minuend);

                    Console.WriteLine($"{subtrahend} - {minuend} = {actualValue}.");
                }
                else if (whatCalculation == "multiply")
                {
                    bool correctInput = false;
                    bool correctInputTwo = false;

                    float firstFactor = 0;
                    float secondFactor = 0;

                    while (!correctInput || !correctInputTwo)
                    {
                        Console.WriteLine("What is the first number you would like to multiply?");
                        string firstFactorString = Console.ReadLine();
                        Console.WriteLine($"What number would you like to multiply with {firstFactorString}?");
                        string secondFactorString = Console.ReadLine();

                        correctInput = float.TryParse(firstFactorString, out firstFactor);
                        correctInputTwo = float.TryParse(secondFactorString, out secondFactor);

                        while (!correctInput || !correctInputTwo)
                        {
                            Console.WriteLine("That isn't a number I can understand.  Please try again. \n");
                            break;
                        }
                    }
                    CalculatorRepository calcRepo = new CalculatorRepository();

                    float actualValue = calcRepo.MultiplyTwoNumbers(firstFactor, secondFactor);

                    Console.WriteLine($"{firstFactor} * {secondFactor} = {actualValue}.");
                }
                else if (whatCalculation == "divide")
                {
                    bool correctInput = false;
                    bool correctInputTwo = false;

                    decimal dividend = 0;
                    decimal divisor = 0;

                    while (!correctInput || !correctInputTwo)
                    {
                        Console.WriteLine("What number would you like to divide from?");
                        string dividendString = Console.ReadLine();
                        Console.WriteLine($"What number would you like to divide into {dividendString}?");
                        string divisorString = Console.ReadLine();

                        correctInput = Decimal.TryParse(dividendString, out dividend);
                        correctInputTwo = Decimal.TryParse(divisorString, out divisor);

                        while (!correctInput || !correctInputTwo)
                        {
                            Console.WriteLine("That isn't a number I can understand.  Please try again. \n");
                            break;
                        }
                    }

                    CalculatorRepository calcRepo = new CalculatorRepository();

                    decimal actualValue = calcRepo.DivideTwoNumbers(dividend, divisor);

                    Console.WriteLine($"{dividend} / {divisor} = {actualValue}.");
                }
                else
                {
                    Console.WriteLine("I don't understand what operation you want to do.");
                    Console.WriteLine("Please try again:");
                }

                Console.WriteLine("Would you like to do more math? Y/N");
                string restart = Console.ReadLine().ToLower();

                if (restart == "y")
                {
                    endProgram = false;
                    Console.Clear();
                }
                else
                {
                    endProgram = true;
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey();
                }
            }
        }
    }
}