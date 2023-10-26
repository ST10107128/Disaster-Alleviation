using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Disaster_Alleviation.Controllers
{
    public class DonationsController : Controller
    {
        // GET: DonationsController1
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        // GET: DonationsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonationsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonationsController1/Create
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

        // GET: DonationsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonationsController1/Edit/5
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

        // GET: DonationsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonationsController1/Delete/5
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
