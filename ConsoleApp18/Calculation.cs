using System;
using System.Collections.Generic;


namespace ConsoleApp18
{
    public class Calculation : ICalculation
    {
        public double Bolme(double x, double y)
        {
            return x / y;
        }

        public double Chixmaq(double x, double y)
        {
            return x - y;
        }

        public double Toplama(double x, double y)
        {
            return x + y;
        }

        public double Vurma(double x, double y)
        {
            return x * y;
        }
    }
}
