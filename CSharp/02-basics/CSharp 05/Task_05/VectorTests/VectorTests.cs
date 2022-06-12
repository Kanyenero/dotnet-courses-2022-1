using NUnit.Framework;
using VectorLib;

namespace VectorTests
{
    [TestFixture]
    public class VectorTests
    {
        [TestCaseSource("Vector3DAddCase")]
        public void TestVector3D_AddCase_Success(Vector3D v1, Vector3D v2, Vector3D expectedResult)
        {
            var actualResult = v1 + v2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> Vector3DAddCase()
        {
            yield return new TestCaseData(new Vector3D(1, 1, 1), new Vector3D(1, 1, 1), new Vector3D(2, 2, 2));
            yield return new TestCaseData(new Vector3D(0, 0, 0), new Vector3D(0, 0, 0), new Vector3D(0, 0, 0));
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(-1, -1, -1), new Vector3D(-2, -2, -2));
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(1, 1, 1), new Vector3D(0, 0, 0));
        }


        [TestCaseSource("Vector3DSubCase")]
        public void TestVector3D_SubCase_Success(Vector3D v1, Vector3D v2, Vector3D expectedResult)
        {
            var actualResult = v1 - v2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> Vector3DSubCase()
        {
            yield return new TestCaseData(new Vector3D(1, 1, 1), new Vector3D(1, 1, 1), new Vector3D(0, 0, 0));
            yield return new TestCaseData(new Vector3D(0, 0, 0), new Vector3D(0, 0, 0), new Vector3D(0, 0, 0));
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(-1, -1, -1), new Vector3D(0, 0, 0));
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(1, 1, 1), new Vector3D(-2, -2, -2));
        }


        [TestCaseSource("Vector3DMultCase")]
        public void TestVector3D_MultCase_Success(Vector3D v1, Vector3D v2, double expectedResult)
        {
            var actualResult = v1 * v2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> Vector3DMultCase()
        {
            yield return new TestCaseData(new Vector3D(1, 1, 1), new Vector3D(1, 1, 1), 3);
            yield return new TestCaseData(new Vector3D(0, 0, 0), new Vector3D(0, 0, 0), 0);
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(-1, -1, -1), 3);
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(1, 1, 1), -3);
        }


        [TestCaseSource("Vector3DEqualsCase")]
        public void TestVector3D_EqualsCase_Success(Vector3D v1, Vector3D v2, bool expectedResult)
        {
            var actualResult = v1 == v2;

            Assert.AreEqual(expectedResult, actualResult);
        }
        public static IEnumerable<TestCaseData> Vector3DEqualsCase()
        {
            yield return new TestCaseData(new Vector3D(1, 1, 1), new Vector3D(1, 1, 1), true);
            yield return new TestCaseData(new Vector3D(0, 0, 0), new Vector3D(0, 0, 0), true);
            yield return new TestCaseData(new Vector3D(-1, -1, -1), new Vector3D(1, 1, 1), false);
            yield return new TestCaseData(new Vector3D(1, 2, 3), new Vector3D(3, 2, 1), false);
            yield return new TestCaseData(null, new Vector3D(0, 0, 0), false);
            yield return new TestCaseData(new Vector3D(0, 0, 0), null, false);
            yield return new TestCaseData(null, null, true);
        }


        [TestCaseSource("Vector3DHashCodeCase")]
        public void TestVector3D_HashCodeCase_Success(Vector3D v1, Vector3D v2, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, v1.GetHashCode() == v2.GetHashCode());
        }
        public static IEnumerable<TestCaseData> Vector3DHashCodeCase()
        {
            yield return new TestCaseData(new Vector3D(0, 0, 0), new Vector3D(0, 0, 0), true);
            yield return new TestCaseData(new Vector3D(0, 0, 1), new Vector3D(0, 0, 0), false);
            yield return new TestCaseData(new Vector3D(0, 1, 1), new Vector3D(0, 0, 0), false);
            yield return new TestCaseData(new Vector3D(1, 1, 1), new Vector3D(0, 0, 0), false);
        }
    }
}
