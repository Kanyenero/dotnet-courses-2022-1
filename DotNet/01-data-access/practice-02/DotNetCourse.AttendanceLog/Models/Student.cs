namespace DotNetCourse.AttendanceLog.Models
{
    public class Student : IIndexableModel<Index<int>>
    {
        public Index<int> Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueLogin { get; set; }

        public Student() : this(new Index<int>(0))
        {
        }

        public Student(Index<int>? id) : this(id, null!, null!, null!)
        {
        }

        public Student(Index<int>? id, string firstName, string lastName, string uniqueLogin)
        {
            Id = id!;
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