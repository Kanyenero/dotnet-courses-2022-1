namespace DotNetCourse.AttendanceLog.Models
{
    public class Lecture : IIndexableModel<Index<int>>
    {
        public Index<int> Id { get; set; }

        public DateTime Date { get; set; }

        public string Course { get; set; }

        public string Topic { get; set; }

        public Lecture() : this(new Index<int>(0))
        {
        }

        public Lecture(Index<int>? id) : this(id, default, null!, null!)
        {
        }

        public Lecture(Index<int>? id, DateTime date, string course, string topic)
        {
            Id = id!;
            Date = date;
            Course = course;
            Topic = topic;
        }

        public override string ToString()
        {
            return string.Format("{0,-5}{1,-20}{2,-15}{3,-30}", Id, Date, Course, Topic);
        }
    }
}
