using System;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double addend)
        {
            double result = Accumulator + addend;
            Accumulator = result;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator= a - b;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            double result = Accumulator - subtractor;
            Accumulator = result;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            double result = Accumulator * multiplier;
            Accumulator = result;
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Power(double exponent)
        {
            double result = Math.Pow(Accumulator, exponent);
            Accumulator = result;
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            Accumulator = a / b;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            double result = Accumulator / divisor;
            Accumulator = result;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }

}
