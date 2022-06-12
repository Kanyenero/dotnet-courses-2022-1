using System.Text.RegularExpressions;

using NUnit.Framework;

using Task_11.SearchTrees;
using Task_11.Exams;

namespace Task_12
{
    [TestFixture]
    public class BSTTests
    {
        private static readonly IEnumerable<Exam> _exams = new List<Exam>()
        {
            new Exam("Mathematics-100", new DateTime(2001, 12, 18), "Timmy", "Bell", 4),
            new Exam("Mathematics-100", new DateTime(2001, 12, 17), "Ron", "Mc Calister", 6),
            new Exam("Mathematics-200", new DateTime(2001, 12, 16), "Lisa", "Chizhova", 3),
            new Exam("Mathematics-100", new DateTime(2000, 12, 18), "Bart", "Simpson", 2),
            new Exam("Mathematics-300", new DateTime(2000, 12, 19), "Olivia", "Stone", 9),
            new Exam("Mathematics-300", new DateTime(2000, 12, 19), "Peter", "Monroe", 9),
            new Exam("Mathematics-200", new DateTime(2000, 12, 20), "Lisa", "Kitter", 10),
            new Exam("Mathematics-200", new DateTime(2000, 12, 21), "Dina", "Svyatko", 4),
            new Exam("Mathematics-100", new DateTime(2000, 12, 21), "Amar", "Singh", 5),
            new Exam("Mathematics-500", new DateTime(2000, 12, 22), "Li", "Zhang", 2),
            new Exam("Mathematics-200", new DateTime(1999, 12, 11), "Mikola", "Cherezky", 8),
            new Exam("Mathematics-200", new DateTime(1999, 12, 12), "Lyubov", "Kovaleva", 10),
            new Exam("Mathematics-300", new DateTime(1999, 12, 12), "Ivan", "Ivanov", 6),
            new Exam("Mathematics-500", new DateTime(1999, 12, 13), "Peter", "Pen", 3),
            new Exam("Mathematics-100", new DateTime(1999, 12, 14), "Jim", "Hawkins", 9),

            new Exam("Mathematics100", new DateTime(2000, 12, 18), "Bart", "Simpson", 2), // incorrect exam name example
            new Exam("Mathematics-100", new DateTime(2000, 12, 19), "Bart", "Simpson", 4), // test retake example
            new Exam("Physics-100", new DateTime(2000, 12, 19), "Bart", "Simpson", 4), // test retake example

            new Exam("Physics-100", new DateTime(2001, 12, 21), "Timmy", "Bell", 3),
            new Exam("Physics-100", new DateTime(2001, 12, 20), "Ron", "Mc Calister", 6),
            new Exam("Physics-200", new DateTime(2001, 12, 19), "Lisa", "Chizhova", 5),
            new Exam("Physics-100", new DateTime(2000, 12, 21), "Bart", "Simpson", 2),
            new Exam("Physics-300", new DateTime(2000, 12, 21), "Olivia", "Stone", 7),
            new Exam("Physics-300", new DateTime(2000, 12, 22), "Peter", "Monroe", 8),
            new Exam("Physics-200", new DateTime(2000, 12, 23), "Lisa", "Kitter", 9),
            new Exam("Physics-200", new DateTime(2000, 12, 24), "Dina", "Svyatko", 4),
            new Exam("Physics-100", new DateTime(2000, 12, 24), "Amar", "Singh", 5),
            new Exam("Physics-500", new DateTime(2000, 12, 25), "Li", "Zhang", 4),
            new Exam("Physics-200", new DateTime(1999, 12, 14), "Mikola", "Cherezky", 6),
            new Exam("Physics-200", new DateTime(1999, 12, 14), "Lyubov", "Kovaleva", 10),
            new Exam("Physics-300", new DateTime(1999, 12, 15), "Ivan", "Ivanov", 8),
            new Exam("Physics-500", new DateTime(1999, 12, 16), "Peter", "Pen", 4),
            new Exam("Physics-100", new DateTime(1999, 12, 17), "Jim", "Hawkins", 7)
        };

