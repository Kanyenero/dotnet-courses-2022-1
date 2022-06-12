using NUnit.Framework;
using MatrixLib;

namespace MatrixTests
{
    [TestFixture]
    public class MatrixTests
    {
        private const int V = 1;

        [TestCaseSource("TestCases_ConstructorWithDimensionParameters")]
        public void TestMatrix_ConstructorThrowsMatrixException_Success(int rows, int cols)
        {
            Assert.Throws<ArgumentException>(() => new Matrix(rows, cols));
        }
        public static IEnumerable<TestCaseData> TestCases_ConstructorWithDimensionParameters()
        {
            yield return new TestCaseData(0, 0);
            yield return new TestCaseData(-1, 0);
            yield return new TestCaseData(0, -1);
            yield return new TestCaseData(-1, -1);
            yield return new TestCaseData(1, 0);
            yield return new TestCaseData(0, 1);
        }


        [Test]
        public void TestMatrix_ConstructorThrowsNullException_Success()
        {
            Assert.Throws<NullReferenceException>(() => new Matrix(null));
        }


        [TestCaseSource("TestCases_MatrixNull")]
        public void TestMatrix_SumThrowsNullReferenceException_Success(Matrix mx1, Matrix mx2)
        {
            Matrix expectedResult;
            Assert.Throws<NullReferenceException>(() => expectedResult = mx1 + mx2);
        }
        [TestCaseSource("TestCases_MatrixNull")]
        public void TestMatrix_SubThrowsNullReferenceException_Success(Matrix mx1, Matrix mx2)
        {
            Matrix expectedResult;
            Assert.Throws<NullReferenceException>(() => expectedResult = mx1 - mx2);
        }
        [TestCaseSource("TestCases_MatrixNull")]
        public void TestMatrix_MulThrowsNullReferenceException_Success(Matrix mx1, Matrix mx2)
        {
            Matrix expectedResult;
            Assert.Throws<NullReferenceException>(() => expectedResult = mx1 * mx2);
        }
        public static IEnumerable<TestCaseData> TestCases_MatrixNull()
        {
            yield return new TestCaseData(new Matrix(1, 1), null);
            yield return new TestCaseData(null, new Matrix(1, 1));
            yield return new TestCaseData(null, null);
        }


        [TestCaseSource("TestCases_NotEqualDimensions")]
        public void TestMatrix_NotEqualDimensionsThrows_Success(Matrix mx1, Matrix mx2)
        {
            Matrix expectedResult;
            Assert.Throws<MatrixException>(() => expectedResult = mx1 + mx2);
            Assert.Throws<MatrixException>(() => expectedResult = mx1 - mx2);
        }
        public static IEnumerable<TestCaseData> TestCases_NotEqualDimensions()
        {
            yield return new TestCaseData(new Matrix(1, 1), new Matrix(2, 2));
            yield return new TestCaseData(new Matrix(1, 1), new Matrix(1, 2));
            yield return new TestCaseData(new Matrix(1, 1), new Matrix(2, 1));
        }


        [TestCaseSource("TestCases_InconsistentMatrices")]
        public void TestMatrix_InconsistentThrows_Success(Matrix mx1, Matrix mx2)
        {
            Matrix expectedResult;
            Assert.Throws<MatrixException>(() => expectedResult = mx1 * mx2);
        }
        public static IEnumerable<TestCaseData> TestCases_InconsistentMatrices()
        {
            yield return new TestCaseData(new Matrix(1, 1), new Matrix(2, 2));
            yield return new TestCaseData(new Matrix(1, 1), new Matrix(1, 2));
            yield return new TestCaseData(new Matrix(1, 1), new Matrix(2, 1));
            yield return new TestCaseData(new Matrix(1, 2), new Matrix(1, 1));
            yield return new TestCaseData(new Matrix(2, 1), new Matrix(1, 1));
            yield return new TestCaseData(new Matrix(2, 2), new Matrix(1, 1));
        }


        [TestCaseSource("Vector3DEqualsCase")]
        public void TestMatrix_Equals_Success(Matrix v1, Matrix v2, bool expectedResult)
        {
            var actualResult = v1 == v2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> Vector3DEqualsCase()
        {
            yield return new TestCaseData(new Matrix(new double[2, 2] { { 0, 0 }, { 0, 0 } }) , new Matrix(new double[2, 2] { { 0, 0 }, { 0, 0 } }), true);
            yield return new TestCaseData(new Matrix(new double[2, 2] { { 1, 1 }, { 1, 1 } }) , new Matrix(new double[2, 2] { { 1, 1 }, { 1, 1 } }), true);
            yield return new TestCaseData(new Matrix(new double[2, 2] { { 1, 0 }, { 1, 0 } }) , new Matrix(new double[2, 2] { { 1, 0 }, { 1, 0 } }), true);
            yield return new TestCaseData(new Matrix(new double[2, 2] { { -1, 0 }, { -1, 0 } }) , new Matrix(new double[2, 2] { { -1, 0 }, { -1, 0 } }), true);
            yield return new TestCaseData(new Matrix(new double[2, 2] { { -1, -1 }, { -1, -1 } }) , new Matrix(new double[2, 2] { { -1, -1 }, { -1, -1 } }), true);
        }
    }
}