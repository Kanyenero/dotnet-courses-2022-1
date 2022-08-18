namespace DotNetCourse.AttendanceLog.Models
{
    public class Attendance
    {
        public int LectureId { get; set; }

        public int StudentId { get; set; }

        public DateTime? LectureDate { get; set; }

        public string? LectureCourse { get; set; }

        public string? LectureTopic { get; set; }

        public string? StudentUniqueLogin { get; set; }

        public string? StudentFirstName { get; set; }

        public string? StudentLastName { get; set; }

        public int? Mark { get; set; }

        public Attendance()
            : this(default, default)
        {
        }

        public Attendance(int lectureId, int studentId) 
            : this(lectureId, studentId, null)
        {
        }

        public Attendance(int lectureId, int studentId, int? mark)
            : this(lectureId, studentId, mark, null, null, null, null, null, null)
        {
        }

        public Attendance(
            int lectureId, 
            int studentId,
            int? mark,
            DateTime? lectureDate, 
            string? lectureCourse, 
            string? lectureTopic,
            string? studentUniqueLogin, 
            string? studentFirstName, 
            string? studentLastName)
        {
            LectureId = lectureId;
            StudentId = studentId;
            Mark = mark;
            LectureDate = lectureDate;
            LectureCourse = lectureCourse;
            LectureTopic = lectureTopic;
            StudentUniqueLogin = studentUniqueLogin;
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-15}{2,-30}{3,-25}{4,-10}{5,-20}{6,-2}",
                LectureDate,
                LectureCourse,
                LectureTopic,
                StudentUniqueLogin,
                StudentFirstName,
                StudentLastName,
                Mark);
        }
    }
}
