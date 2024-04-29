using HUc.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HUc.Controllers
{
    public class UserController : Controller
    {
        HosinOldTestingContext context = new HosinOldTestingContext();
        // GET: UserController
        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            int pageSize = 20; // Number of items per page
            var data = context.UseresUsers.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            // Calculate total number of pages
            int totalItems = context.UseresUsers.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            SelectList UserSelectLst = new SelectList(context.UseresUsers.ToList(), "Id", "Role");
            ViewBag.alluser = UserSelectLst;

            return View(data);
        }

        [HttpGet]
        public ActionResult Search(string query)
        {
            ViewBag.SearchQuery = query;
            var filteredContent = context.UseresUsers.Where(m => m.Email.StartsWith(query)).ToList();
            return View("Index", filteredContent);
        }

        public ActionResult Category(string category, int? page)
        {
            ViewBag.cat = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataByCategory(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }


        private List<UseresUser> GetDataByCategory(string category)
        {
            List<UseresUser> data;
            if (category == "الكل")
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.Role == category).ToList();
            }
            return data;
        }
        public ActionResult CategorySex(string category, int? page)
        {
            ViewBag.sex = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataBysex(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }
        private List<UseresUser> GetDataBysex(string category)
        {
            List<UseresUser> data;
            if (category == "الكل")
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.Sex == category).ToList();
            }
            return data;
        }

        public ActionResult CategoryActive( int? page , bool? category)
        {

            ViewBag.Active = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataByActive(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }
        private List<UseresUser> GetDataByActive(bool? category)
        {
            List<UseresUser> data;
            if (!category.HasValue)
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.IsActive == category).ToList();
            }
            //data = context.UseresUsers.Where(x => x.IsActive == category).ToList();
            return data;
        }

        public ActionResult Categoryedu(string category, int? page)
        {
            ViewBag.edu = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataByEdu(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }


        private List<UseresUser> GetDataByEdu(string category)
        {
            List<UseresUser> data;
            if (category == "الكل")
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.Edu == category).ToList();
            }
            return data;
        }

        public ActionResult CategoryDorea(string category, int? page)
        {
            ViewBag.Dorea = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataByDorea(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }


        private List<UseresUser> GetDataByDorea(string category)
        {
            List<UseresUser> data;
            if (category == "الكل")
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.Dorea == category).ToList();
            }
            return data;
        }
        public ActionResult CategoryMainStatus(string category, int? page)
        {
            ViewBag.MainStatus = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataByMainStatus(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }


        private List<UseresUser> GetDataByMainStatus(string category)
        {
            List<UseresUser> data;
            if (category == "الكل")
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.MainStatus == category).ToList();
            }
            return data;
        }
        public ActionResult CategoryMinistrySigned(int? page, bool? category)
        {

            ViewBag.MinistrySigned = category;

            int pageSize = 20;

            int pageNumber = page ?? 1;

            var data = GetDataByMinistrySigned(category);

            int totalItems = data.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            data = data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View("Index", data);
        }
        private List<UseresUser> GetDataByMinistrySigned(bool? category)
        {
            List<UseresUser> data;
            if (!category.HasValue) 
            {
                data = context.UseresUsers.ToList();
            }
            else
            {
                data = context.UseresUsers.Where(x => x.IsActive == category).ToList();
            }
            //data = context.UseresUsers.Where(x => x.MinistrySigned == category).ToList();
            return data;
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpPost]
        // GET: UserController/Create
        public ActionResult Create(string email, string password, string username, string jobTitle, string fullName, string phoneNumber, string permissions, string address)
        {
            UseresUser collection = new UseresUser()
            {
                Email = email,
                Password = password,
                Username = username,
                EnFullName = "",
                PhoneNumber = phoneNumber,
                Adress=address,
                Role=jobTitle,
                FakePasswordEn="",
               FullName="",
               FullNameEn="",
               FirstName="",
               LastName="",
               Roletype=""
            };
            context.UseresUsers.Add(collection);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
