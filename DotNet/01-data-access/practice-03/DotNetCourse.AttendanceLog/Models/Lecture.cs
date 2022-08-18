namespace DotNetCourse.AttendanceLog.Models
{
    public class Lecture
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Course { get; set; }

        public string Topic { get; set; }

        public Lecture() 
            : this(default)
        {
        }

        public Lecture(int id) 
            : this(id, new DateTime(1900, 1, 1), string.Empty, string.Empty)
        {
        }

        public Lecture(DateTime date, string course, string topic)
            : this(default, date, course, topic)
        {
        }

        public Lecture(int id, DateTime date, string course, string topic)
        {
            Id = id;
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
