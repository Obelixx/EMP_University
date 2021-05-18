using Common.Models;

using Services.Paging;

using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICourseService
    {
        Task<Course> GetFirstOrDefaultById(int id);

        Task<PaginatedList<Course>> GetAllAsync(int? page = 0, int pageSize = 10);

        Task<Course> GetById(int id);

        Task<PaginatedList<Course>> GetSubscribedByUserId(string userId, int? page = 0, int pageSize = 10);

        Task<PaginatedList<Course>> GetNotSubscribedByUserId(string userId, int? page = 0, int pageSize = 10);

        Task<int> AddAsync(Course course);

        Task<int> UpdateAsync(Course course);

        Task<int> DeleteAsync(Course course);

        bool ExistsById(int id);

        Task<bool> RegisterToCourse(string userId, Course course);
    }
}