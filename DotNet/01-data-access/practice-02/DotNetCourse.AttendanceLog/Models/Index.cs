namespace DotNetCourse.AttendanceLog.Models
{
    public abstract class Index
    {
    }

    public class Index<T> : Index
        where T : IComparable<T>
    {
        public T Value { get; set; }

        public Index(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return string.Format("[{0}]",
                Value.ToString());
        }
    }

    public class Index<T1, T2> : Index
        where T1 : IComparable<T1>
        where T2 : IComparable<T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }

        public Index(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]",
                Value1.ToString(),
                Value2.ToString());
        }
    }
}
