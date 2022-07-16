using Microsoft.EntityFrameworkCore;
using AttendanceLog.Common.Entities;

namespace AttendanceLog.DataAccess
{
    public class AttendanceLogContext : DbContext
    {
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        public AttendanceLogContext() : base()
        {
        }

        public AttendanceLogContext(DbContextOptions<AttendanceLogContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=localhost;Database=AttendanceLog;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .HasColumnName("First_Name");

            modelBuilder.Entity<Student>()
                .Property(s => s.MiddleName)
                .HasColumnName("Middle_Name");

            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasColumnName("Last_Name");

            modelBuilder.Entity<Student>()
                .Property(s => s.PassportSeriesAndNumber)
                .HasColumnName("UQ_Passport_Series_and_Number");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.StudentId)
                .HasColumnName("Student_Id");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.LectureId)
                .HasColumnName("Lecture_Id");

            modelBuilder.Entity<Attendance>()
                .Ignore(a => a.StudentFirstName);

            modelBuilder.Entity<Attendance>()
                .Ignore(a => a.StudentMiddleName);

            modelBuilder.Entity<Attendance>()
                .Ignore(a => a.StudentLastName);

            modelBuilder.Entity<Attendance>()
                .Ignore(a => a.LectureTopic);

            modelBuilder.Entity<Attendance>()
                .Ignore(a => a.LectureDateTime);

            modelBuilder.Entity<Attendance>()
                .HasKey(attendance => new { attendance.StudentId, attendance.LectureId });

        }
    }
}
