using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T3_PILCO_JOSE.Datos;
using T3_PILCO_JOSE.Models;

namespace T3_PILCO_JOSE.Controllers
{
 
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibrosController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Index
        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libros;
            return View(lista);
        }
        [Authorize]
        // GET: Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libros.Add(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }
        [Authorize]

        // GET: Editar
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Libros.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
      

        // POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libros.Update(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }
        [Authorize]

        // GET: Eliminar
        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Libros.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro libro)
        {
            if (libro == null)
            {
                return NotFound();
            }

            _db.Libros.Remove(libro);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
