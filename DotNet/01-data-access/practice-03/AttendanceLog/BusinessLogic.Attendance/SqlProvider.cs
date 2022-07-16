﻿using AttendanceLog.Common.Entities;

namespace AttendanceLog.BusinessLogic.Attendance
{
    public class SqlProvider : IDataProvider
    {
        private readonly DataAccess.AttendanceEngine.IDataProvider provider;

        public SqlProvider(DataAccess.AttendanceEngine.IDataProvider provider)
        {
            this.provider = provider;
        }

        public int Attend(int? studentId, int? lectureId, int? mark)
        {
            return provider.Attend(studentId, lectureId, mark);
        }

        public int Attend(Student student, Lecture lecture, int? mark)
        {
            return provider.Attend(student, lecture, mark);
        }

        public int Attend(Common.Entities.Attendance attendance)
        {
            return Attend(attendance.StudentId, attendance.LectureId, attendance.Mark);
        }
    }
}