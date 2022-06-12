using NUnit.Framework;
using PointProcessor;
using System;

namespace PointProcessorTests
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void TestTryParsePoint_X8DigitsY8Digits_Success()
        {
            const string lineWithTwoZero = "1234.5678,8765.4321";
            Point expected = new Point(1234.5678m, 8765.4321m);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(lineWithTwoZero, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XIntegerYOnlyFractional_Success()
        {
            const string line = "1234,.4321";
            Point expected = new Point(1234m, .4321m);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XOnlyFractionalYInteger_Success()
        {
            const string line = ".5678,8765";
            Point expected = new Point(.5678m, 8765m);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XZeroYZero_Success()
        {
            const string line = "0,0";
            Point expected = new Point(0, 0);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XZeroPointZeroYZeroPointZero_Success()
        {
            const string line = "0.0,0.0";
            Point expected = new Point(0, 0);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XPointZeroYPointZero_Success()
        { 
            const string line = ".0,.0";
            Point expected = new Point(0, 0);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XTrailingZero_Success()
        {
            const string line = ".1000,2";
            Point expected = new Point(0.1m, 2);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XLeadingZero_Success()
        {
            const string line = "0001,2";
            Point expected = new Point(1, 2);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_YTrailingZero_Success()
        {
            const string line = "1,.2000";
            Point expected = new Point(1, 0.2m);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_YLeadingZero_Success()
        {
            const string line = "1,0002";
            Point expected = new Point(1, 2);

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsTrue(actualIsParsed);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTryParsePoint_XPointYPoint_Failure()
        {
            const string line = ".,.";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_LetterA_Failure()
        {
            const string line = "a";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_XYZ_Failure()
        {
            const string line = "1,20,300";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_SymbolDot_Failure()
        {
            const string line = ".";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_SymbolComma_Failure()
        {
            const string line = ",";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_OnlyXInteger_Failure()
        {
            const string line = "1";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_OnlyXWithFraction_Failure()
        {
            const string line = "1.2";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_OnlyYInteger_Failure()
        {
            const string line = ",10";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_OnlyYWithFraction_Failure()
        {
            const string line = ",10.20";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_XIntegerDotYInteger_Failure()
        {
            const string line = "1.20";

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_Null_ArgumentNullException()
        {
            const string line = null;

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }

        [Test]
        public void TestTryParsePoint_Empty_ArgumentNullException()
        {
            string line = string.Empty;

            Point actual;
            bool actualIsParsed = Parser.TryParsePoint(line, out actual);

            Assert.IsFalse(actualIsParsed);
            Assert.IsNull(actual);
        }
    }
}
