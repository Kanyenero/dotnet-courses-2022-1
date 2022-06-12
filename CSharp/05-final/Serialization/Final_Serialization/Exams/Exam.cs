using System.Xml.Serialization;

namespace Task_11.Exams
{
    [Serializable]
    public class Exam : IComparable<Exam>
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public int Mark { get; set; }

        public Exam() { }
        public Exam(string name, DateTime date, string studentName, string studentLastName, int mark)
        {
            Name = name;
            Date = date;
            StudentName = studentName;
            StudentLastName = studentLastName;
            Mark = mark;
        }

        public override string ToString()
        {
            return Name + " " + Date.ToString("g") + " " + StudentName + " " + StudentLastName + " " + Mark;
        }

        public int CompareTo(Exam? other)
        {
            if (other == null) throw new ArgumentNullException(nameof(other));
            if (this == other) return 0;

            int result;

            result = Name.CompareTo(other.Name);
            if (result != 0) return result;

            result = Date.CompareTo(other.Date);
            if (result != 0) return result;

            result = StudentName.CompareTo(other.StudentName);
            if (result != 0) return result;

            result = StudentLastName.CompareTo(other.StudentLastName);
            if (result != 0) return result;

            return Mark.CompareTo(other.Mark);
        }
    }
}
