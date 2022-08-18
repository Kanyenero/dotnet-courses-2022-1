namespace DotNetCourse.AttendanceLog.Models
{
    public abstract class Identifier
    {
    }

    public class Identifier<T> : Identifier
        where T : IComparable<T>
    {
        public T Value { get; set; }

        public Identifier()
        {
            Value = default!;
        }

        public Identifier(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return string.Format("[{0}]",
                Value.ToString());
        }
    }

    public class Identifier<T1, T2> : Identifier
        where T1 : IComparable<T1>
        where T2 : IComparable<T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }

        public Identifier()
        {
            Value1 = default!;
            Value2 = default!;
        }

        public Identifier(T1 value1, T2 value2)
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