        private readonly RecursiveTree<Exam> recursiveSearchTree = new(_exams);

        [Test]
        public void TestBST_GetDayOfTheFirstTestTaken_Success()
        {
            var expectedResult = new DateTime(1999, 12, 11);
            var actualResult = recursiveSearchTree
                .Min(exam => exam.Date);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetNumberOfTestTakenInAGivenYear_Success()
        {
            int year = 2000;

            int expectedResult = 17;

            var actualResult = recursiveSearchTree
                .Where(exam => exam.Date.Year == year)
                .Count();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetThreeMaxMarks_Success()
        {
            var expectedResult = new List<int>() { 10, 10, 10 };

            var actualResult = recursiveSearchTree
                .OrderByDescending(exam => exam.Mark)
                .Take(3)
                .Select(exam => exam.Mark);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetAllStudentsInfo_Success()
        {
            var expectedResult = new List<string>()
            {
                "Amar Singh",
                "Bart Simpson",
                "Dina Svyatko",
                "Ivan Ivanov",
                "Jim Hawkins",
                "Li Zhang",
                "Lisa Chizhova",
                "Lisa Kitter",
                "Lyubov Kovaleva",
                "Mikola Cherezky",
                "Olivia Stone",
                "Peter Monroe",
                "Peter Pen",
                "Ron Mc Calister",
                "Timmy Bell",
            };

            var actualResult = recursiveSearchTree
                .Select(examGroup => new string(examGroup.StudentName + " " + examGroup.StudentLastName))
                .Distinct()
                .OrderBy(studentName => studentName);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetWellStudyingStudentsInfo_Success()
        {
            var expectedResult = new List<string>()
            {
                "Kitter",
                "Kovaleva",
                "Monroe"
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => exam.StudentLastName)
                .Where(examGroup => !examGroup.Any(exam => exam.Mark < 8))
                .Select(examGroup => examGroup.Key)
                .OrderBy(key => key);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetTestsWithBadMarks_Success()
        {
            var expectedResult = new List<string>()
            {
                "Mathematics-100",
                "Mathematics-200",
                "Mathematics-500",
                "Mathematics100",
                "Physics-100"
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => exam.Name)
                .Where(examGroup => examGroup.Any(exam => exam.Mark < 4))
                .Select(examGroup => examGroup.Key)
                .OrderBy(key => key);

            expectedResult.Sort();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetStudentAverageMark_Success()
        {
            var expectedResult = new List<(string name, string lastName, int averageMark)>()
            {
                ("Amar", "Singh", 5),
                ("Bart", "Simpson", 2),
                ("Dina", "Svyatko", 4),
                ("Ivan", "Ivanov", 7),
                ("Jim", "Hawkins", 8),
                ("Li", "Zhang", 3),
                ("Lisa", "Kitter", 9),
                ("Lisa", "Chizhova", 4),
                ("Lyubov", "Kovaleva", 10),
                ("Mikola", "Cherezky", 7),
                ("Olivia", "Stone", 8),
                ("Peter", "Monroe", 8),
                ("Peter", "Pen", 3),
                ("Ron", "Mc Calister", 6),
                ("Timmy", "Bell", 3)
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => new { exam.StudentName, exam.StudentLastName })
                .Select(examGroup => (examGroup.Key.StudentName, examGroup.Key.StudentLastName, (int)examGroup.Average(exam => exam.Mark)))
                .OrderBy(tuple => tuple.StudentName);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetMarksFromSpecifiedMonthAndYear_Success()
        {
            int specifiedMonth = 12;
            int specifiedYear = 2001;
            
            var expectedResult = new List<(string examName, string studentName, string studentLastName, int averageMark)>()
            {
                ("Mathematics-100", "Ron", "Mc Calister", 6),
                ("Mathematics-100", "Timmy", "Bell", 4),
                ("Mathematics-200", "Lisa", "Chizhova", 3),
                ("Physics-100", "Ron", "Mc Calister", 6),
                ("Physics-100", "Timmy", "Bell", 3),
                ("Physics-200", "Lisa", "Chizhova", 5)
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => new { exam.Date.Month, exam.Date.Year })
                .Where(examGroup => examGroup.Key.Month == specifiedMonth && examGroup.Key.Year == specifiedYear)
                .SelectMany(examGroup => examGroup.Select(exam => (exam.Name, exam.StudentName, exam.StudentLastName, exam.Mark)))
                .OrderBy(exam => exam.Name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetIncorrectExamNames_Success()
        {
            var expectedResult = new List<string>()
            {
                "Mathematics100"
            };

            var examNamePattern = @"(\w+-\d+)";

            var actualResult = recursiveSearchTree
                .Where(exam => !Regex.Match(exam.Name, examNamePattern).Success)
                .Select(exam => new string(exam.Name))
                .OrderBy(examName => examName);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetTestsTakenByStudent_Success()
        {
            var expectedResult = new List<(string, string[])>()
            {
                ("Amar Singh", new string[] { "Mathematics-100", "Physics-100" }),
                ("Bart Simpson", new string[] { "Mathematics-100", "Mathematics-100", "Mathematics100", "Physics-100", "Physics-100" }),
                ("Dina Svyatko", new string[] { "Mathematics-200", "Physics-200" }),
                ("Ivan Ivanov", new string[] { "Mathematics-300", "Physics-300" }),
                ("Jim Hawkins", new string[] { "Mathematics-100", "Physics-100" }),
                ("Li Zhang", new string[] { "Mathematics-500", "Physics-500" }),
                ("Lisa Chizhova", new string[] { "Mathematics-200", "Physics-200" }),
                ("Lisa Kitter", new string[] { "Mathematics-200", "Physics-200" }),
                ("Lyubov Kovaleva", new string[] { "Mathematics-200", "Physics-200" }),
                ("Mikola Cherezky", new string[] { "Mathematics-200", "Physics-200" }),
                ("Olivia Stone", new string[] { "Mathematics-300", "Physics-300" }),
                ("Peter Monroe", new string[] { "Mathematics-300", "Physics-300" }),
                ("Peter Pen", new string[] { "Mathematics-500", "Physics-500" }),
                ("Ron Mc Calister", new string[] { "Mathematics-100", "Physics-100" }),
                ("Timmy Bell", new string[] { "Mathematics-100", "Physics-100" }),
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => new { exam.StudentName, exam.StudentLastName })
                .Select(examGroup => (new string(examGroup.Key.StudentName + " " + examGroup.Key.StudentLastName), examGroup.Select(exam => exam.Name).ToArray()))
                .OrderBy(exam => exam.Item1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetStudentsWhoRetakeExam_Success()
        {
            var expectedResult = new List<(string, string[])>()
            {
                ("Bart Simpson", new string[] { "Mathematics-100", "Physics-100" })
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => new { exam.Name, exam.StudentName, exam.StudentLastName })
                .Where(examGroup => examGroup.Select(exam => exam).Count() > 1)
                .GroupBy(examGroup => new { examGroup.Key.StudentName, examGroup.Key.StudentLastName })
                .Select(examGroup => (new string(examGroup.Key.StudentName + " " + examGroup.Key.StudentLastName), examGroup.Select(examGroup1 => examGroup1.Key.Name).ToArray()))
                .OrderBy(exam => exam.Item1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBST_GetTestsDidntTakenInSpecifiedYear_Success()
        {
            int specifiedYear = 2001;

            var expectedResult = new List<string>()
            {
                "Mathematics-300",
                "Mathematics-500",
                "Mathematics100",
                "Physics-300",
                "Physics-500"
            };

            var actualResult = recursiveSearchTree
                .GroupBy(exam => exam.Name)
                .Where(examGroup => examGroup.All(exam => exam.Date.Year != specifiedYear))
                .Select(examGroup => examGroup.Key)
                .OrderBy(key => key);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
