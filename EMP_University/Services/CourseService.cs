using Common.Interfaces;
using Common.Models;

using Microsoft.EntityFrameworkCore;

using Services.Interfaces;
using Services.Paging;

using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class CourseService : ICourseService
    {
        private readonly IEMPUniDbContext dbContext;
        private readonly Pager<Course> coursePager;

        public CourseService(IEMPUniDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.coursePager = new Pager<Course>();
        }

        public DbSet<Course> Courses()
        {
            return this.dbContext.Courses;
        }

        public async Task<Course> GetById(int id)
        {
            return await this.dbContext.Courses.FindAsync(id);
        }

        public async Task<Course> GetFirstOrDefaultById(int id)
        {
            return await this.dbContext.Courses.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<PaginatedList<Course>> GetAllAsync(int? page = 0, int pageSize = 10)
        {
            return await this.coursePager.UseQuery(this.GetAllQuery(), page, pageSize);
        }

        public async Task<PaginatedList<Course>> GetSubscribedByUserId(string userId, int? page = 0, int pageSize = 10)
        {
            return await this.coursePager.UseQuery(this.GetSubscribedByUserIdQuery(userId), page, pageSize);
        }

        public async Task<PaginatedList<Course>> GetNotSubscribedByUserId(string userId, int? page = 0, int pageSize = 10)
        {
            return await this.coursePager.UseQuery(this.GetNotSubscribedByUserIdQuery(userId), page, pageSize);
        }

        public async Task<int> AddAsync(Course course)
        {
            this.dbContext.Add(course);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Course course)
        {
            this.dbContext.Update(course);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Course course)
        {
            this.dbContext.Remove(course);
            return await this.dbContext.SaveChangesAsync();
        }

        public bool ExistsById(int id)
        {
            return this.dbContext.Courses.Any(c => c.Id == id);
        }

        /// <summary>
        /// Register student to course.
        /// </summary>
        /// <param name="userId">Student id</param>
        /// <param name="course">Course object</param>
        /// <returns>True on Successful registration, false otherwise.</returns>
        public async Task<bool> RegisterToCourse(string userId, Course course)
        {
            if (!this.ExistsById(course.Id))
            {
                return false;
            }

            if (!(await this.dbContext.Students.AnyAsync(s => s.Id == userId)))
            {
                return false;
            }

            try
            {
                await this.dbContext.StudentCourse.AddAsync(new StudentCourse() { StudentId = userId, CourseId = course.Id });
                await this.dbContext.SaveChangesAsync();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private IQueryable<Course> GetAllQuery()
        {
            return this.dbContext.Courses.AsNoTracking();
        }

        private IQueryable<Course> GetSubscribedByUserIdQuery(string userId)
        {
            return this.dbContext.StudentCourse.AsNoTracking()
                .Include(sc => sc.Course)
                .Where(sc => sc.StudentId == userId)
                .Select(sc => sc.Course);
        }

        private IQueryable<Course> GetNotSubscribedByUserIdQuery(string userId, PaginatedList<Course> alredySubscribed = null)
        {
            if (alredySubscribed == null)
            {
                return this.dbContext.Courses
                    .Where(c => !this.GetSubscribedByUserIdQuery(userId).Contains(c));
            }
            else
            {
                return this.dbContext.Courses
                    .Where(c => !alredySubscribed.Any(sc => sc.Id == c.Id));
            }
        }
    }
}
