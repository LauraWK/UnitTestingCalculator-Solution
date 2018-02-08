using System;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }
        private double result;
        public double Add(double a, double b)
        {
            result = a + b;
            return result;
        }

        public double Subtract(double a, double b)
        {
            result= a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            result = a * b;
            return result;
        }

        public double Power(double a, double b)
        {
            result = Math.Pow(a, b);
            return result;
        }

        public double Accumulat()
        {
            return result;
        }

        public double Divide(double a, double b)
        {
            result= a / b;
            return result;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }

}
