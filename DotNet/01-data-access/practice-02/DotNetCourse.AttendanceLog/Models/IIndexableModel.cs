namespace DotNetCourse.AttendanceLog.Models
{
    public interface IIndexableModel<out T> 
        where T : Index
    {
        T Id { get; }
    }
}
