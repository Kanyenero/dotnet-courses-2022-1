using NUnit.Framework;
using Euclidean.Math;

namespace Euclidean.Math.Tests
{
    [TestFixture]
    public class MathTests
    {
        [TestCase(10, 10, ExpectedResult = 10)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(10, 5, ExpectedResult = 5)]
        public int TestCalculateGCD_TwoNumbers_Success(int num1, int num2)
        {
            return Arithmetic.CalculateGCD(num1, num2);
        }

        [TestCase(10, 10, 10, ExpectedResult = 10)]
        [TestCase(2, 6, 12, ExpectedResult = 2)]
        [TestCase(12, 6, 2, ExpectedResult = 2)]
        public int TestCalculateGCD_ThreeNumbers_Success(int num1, int num2, int num3)
        {
            return Arithmetic.CalculateGCD(num1, num2, num3);
        }

        [TestCase(10, 10, 10, 10, ExpectedResult = 10)]
        [TestCase(2, 4, 6, 10, ExpectedResult = 2)]
        [TestCase(10, 6, 4, 2, ExpectedResult = 2)]
        public int TestCalculateGCD_FourNumbers_Success(int num1, int num2, int num3, int num4)
        {
            return Arithmetic.CalculateGCD(num1, num2, num3, num4);
        }

        [TestCase(2,4,6,8,10,12,14,16,18,20,22,24,26,28,30, ExpectedResult = 2)]
        public int TestCalculateGCD_AnyNumberOfNumbers_Success(params int[] numbers)
        {
            return Arithmetic.CalculateGCD(numbers);
        }

        [TestCase(10, 10, 10, 10, 10, ExpectedResult = 10)]
        public int TestCalculateGCD_FiveNumbers_Success(int num1, int num2, int num3, int num4, int num5)
        {
            return Arithmetic.CalculateGCD(num1, num2, num3, num4, num5);
        }

        [TestCase(-10, 10, ExpectedResult = 10)]
        [TestCase(10, -10, ExpectedResult = 10)]
        public int TestCalculateGCD_NegativeNumber_Success(int num1, int num2)
        {
            return Arithmetic.CalculateGCD(num1, num2);
        }

        [TestCase(10, 10, ExpectedResult = 10)]
        [TestCase(11, 11, ExpectedResult = 11)]
        public int TestCalculateGCD_EvenOddNumber_Success(int num1, int num2)
        {
            return Arithmetic.CalculateGCD(num1, num2);
        }

        [TestCase(int.MaxValue, int.MaxValue, ExpectedResult = int.MaxValue)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int TestCalculateGCD_PositiveBorderCondition_Success(int num1, int num2)
        {
            return Arithmetic.CalculateGCD(num1, num2);
        }

        [TestCase(int.MinValue, int.MaxValue)]
        [TestCase(int.MinValue, int.MinValue)]
        public void TestCalculateGCD_NegativeBorderCondition_ThrowsException(int num1, int num2)
        {
            Assert.Throws<OverflowException>(delegate { Arithmetic.CalculateGCD(num1, num2); });
        }

        [TestCase(2, 3, 5, 7, 11, ExpectedResult = 1)]
        public int TestCalculateGCD_PrimeNumbers_Success(int num1, int num2, int num3, int num4, int num5)
        {
            return Arithmetic.CalculateGCD(num1, num2);
        }
    }
}