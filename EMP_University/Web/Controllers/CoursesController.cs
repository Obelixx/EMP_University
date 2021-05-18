using Common.Models;

using Microsoft.AspNetCore.Mvc;

using Services.Interfaces;

using System.Threading.Tasks;

namespace Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService coursesService;

        public CoursesController(ICourseService coursesService)
        {
            this.coursesService = coursesService;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            return this.View(await this.coursesService.GetAllAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var course = await this.coursesService.GetFirstOrDefaultById(id.Value);
            if (course == null)
            {
                return this.NotFound();
            }

            return this.View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Start,Ends")] Course course)
        {
            if (this.ModelState.IsValid)
            {
                await this.coursesService.AddAsync(course);
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var course = await this.coursesService.GetById(id.Value);
            if (course == null)
            {
                return this.NotFound();
            }

            return this.View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Start,Ends")] Course course)
        {
            if (id != course.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    await this.coursesService.UpdateAsync(course);
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
                {
                    if (!this.CourseExists(course.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var course = await this.coursesService.GetFirstOrDefaultById(id.Value);
            if (course == null)
            {
                return this.NotFound();
            }

            return this.View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await this.coursesService.GetById(id);
            await this.coursesService.DeleteAsync(course);
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool CourseExists(int id)
        {
            return this.coursesService.ExistsById(id);
        }
    }
}
