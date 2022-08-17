namespace DotNetCourse.AttendanceLog.Models
{
    public class Attendance : IIndexableModel<Index<int, int>>
    {
        public Index<int, int> Id { get; set; } = default!;

        public DateTime LectureDate { get; set; } = default!;

        public string LectureCourse { get; set; } = default!;

        public string LectureTopic { get; set; } = default!;

        public string StudentUniqueLogin { get; set; } = default!;

        public string StudentFirstName { get; set; } = default!;

        public string StudentLastName { get; set; } = default!;

        public int? Mark { get; set; } = default!;

        private bool LectureExists
        {
            get { return LectureCourse != null && LectureTopic != null; }
        }

        private bool StudentExists
        {
            get { return StudentUniqueLogin != null && StudentFirstName != null && StudentLastName != null; }
        }


        public Attendance() : this(new Index<int, int>(0, 0), null)
        {
        }

        public Attendance(Index<int, int> id) : this(id, null)
        {
        }

        public Attendance(Index<int, int> id, int? mark)
        {
            Id = id;
            Mark = mark;
        }

        public Attendance(
            DateTime lectureDate, 
            string lectureCourse, 
            string lectureTopic, 
            string studentUniqueLogin, 
            string studentFirstName, 
            string studentLastName, 
            int? mark)
        {
            LectureDate = lectureDate;
            LectureCourse = lectureCourse;
            LectureTopic = lectureTopic;
            StudentUniqueLogin = studentUniqueLogin;
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            Mark = mark;
        }

        public override string ToString()
        {
            string formatPattern = "{0,-20}{1,-15}{2,-30}{3,-25}{4,-10}{5,-20}{6,-2}";

            if (!LectureExists && StudentExists)
            {
                return string.Format(formatPattern,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    StudentUniqueLogin,
                    StudentFirstName,
                    StudentLastName,
                    null);
            }

            else if (LectureExists && !StudentExists)
            {
                return string.Format(formatPattern,
                    LectureDate,
                    LectureCourse,
                    LectureTopic,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    null);
            }

            return string.Format(formatPattern,
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
