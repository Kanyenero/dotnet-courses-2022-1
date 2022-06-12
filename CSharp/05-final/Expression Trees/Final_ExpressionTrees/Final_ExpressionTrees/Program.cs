using Task_11.Exams;
using Final_ExpressionTrees.ExpressionFilters;

namespace Final_ExpressionTrees.UI
{
    internal class Program
    {
        private static void Main()
        {
            var _exams = new List<Exam>()
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
            }.AsQueryable();

            var filter = new GenericFilter<Exam>();
            filter.AddFilter("Name", FilterType.Equal, "Mathematics-100");
            filter.AddRangeFilter("Mark", 3, 7);

            var collection = filter.Apply(_exams);

            foreach (var item in collection)
                Console.WriteLine(item);
        }
    }
}
