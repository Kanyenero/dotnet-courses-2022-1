using NUnit.Framework;
using TriangleClassLibrary;

namespace TriangleTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(.0, 1, 1)]
        [TestCase(1, .0, 1)]
        [TestCase(1, 1, .0)]
        public void TestCreate_SideEqualsZero_ThrowsException(double testSide1, double testSide2, double testSide3)
        {
            Assert.Throws<ArgumentException>(delegate { Triangle.Create(testSide1, testSide2, testSide3); });
        }

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void TestCreate_SideLessThanZero_ThrowsException(double testSide1, double testSide2, double testSide3)
        {
            Assert.Throws<ArgumentException>(delegate { Triangle.Create(testSide1, testSide2, testSide3); });
        }

        [TestCase(10, 1, 1)]
        [TestCase(1, 10, 1)]
        [TestCase(1, 1, 10)]
        public void TestCreate_ExistenceCondition_ThrowsException(double testSide1, double testSide2, double testSide3)
        {
            Assert.Throws<ArgumentException>(delegate { Triangle.Create(testSide1, testSide2, testSide3); });
        }

        [TestCase(double.MaxValue * 2, double.MaxValue, double.MaxValue)]
        [TestCase(double.MaxValue, double.MaxValue * 2, double.MaxValue)]
        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue * 2)]
        public void TestCreate_SideValuePosInf_ThrowsException(double testSide1, double testSide2, double testSide3)
        {
            Assert.Throws<ArgumentException>(delegate { Triangle.Create(testSide1, testSide2, testSide3); });
        }

        public void TestToString_Exists_ReturnsString()
        {
            var testTriangle = Triangle.Create(1, 1, 1);
            Assert.NotNull(testTriangle.ToString());
        }
    }
}