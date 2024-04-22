using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HUc.Controllers
{
    public class SectionController : Controller
    {
        // GET: SectionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SectionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SectionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SectionController/Create
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

        // GET: SectionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SectionController/Edit/5
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

        // GET: SectionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SectionController/Delete/5
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
