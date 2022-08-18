namespace DotNetCourse.AttendanceLog.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueLogin { get; set; }

        public Student() 
            : this(default)
        {
        }

        public Student(int id) 
            : this(id, string.Empty, string.Empty, string.Empty)
        {
        }

        public Student(string firstName, string lastName, string uniqueLogin)
            : this(default, firstName, lastName, uniqueLogin)
        {
        }

        public Student(int id, string firstName, string lastName, string uniqueLogin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UniqueLogin = uniqueLogin;
        }

        public override string ToString()
        {
            return string.Format("{0,-5}{1,-10}{2,-20}{3,-25}", Id, FirstName, LastName, UniqueLogin);
        }
    }
}