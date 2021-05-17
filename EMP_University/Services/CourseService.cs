using Common.Interfaces;
using Common.Models;

using Microsoft.EntityFrameworkCore;

using Services.Paging;

using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class CourseService
    {
        private readonly IEMPUniDbContext dbContext;
        private readonly Pager<Course> coursePager;

        public CourseService(IEMPUniDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.coursePager = new Pager<Course>();
        }

        public async Task<Course> GetById(int id)
        {
            return await this.dbContext.Courses.FindAsync(id);
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

        private IQueryable<Course> GetAllQuery()
        {
            return this.dbContext.Courses;
        }

        private IQueryable<Course> GetSubscribedByUserIdQuery(string userId)
        {
            return this.dbContext.StudentCourse
                .Include(sc => sc.Course)
                .Where(sc => sc.StudentId == userId)
                .Select(sc => sc.Course);
        }

        private IQueryable<Course> GetNotSubscribedByUserIdQuery(string userId)
        {
            return this.dbContext.StudentCourse
                .Include(sc => sc.Course)
                .Where(sc => sc.StudentId == userId)
                .Select(sc => sc.Course);
        }
    }
}
