using Task_11.SearchTrees;
using Task_11.Exams;

namespace Task_11.SearchTreesUI
{
    internal class Program
    {
        private static void Main()
        {
            var exams = new List<Exam>(new Exam[] { 
                new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Harry", "Potter", 4),
                new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 30, 00), "Hermione", "Granger", 5),
                new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 15, 00), "Ron", "Weasley", 3),
                new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 00, 00), "Neville", "Longbottom", 4)
            });

            RecursiveTree<Exam> recursiveSearchTree;
            IterativeTree<Exam> iterativeSearchTree;

            Console.WriteLine("Recursive tree\n");

            try
            {
                recursiveSearchTree = new RecursiveTree<Exam>(exams);
                PrintSearchTree(recursiveSearchTree);
                Console.WriteLine();

                var node = recursiveSearchTree.Find(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 30, 00), "Hermione", "Granger", 5));
                recursiveSearchTree.Remove(node.Data);
                PrintSearchTree(recursiveSearchTree);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nIterative tree\n");

            try
            {
                iterativeSearchTree = new IterativeTree<Exam>(exams);
                PrintSearchTree(iterativeSearchTree);
                Console.WriteLine();

                var node = iterativeSearchTree.Find(new Exam("Whichcraft", new DateTime(1992, 04, 18, 19, 30, 00), "Hermione", "Granger", 5));
                iterativeSearchTree.Remove(node.Data);
                PrintSearchTree(iterativeSearchTree);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void PrintSearchTree(BinarySearchTree<Exam> searchTree)
        {
            foreach (var item in searchTree)
            {
                if (item.CompareTo(searchTree.Root.Data) < 0)
                {
                    Console.WriteLine("Left\t{0}", item);
                }
                else if (item.CompareTo(searchTree.Root.Data) > 0)
                {
                    Console.WriteLine("Right\t{0}", item);
                }
                else
                {
                    Console.WriteLine("Root\t{0}", item);
                }
            }
        }
    }
}
