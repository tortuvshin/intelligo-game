using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Library.Models;

namespace Library.Controllers
{
    public class CatalogsController : Controller
    {
        private ApplicationDbContext _context;

        public CatalogsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Catalogs
        public IActionResult Index()
        {
            return View(_context.Catalog.ToList());
        }

        // GET: Catalogs/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Catalog catalog = _context.Catalog.Single(m => m.Id == id);
            if (catalog == null)
            {
                return HttpNotFound();
            }

            return View(catalog);
        }

        // GET: Catalogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                _context.Catalog.Add(catalog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catalog);
        }

        // GET: Catalogs/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Catalog catalog = _context.Catalog.Single(m => m.Id == id);
            if (catalog == null)
            {
                return HttpNotFound();
            }
            return View(catalog);
        }

        // POST: Catalogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                _context.Update(catalog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catalog);
        }

        // GET: Catalogs/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Catalog catalog = _context.Catalog.Single(m => m.Id == id);
            if (catalog == null)
            {
                return HttpNotFound();
            }

            return View(catalog);
        }

        // POST: Catalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Catalog catalog = _context.Catalog.Single(m => m.Id == id);
            _context.Catalog.Remove(catalog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
