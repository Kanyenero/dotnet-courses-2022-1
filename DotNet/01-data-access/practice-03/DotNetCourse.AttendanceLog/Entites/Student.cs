namespace DotNetCourse.AttendanceLog.Entities
{
    public class Student
    {
        public int Id
        { 
            get; 
            set; 
        } = default!;

        public string FirstName 
        { 
            get; 
            set; 
        } = default!;

        public string? MiddleName 
        { 
            get; 
            set; 
        } = default!;

        public string LastName 
        { 
            get; 
            set; 
        } = default!;

        public string PassportSeriesAndNumber 
        { 
            get; 
            set; 
        } = default!;

        public Student() 
        { 
        }
        public Student(string firstName, string? middleName, string lastName, string passportSeriesAndNumber)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PassportSeriesAndNumber = passportSeriesAndNumber;
        }
        public Student(int id, string firstName, string? middleName, string lastName, string passportSeriesAndNumber)
        {
            Id          = id;
            FirstName   = firstName;
            MiddleName  = middleName;
            LastName    = lastName;
            PassportSeriesAndNumber = passportSeriesAndNumber;
        }

        public override string ToString()
        {
            return 
                $"[{Id}]\t" +
                $"{FirstName}\t" +
                $"{MiddleName}\t" +
                $"{LastName}\t" +
                $"{PassportSeriesAndNumber}";
        }
    }
}