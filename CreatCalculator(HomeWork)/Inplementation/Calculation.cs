using CreatCalculator_HomeWork_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreatCalculator_HomeWork_.Inplementation
{
    public class Calculation : ICalculation
    {
        



        public void Calculator(int num1, int num2, string operation)
        {
            if (operation == "+")
            {
                Console.WriteLine(num1+num2);
            }

            if (operation == "/")
            {
                Console.WriteLine(num1/num2);
            }
            if (operation == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            if (operation == "*")
            {
                Console.WriteLine(num1*num2);
            }
        }

         
    }
    
}
