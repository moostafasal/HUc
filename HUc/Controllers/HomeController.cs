using HUc.Models;
using HUc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HUc.Controllers
{
    public class HomeController : Controller
    {
        private readonly HosinOldTestingContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(HosinOldTestingContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CountsVM
            {
                StudentCount = await _context.UseresUsers.CountAsync(s => s.IsStaff == false),
                EmployeeCount = await _context.UseresUsers.CountAsync(s => s.IsStaff == true),
                BatchCount = await _context.DepartmentsYears.CountAsync(d => d.Year != null),
                DeptCount = await _context.DepartmentsDepartments.CountAsync(d => d.Name != null)

            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
