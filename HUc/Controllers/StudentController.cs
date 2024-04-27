using HUc.Data;
using HUc.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HUc.Controllers
{
    public class StudentController : Controller
    {
        HosinOldTestingContext _context=new HosinOldTestingContext();
        public async Task<IActionResult> Index(int? page, string query)
        {
            ViewBag.SearchQuery = query;

            var queryableData = _context.UseresUsers.Include(u => u.Dep).Where(u => u.IsStaff == false);

            if (!string.IsNullOrEmpty(query))
            {
                queryableData = queryableData.Where(u =>
                    u.FullName.Contains(query) ||
                    u.Username.Contains(query) ||
                    u.Email.Contains(query) ||
                    u.Dep.Name.Contains(query));
            }

            var pageSize = 20;
            var totalStudents = await queryableData.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalStudents / pageSize);

            page = Math.Max(page ?? 1, 1);
            page = Math.Min(page ?? 1, totalPages);

            ViewBag.CurrentPage = page;

            var students = await queryableData
                .Skip(((int)page - 1) * pageSize)
                .Take(pageSize)
                .Select(u => new StudentTableVM
                {
                    Id = u.Id,
                    Img = u.PersonalPhoto,
                    Name = u.FullName,
                    User_name = u.Username,
                    Dept = u.Dep != null ? u.Dep.Name : null,
                    Email = u.Email,
                    Attendace_type = u.Edu
                })
                .ToListAsync();

            ViewBag.TotalPages = totalPages;

            return View(students);
        }

        //[HttpGet]
        public async Task<IActionResult> Search(int? page, string query)
        {
            return RedirectToAction("Index", new { page = page ?? 1, query = query });
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
