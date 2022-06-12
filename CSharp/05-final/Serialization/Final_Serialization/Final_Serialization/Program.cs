using Task_11.SearchTrees;
using Task_11.Exams;

using System.Xml;
using System.Xml.Serialization;

namespace Final_Serialization.UI
{
    internal class Program
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
        private static readonly IEnumerable<Exam> _exams1 = new List<Exam>()
        {
            new Exam("Maths", new DateTime(2001, 12, 21), "Timmy", "Bell", 3),      // root
            new Exam("Literature", new DateTime(2001, 12, 21), "Timmy", "Bell", 3), // left
            new Exam("History", new DateTime(2001, 12, 21), "Timmy", "Bell", 3),    // left-left
            new Exam("Physics", new DateTime(2001, 12, 21), "Timmy", "Bell", 3),    // right
        };
        private static readonly RecursiveTree<Exam> recursiveSearchTree = new(_exams1);

        private static void Main()
        {
            string path = @"C:\NetLab_Zakhar_Khakhalin\netlab\CSharp\CSharp 05 Final Task\Serialization\Final_Serialization\tree.xml";

            var xmlSerializer = new XmlSerializer(typeof(RecursiveTree<Exam>));

            using (var fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, recursiveSearchTree);
            }

            using (var fs = new FileStream(path, FileMode.Open))
            {
                var result = xmlSerializer.Deserialize(fs);
            }
        }
    }
}