﻿namespace AttendanceLog.BusinessLogic.Student
{
    public interface IDataProvider
    {
        int Add(string firstName, string? middleName, string lastName, string passportSeriesAndNumber);
        int Add(Common.Entities.Student student);
    }
}
