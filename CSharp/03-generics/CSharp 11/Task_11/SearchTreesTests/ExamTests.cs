using NUnit.Framework;
using Task_11.SearchTrees;
using Task_11.Exams;

namespace SearchTreesTests
{
    [TestFixture]
    public class ExamTests
    {
        [TestCaseSource("TestCases_CompareToLess")]
        public void TestExam_CompareToReturnsNegative_Success(Exam exam1, Exam exam2)
        {
            Assert.AreEqual(-1, exam1.CompareTo(exam2));
        }
        [TestCaseSource("TestCases_CompareToEquals")]
        public void TestExam_CompareToReturnsZero_Success(Exam exam1, Exam exam2)
        {
            Assert.AreEqual(0, exam1.CompareTo(exam2));
        }
        [TestCaseSource("TestCases_CompareToGreater")]
        public void TestExam_CompareToReturnsPositive_Success(Exam exam1, Exam exam2)
        {
            Assert.AreEqual(1, exam1.CompareTo(exam2));
        }
        public static IEnumerable<TestCaseData> TestCases_CompareToLess()
        {
            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Zhichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Larry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Rotter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 5));
        }
        public static IEnumerable<TestCaseData> TestCases_CompareToEquals()
        {
            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4));
        }
        public static IEnumerable<TestCaseData> TestCases_CompareToGreater()
        {
            yield return new TestCaseData(new Exam("Zhichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Larry", "Potter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Rotter", 4),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4));

            yield return new TestCaseData(new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 5),
                                          new Exam("Whichcraft", new DateTime(1992, 04, 18, 20, 00, 00), "Harry", "Potter", 4));
        }
    }
}
