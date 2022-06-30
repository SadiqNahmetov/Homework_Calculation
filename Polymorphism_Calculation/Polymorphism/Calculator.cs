using Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Calculator : ICalculation
    {
        public int number1;
        public int number2;
        public string operation;

        public void CalculatorS(int num1, int num2, string operate)
        {
            number1 = num1;
            number2 = num2;
            operation = operate;
            {
                if (operate == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (operate == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (operate == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (operate == "*")
                {
                    Console.WriteLine(num1 * num2);
                }

            }
        }
    }
}

