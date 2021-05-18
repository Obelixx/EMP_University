using Common.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Services.Interfaces;

using System.Threading.Tasks;

using Web.Models;

namespace Web.Controllers
{
    public class ListOfCoursesController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public ListOfCoursesController(ICourseService courseService, UserManager<IdentityUser> userManager)
        {
            this.CourseService = courseService;
            this.userManager = userManager;
        }

        public ICourseService CourseService { get; }

        public string CurrentUserId
        {
            get
            {
                return this.userManager.GetUserId(this.HttpContext.User);
            }
        }

        // GET: ListOfCourses
        public async Task<ActionResult> Index(string message = "", int rp = 1, int nrp = 1, int rs = 5, int nrs = 5)
        {
            var vm = new ListOfCoursesViewModel(this.CourseService, this.CurrentUserId);
            await vm.LoadPageAsync(rp, nrp, rs, nrs);
            vm.ModalMessage = message;
            return this.View(vm);
        }

        // POST: ListOfCourses/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Course course)
        {
            if (this.ModelState.IsValid)
            {
                if (await this.CourseService.RegisterToCourse(this.CurrentUserId, course))
                {
                    return this.RedirectToAction(nameof(this.Index), "ListOfCourses", new { message = "Successfuly registered!" });
                }

                return this.RedirectToAction(nameof(this.Index), "ListOfCourses", new { message = "Not registered!" });
            }

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
