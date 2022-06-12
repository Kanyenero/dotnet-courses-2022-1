using NUnit.Framework;
using PolynomialLib;

namespace PolynomialTests
{
    [TestFixture]
    public class PolynomialTests
    {
        [TestCaseSource("PolynomialAddCase")]
        public void Polynomial_AddCase_Success(Polynomial p1, Polynomial p2, Polynomial expectedResult)
        {
            var actualResult = p1 + p2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> PolynomialAddCase()
        {
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1, 1), new Polynomial(2, 2, 2));
            yield return new TestCaseData(new Polynomial(0, 0, 0), new Polynomial(0, 0, 0), new Polynomial(0, 0, 0));
            yield return new TestCaseData(new Polynomial(-1, -1, -1), new Polynomial(-1, -1, -1), new Polynomial(-2, -2, -2));
            yield return new TestCaseData(new Polynomial(-1, -1, -1), new Polynomial(1, 1, 1), new Polynomial(0, 0, 0));
            yield return new TestCaseData(new Polynomial(0, 1, 2, 3, 4), new Polynomial(1, 2, 3), new Polynomial(1, 3, 5, 3, 4));
            yield return new TestCaseData(new Polynomial(0, -1, -2, -3, -4), new Polynomial(1, 2, 3), new Polynomial(1, 1, 1, -3, -4));
        }


        [TestCaseSource("PolynomialSubCase")]
        public void Polynomial_SubCase_Success(Polynomial p1, Polynomial p2, Polynomial expectedResult)
        {
            var actualResult = p1 - p2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> PolynomialSubCase()
        {
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1, 1), new Polynomial(0, 0, 0));
            yield return new TestCaseData(new Polynomial(0, 0, 0), new Polynomial(0, 0, 0), new Polynomial(0, 0, 0));
            yield return new TestCaseData(new Polynomial(-1, -1, -1), new Polynomial(-1, -1, -1), new Polynomial(0, 0, 0));
            yield return new TestCaseData(new Polynomial(-1, -1, -1), new Polynomial(1, 1, 1), new Polynomial(-2, -2, -2));
            yield return new TestCaseData(new Polynomial(0, 1, 2, 3, 4), new Polynomial(1, 2, 3), new Polynomial(-1, -1, -1, 3, 4));
            yield return new TestCaseData(new Polynomial(0, -1, -2, -3, -4), new Polynomial(1, 2, 3), new Polynomial(-1, -3, -5, -3, -4));
        }


        [TestCaseSource("PolynomialMulCase")]
        public void Polynomial_MulCase_Success(Polynomial p1, double multiplier, Polynomial expectedResult)
        {
            var actualResult = p1 * multiplier;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> PolynomialMulCase()
        {
            yield return new TestCaseData(new Polynomial(10, 10, 10), 0, new Polynomial(0, 0, 0));
            yield return new TestCaseData(new Polynomial(-10, -10, -10), 0, new Polynomial(0, 0, 0));

            yield return new TestCaseData(new Polynomial(10, 10, 10), 1, new Polynomial(10, 10, 10));
            yield return new TestCaseData(new Polynomial(-10, -10, -10), 1, new Polynomial(-10, -10, -10));

            yield return new TestCaseData(new Polynomial(10, 10, 10), -1, new Polynomial(-10, -10, -10));
            yield return new TestCaseData(new Polynomial(-10, -10, -10), -1, new Polynomial(10, 10, 10));

            yield return new TestCaseData(new Polynomial(10, 10, 10), .1, new Polynomial(1, 1, 1));
        }


        [TestCaseSource("PolynomialEqualsCase")]
        public void Polynomial_EqualsCase_Success(Polynomial p1, Polynomial p2, bool expectedResult)
        {
            var actualResult = p1 == p2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> PolynomialEqualsCase()
        {
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1, 1), true);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(-1, -1, -1), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(0, 0, 0), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 0, 1), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1), false);
            yield return new TestCaseData(new Polynomial(-1, -1, -1), new Polynomial(-1, -1, -1), true);
        }


        [TestCaseSource("PolynomialGetHashCodeCase")]
        public void Polynomial_GetHashCodeCase_Success(Polynomial p1, Polynomial p2, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, p1.GetHashCode() == p2.GetHashCode());
        }
        public static IEnumerable<TestCaseData> PolynomialGetHashCodeCase()
        {
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1, 1), true);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(-1, -1, -1), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(0, 0, 0), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 0, 1), false);
            yield return new TestCaseData(new Polynomial(1, 1, 1), new Polynomial(1, 1), false);
            yield return new TestCaseData(new Polynomial(-1, -1, -1), new Polynomial(-1, -1, -1), true);
        }

        [TestCaseSource("PolynomialToStringCase")]
        public void Polynomial_ToStringCase_Success(Polynomial p, string expectedResult)
        {
            Assert.AreEqual(expectedResult, p.ToString());
        }
        public static IEnumerable<TestCaseData> PolynomialToStringCase()
        {
            yield return new TestCaseData(new Polynomial(0), "0");
            yield return new TestCaseData(new Polynomial(-0), "0");
            yield return new TestCaseData(new Polynomial(-0, 0), "0");
            yield return new TestCaseData(new Polynomial(0, 1), "x");
            yield return new TestCaseData(new Polynomial(0, -1), "-x");
            yield return new TestCaseData(new Polynomial(-1, -1), "-x-1");
            yield return new TestCaseData(new Polynomial(-0, 1, -0), "x");
            yield return new TestCaseData(new Polynomial(-0, -0, -0), "0");
            yield return new TestCaseData(new Polynomial(-0, -0, -0, -10), "-10x^3");
            yield return new TestCaseData(new Polynomial(-15, -0, -0, -0), "-15");
            yield return new TestCaseData(new Polynomial(-11, -0, -0, -12), "-12x^3-11");
        }
    }
}