using NUnit.Framework;
using Task_11.SearchTrees;
using Task_11.Exams;

namespace Task_11.SearchTreesTests
{
    public abstract class SearchTreesTests
    {
        public List<Exam> exams = new()
        {
            new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 3),
            new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 2),
            new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 1),
            new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 5),
            new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)
        };

        public List<Exam> exams1 = new()
        {
            new Exam("Mathematics-100", new DateTime(2001, 12, 18), "Timmy",    "Bell",         4),
            new Exam("Mathematics-100", new DateTime(2001, 12, 17), "Ron",      "Mc Calister",  6),
            new Exam("Mathematics-200", new DateTime(2001, 12, 16), "Lisa",     "Chizhova",     3),
            new Exam("Mathematics-100", new DateTime(2000, 12, 18), "Bart",     "Simpson",      2),
            new Exam("Mathematics-300", new DateTime(2000, 12, 19), "Olivia",   "Stone",        9),
            new Exam("Mathematics-300", new DateTime(2000, 12, 19), "Misha",    "Monroe",       9),
            new Exam("Mathematics-200", new DateTime(2000, 12, 20), "Harry",    "Kitter",       10),
            new Exam("Mathematics-200", new DateTime(2000, 12, 21), "Dina",     "Svyatko",      4),
            new Exam("Mathematics-100", new DateTime(2000, 12, 21), "Amar",     "Singh",        5),
            new Exam("Mathematics-500", new DateTime(2000, 12, 22), "Li",       "Zhang",        2),
            new Exam("Mathematics-200", new DateTime(1999, 12, 11), "Mikola",   "Cherezky",     8),
            new Exam("Mathematics-200", new DateTime(1999, 12, 12), "Lyuba",    "Kovaleva",     10),
            new Exam("Mathematics-300", new DateTime(1999, 12, 12), "Ivan",     "Ivanov",       6),
            new Exam("Mathematics-500", new DateTime(1999, 12, 13), "Peter",    "Pen",          3),
            new Exam("Mathematics-100", new DateTime(1999, 12, 14), "Jim",      "Hawkins",      9),

            new Exam("Physics-100", new DateTime(2001, 12, 21), "Timmy",    "Bell",         3),
            new Exam("Physics-100", new DateTime(2001, 12, 20), "Ron",      "Mc Calister",  6),
            new Exam("Physics-200", new DateTime(2001, 12, 19), "Lisa",     "Chizhova",     5),
            new Exam("Physics-100", new DateTime(2000, 12, 21), "Bart",     "Simpson",      2),
            new Exam("Physics-300", new DateTime(2000, 12, 21), "Olivia",   "Stone",        7),
            new Exam("Physics-300", new DateTime(2000, 12, 22), "Misha",    "Monroe",       8),
            new Exam("Physics-200", new DateTime(2000, 12, 23), "Harry",    "Kitter",       9),
            new Exam("Physics-200", new DateTime(2000, 12, 24), "Dina",     "Svyatko",      4),
            new Exam("Physics-100", new DateTime(2000, 12, 24), "Amar",     "Singh",        5),
            new Exam("Physics-500", new DateTime(2000, 12, 25), "Li",       "Zhang",        4),
            new Exam("Physics-200", new DateTime(1999, 12, 14), "Mikola",   "Cherezky",     6),
            new Exam("Physics-200", new DateTime(1999, 12, 14), "Lyuba",    "Kovaleva",     10),
            new Exam("Physics-300", new DateTime(1999, 12, 15), "Ivan",     "Ivanov",       8),
            new Exam("Physics-500", new DateTime(1999, 12, 16), "Peter",    "Pen",          4),
            new Exam("Physics-100", new DateTime(1999, 12, 17), "Jim",      "Hawkins",      7),
        };

        public abstract void TestBinarySearchTree_InsertThrowsInvalidOperationException_Success();
        public abstract void TestBinarySearchTree_FindThrowsInvalidOperationException_Success();
        public abstract void TestBinarySearchTree_RemoveThrowsInvalidOperationException_Success();
        public abstract void TestBinarySearchTree_RemoveRoot_Success();
    }

    [TestFixture]
    public class RecursiveTreeTests : SearchTreesTests
    {
        RecursiveTree<Exam> recursiveSearchTree;

        [Test]
        public override void TestBinarySearchTree_InsertThrowsInvalidOperationException_Success()
        {
            recursiveSearchTree = new RecursiveTree<Exam>(exams);

            Assert.Throws<InvalidOperationException>(() => recursiveSearchTree.Insert(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }
        [Test]
        public override void TestBinarySearchTree_FindThrowsInvalidOperationException_Success()
        {
            recursiveSearchTree = new RecursiveTree<Exam>(exams);

            Assert.Throws<InvalidOperationException>(() => recursiveSearchTree.Find(new Exam("", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }
        [Test]
        public override void TestBinarySearchTree_RemoveThrowsInvalidOperationException_Success()
        {
            recursiveSearchTree = new RecursiveTree<Exam>(exams);

            Assert.Throws<InvalidOperationException>(() => recursiveSearchTree.Remove(new Exam("", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }
        [Test]
        public override void TestBinarySearchTree_RemoveRoot_Success()
        {
            recursiveSearchTree = new RecursiveTree<Exam>(exams);

            recursiveSearchTree.Remove(recursiveSearchTree.Root.Data);

            Assert.AreEqual(0, recursiveSearchTree.Root.CompareTo(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }


    }

    [TestFixture]
    public class IterativeTreeTests : SearchTreesTests
    {
        IterativeTree<Exam> iterativeSearchTree;

        [Test]
        public override void TestBinarySearchTree_InsertThrowsInvalidOperationException_Success()
        {
            iterativeSearchTree = new IterativeTree<Exam>(exams);

            Assert.Throws<InvalidOperationException>(() => iterativeSearchTree.Insert(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }
        [Test]
        public override void TestBinarySearchTree_FindThrowsInvalidOperationException_Success()
        {
            iterativeSearchTree = new IterativeTree<Exam>(exams);

            Assert.Throws<InvalidOperationException>(() => iterativeSearchTree.Find(new Exam("", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }
        [Test]
        public override void TestBinarySearchTree_RemoveThrowsInvalidOperationException_Success()
        {
            iterativeSearchTree = new IterativeTree<Exam>(exams);

            Assert.Throws<InvalidOperationException>(() => iterativeSearchTree.Remove(new Exam("", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }
        [Test]
        public override void TestBinarySearchTree_RemoveRoot_Success()
        {
            iterativeSearchTree = new IterativeTree<Exam>(exams);

            iterativeSearchTree.Remove(iterativeSearchTree.Root.Data);

            Assert.AreEqual(0, iterativeSearchTree.Root.CompareTo(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4)));
        }


    }
}