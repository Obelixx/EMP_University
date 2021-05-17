using Common.Interfaces;
using Common.Models;

using Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;

namespace Data
{
    internal class EMPUniDbContext : IdentityDbContext, IEMPUniDbContext
    {
        public EMPUniDbContext(DbContextOptions<EMPUniDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<StudentCourse>()
                .HasIndex(sc => sc.StudentId);

            var studentsToCreate = 5;
            var students = GenerateDemoStudents(studentsToCreate);
            builder.Entity<Student>()
                .HasData(students);

            var coursesToCreate = 50;
            var courses = GenerateDemoCourses(coursesToCreate);
            builder.Entity<Course>()
                .HasData(courses);

            // Add some courses to the half of the students.
            var studentCourses = new List<StudentCourse>();
            var courseIndex = 0;
            for (int studentIndex = 0; studentIndex < studentsToCreate / 2; studentIndex++)
            {
                for (int i = 0; i < 3; i++)
                {
                    studentCourses.Add(new StudentCourse() { StudentId = students[studentIndex].Id, CourseId = courses[courseIndex++].Id });
                }
            }

            builder.Entity<StudentCourse>()
                .HasData(studentCourses);
        }

        private static IList<Student> GenerateDemoStudents(int count)
        {
            if (count < 0)
            {
                count *= -1;
            }

            if (count == 0)
            {
                count = 1;
            }

            var result = new List<Student>(count);
            var passwordHasher = new PasswordHasher<Student>();

            var emailFormat = "test{0}@example.com";
            var plainPasswordFormat = "Pass@word{0}";
            for (int i = 1; i <= count; i++)
            {
                var email = string.Format(emailFormat, i);
                var newStudent = new Student()
                {
                    Id = i.ToString(),
                    Email = email,
                    UserName = email,
                    NormalizedEmail = email,
                    NormalizedUserName = email,
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, string.Format(plainPasswordFormat, i)),
                };

                result.Add(newStudent);
            }

            return result;
        }

        private static IList<Course> GenerateDemoCourses(int count)
        {
            if (count < 0)
            {
                count *= -1;
            }

            if (count == 0)
            {
                count = 1;
            }

            var result = new List<Course>(count);

            var courseNameFormat = "Cours_{0:D3}";
            var courseDescriptionFormat = "Cours_{0:D3}";
            for (int i = 1; i <= count; i++)
            {
                var start = new DateTime(2022, 1, 1).AddDays(i);
                var end = start.AddHours(2);
                var newCourse = new Course() { Id = i, Name = string.Format(courseNameFormat, i), Description = string.Format(courseDescriptionFormat, i), Start = start, Ends = end };

                result.Add(newCourse);
            }

            return result;
        }
    }
}