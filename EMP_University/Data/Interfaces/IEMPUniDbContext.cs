using Common.Models;

using Data.Models;

using Microsoft.EntityFrameworkCore;

namespace Common.Interfaces
{
    public interface IEMPUniDbContext
    {
        DbSet<Course> Courses { get; set; }

        DbSet<Student> Students { get; set; }

        DbSet<StudentCourse> StudentCourse { get; set; }
    }
}