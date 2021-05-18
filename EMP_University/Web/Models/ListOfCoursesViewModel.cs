using Common.Models;

using Services.Interfaces;
using Services.Paging;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ListOfCoursesViewModel
    {
        private readonly ICourseService courseService;
        private readonly string userId;

        public ListOfCoursesViewModel(ICourseService courseService, string userId)
        {
            this.courseService = courseService;
            this.userId = userId;
            this.RegisteredCourses = new PaginatedList<Course>(new List<Course>(), 0, 0, 0);
            this.NotRegisteredCourses = new PaginatedList<Course>(new List<Course>(), 0, 0, 0);
        }

        public string ModalMessage { get; set; }

        public PaginatedList<Course> RegisteredCourses { get; set; }

        public PaginatedList<Course> NotRegisteredCourses { get; set; }

        public async Task LoadPageAsync(int registeredCoursesPage = 1, int notRegisteredCoursesPage = 1, int registeredCoursesPageSize = 10, int notRegisteredCoursesPageSize = 10)
        {
            this.RegisteredCourses = await this.courseService.GetSubscribedByUserId(this.userId, registeredCoursesPage, registeredCoursesPageSize);
            this.NotRegisteredCourses = await this.courseService.GetNotSubscribedByUserId(this.userId, notRegisteredCoursesPage, notRegisteredCoursesPageSize);
        }
    }
}
