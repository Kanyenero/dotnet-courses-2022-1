namespace DotNetCourse.AttendanceLog.Entities
{
    public class Lecture
    {
        public int      Id      { get; set; } = default!;
        public string   Topic   { get; set; } = default!;
        public DateTime Date    { get; set; } = default!;

        public Lecture()
        {
        }
        public Lecture(string topic, DateTime date)
        {
            Topic   = topic;
            Date    = date;
        }

        public override string ToString()
        {
            return 
                $"[{Id}]\t" +
                $"[{Date}]\t" +
                $"{Topic}";
        }
    }
}
