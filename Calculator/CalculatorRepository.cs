using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorRepository
    {
        //Write a method that adds
        public float AddTwoNumbers(float kung, float fu)
        {
            float kungFu = kung + fu;
            return kungFu;
        }
        
        //Write a method that subtracts
        public float SubtractTwoNumbers(float ping, float pong)
        {
            float pingPong = ping - pong;
            return pingPong;
        }
        
        //Write a method that multiplies
        public float MultiplyTwoNumbers(float multi, float ply)
        {
            float multiply = multi * ply;
            return multiply;
        }
        
        //Write a method that divides
        public decimal DivideTwoNumbers(decimal div, decimal ide)
        {
            decimal divide = div / ide;
            return divide;
        }
        
    }
}