using Microsoft.EntityFrameworkCore;
using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.DataAccess
{
    public class AttendanceLogContext : DbContext
    {
        public DbSet<Attendance> Attendances { get; set; }
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
                .Property(model => model.Id)
                .HasColumnName("StudentID");

            modelBuilder.Entity<Student>()
                .Property(model => model.UniqueLogin)
                .HasColumnName("UQ_Login");

            modelBuilder.Entity<Lecture>()
                .Property(model => model.Id)
                .HasColumnName("LectureID");

            modelBuilder.Entity<Attendance>()
                .Property(model => model.LectureId)
                .HasColumnName("LectureID");

            modelBuilder.Entity<Attendance>()
                .Property(model => model.StudentId)
                .HasColumnName("StudentID");

            modelBuilder.Entity<Attendance>()
                .Ignore(model => model.LectureDate);

            modelBuilder.Entity<Attendance>()
                .Ignore(model => model.LectureCourse);

            modelBuilder.Entity<Attendance>()
                .Ignore(model => model.LectureTopic);

            modelBuilder.Entity<Attendance>()
                .Ignore(model => model.StudentUniqueLogin);

            modelBuilder.Entity<Attendance>()
                .Ignore(model => model.StudentFirstName);

            modelBuilder.Entity<Attendance>()
                .Ignore(model => model.StudentLastName);

            modelBuilder.Entity<Attendance>()
                .HasKey(attendance => new { attendance.LectureId, attendance.StudentId });
        }
    }
}