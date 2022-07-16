namespace AttendanceLog.BusinessLogic.Lecture
{
    public interface IDataProvider
    {
        int Add(string topic, DateTime date);
        int Add(Common.Entities.Lecture lecture);
    }
}
