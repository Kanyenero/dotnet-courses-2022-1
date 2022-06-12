using NUnit.Framework;
using PointProcessor;

namespace PointProcessorTests
{
    [TestFixture]
    public class ProcessorTests
    {
        [Test]
        public void TestProcessLine_XZeroYZero_Success()
        {
            const string lineWithTwoZero = "0,0";
            string expected = "X:    0,0    Y:    0,0   ";

            string actual = Processor.ProcessLine(lineWithTwoZero);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestProcessLine_XBigYBig_Success()
        {
            const string lineWithTwoZero = "1234.5678,8765.4321";
            string expected = "X: 1234,5678 Y: 8765,4321";

            string actual = Processor.ProcessLine(lineWithTwoZero);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestProcessLine_XTrailingZeroesYTrailingZeroes_Success()
        {
            const string lineWithTwoZero = ".0000,.0000";
            string expected = "X:    0,0    Y:    0,0   ";

            string actual = Processor.ProcessLine(lineWithTwoZero);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestProcessLine_LetterA_Null()
        {
            const string lineWithTwoZero = "a";

            string actual = Processor.ProcessLine(lineWithTwoZero);

            Assert.IsNull(actual);
        }

        [Test]
        public void TestProcessLine_Null_Null()
        {
            const string line = null;

            string actual = Processor.ProcessLine(line);

            Assert.IsNull(actual);
        }

        [Test]
        public void TestProcessLine_Empty_Null()
        {
            string line = string.Empty;

            string actual = Processor.ProcessLine(line);

            Assert.IsNull(actual);
        }
    }
}
