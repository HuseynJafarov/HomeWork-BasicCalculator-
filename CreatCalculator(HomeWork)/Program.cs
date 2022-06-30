using CreatCalculator_HomeWork_.Inplementation;
using CreatCalculator_HomeWork_.Interfaces;
using System;

namespace CreatCalculator_HomeWork_
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculation Calculation;
            Calculation = new Calculation();
            Calculation.Calculator(5,10,"+");

        }
    }
}
