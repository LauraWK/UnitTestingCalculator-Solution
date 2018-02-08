using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }



        [TestCase(4,2,2)]
        [TestCase(9,3,3)]
        [TestCase(20,5,4)]
        public void Divide_DivideNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a,b),Is.EqualTo(result));
        }

        [TestCase(2, 2, 4)]
        [TestCase(3, 5, 8)]
        [TestCase(4, 7, 11)]
        public void Accumulator_Add_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator,Is.EqualTo(result));
        }

        [TestCase(4, 2, 2)]
        [TestCase(5, 2, 3)]
        [TestCase(12, 2, 10)]
        public void Accumulator_Sub_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Subtract(a,b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(4, 3, 12)]
        [TestCase(2, 3, 6)]
        [TestCase(5, 2, 10)]
        public void Accumulator_Multi_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Multiply(a, b);
            Assert.That(_uut.Accumulator,Is.EqualTo(result));
        }

        [TestCase(5, 2, 25)]
        [TestCase(4, 2, 16)]
        [TestCase(3, 2, 9)]
        public void Accumulator_Pow_ResultIsCorrect(double x, double exp, double result)
        {
            _uut.Power(x, exp);
            Assert.That(_uut.Accumulator,Is.EqualTo(result));
        }

        [TestCase(10, 2, 7)]
        [TestCase(4, 2, 2)]
        [TestCase(20, 2, 10)]
        public void Accumulator_Div_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Divide(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [Test]
        public void Accumulator_newAdd_resultIsCorrect()
        {
            _uut.Add(4, 5);
            Assert.That(_uut.Add(6),Is.EqualTo(15));
        }

        [Test]
        public void Accumulaor_newSubtract_resultIsCorrect()
        {
            _uut.Subtract(8, 3);
            Assert.That(_uut.Subtract(2),Is.EqualTo(3));
        }

        [Test]
        public void Accumulator_newMultiply()
        {
            _uut.Multiply(3, 5);
            Assert.That(_uut.Multiply(4),Is.EqualTo(60));
        }

        [Test]
        public void Accumulator_NewRaiseNumbers()
        {
            _uut.Power(3, 2);
            Assert.That(_uut.Power(3),Is.EqualTo(729));
        }

        [Test]
        public void Accumulator_NewDivide()
        {
            _uut.Divide(20,5);
            Assert.That(_uut.Divide(2),Is.EqualTo(2));
        }
    }
}
