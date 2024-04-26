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
        public async Task<IActionResult>  Index()
        {
            
            var users =await _context.UseresUsers.Include(d=>d.Dep).Where(u=>u.IsStaff==false).Take(20).ToListAsync();
            var userViewModels =users.Select(u=>new StudentTableVM
            {
                Id=u.Id,
                Img=  u.PersonalPhoto,
                Name=  u.FullName,
                User_name=u.Username,
                Dept=u.Dep?.Name,
                Email=u.Email,
                Attendace_type = u.Edu,
            }).ToList();

            return View(userViewModels);
        }
        [HttpGet]
        public async Task<IActionResult> Search(string query)
        {
            ViewBag.SearchQuery = query;
                var filteredContent = await _context.UseresUsers.Where(m => m.FullName.StartsWith(query)).ToListAsync();
                var userViewModels = filteredContent.Select(u => new StudentTableVM
                {
                    Id = u.Id,
                    Img = u.PersonalPhoto,
                    Name = u.FullName,
                    User_name = u.Username,
                    Dept = u.Dep?.Name,
                    Email = u.Email,
                    Attendace_type = u.Edu,
                }).ToList();
                return View("Index", userViewModels);      
           
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
