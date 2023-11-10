using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    [Table("Students")]
    public class Student
    {
        public Student() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public Boolean Status { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
    [Table("Courses")]
    public class Course
    {
        public Course() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Boolean Status { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    [Table("Enrollments")]
    public class Enrollment
    {
        public Enrollment() { }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime DateUpdate { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }
    }
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("TESTDB22"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(40);
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200); ;

                entity.HasData(
                    new Student { StudentName = "Amumu", Address = "Jungle", StudentID = 1 },
                    new Student { StudentName = "Ahri", Address = "Mid", StudentID = 2 },
                    new Student { StudentName = "Darius", Address = "Top", StudentID = 3 }
                    );
            });
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasData(
                    new Course { CourseName = "Slay Dragon", CourseID = 1 },
                    new Course { CourseName = "Slay Baron", CourseID = 2 }
                    );
            });
            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => new { e.StudentID, e.CourseID });

                entity.Property(e => e.DateUpdate)
                    .IsRequired();

                entity.HasOne(u => u.Student).WithMany(n => n.Enrollments)
                    .HasForeignKey(u => u.StudentID)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(c => c.Course).WithMany(n => n.Enrollments)
                    .HasForeignKey(c => c.CourseID)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
