namespace DotNetCourse.AttendanceLog.Entities
{
    public class Attendance
    {
        public int?      LectureId           { get; set; } = default!;
        public DateTime? LectureDateTime     { get; set; } = default!;
        public string?   LectureTopic        { get; set; } = default!;
        public int?      StudentId           { get; set; } = default!;
        public string?   StudentFirstName    { get; set; } = default!;
        public string?   StudentMiddleName   { get; set; } = default!;
        public string?   StudentLastName     { get; set; } = default!;
        public int?      Mark                { get; set; } = default!;

        public Attendance()
        {
        }
        public Attendance(int? studentId, int? lectureId, int? mark)
        {
            LectureId = lectureId;
            StudentId = studentId;
            Mark = mark;
        }
        public Attendance(Lecture lecture, Student student, int? mark)
        {
            LectureDateTime     = lecture.Date;
            LectureTopic        = lecture.Topic;

            StudentId           = student.Id;
            StudentFirstName    = student.FirstName;
            StudentMiddleName   = student.MiddleName;
            StudentLastName     = student.LastName;

            Mark                = mark;
        }

        public override string ToString()
        {
            return string.Format("{0, -20}| {1, -20}| {2, -4}| {3, -10}| {4, -14}| {5, -12}| {6, -2}|",
                LectureDateTime,
                LectureTopic,
                StudentId,
                StudentFirstName,
                StudentMiddleName,
                StudentLastName,
                Mark);
        }
    }
}
