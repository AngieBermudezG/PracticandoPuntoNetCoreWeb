using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PracticandoPuntoNetCore.Data;
using PracticandoPuntoNetCore.Models;

namespace PracticandoPuntoNetCore.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public LibrosController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Libro> listaLibros = _dbContext.Libro;
            return View(listaLibros);
        }
        
        //Http Get Create
        public IActionResult Create()
        {            
            return View();
        }

        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Libro.Add(libro);
                _dbContext.SaveChanges();

                TempData["mensaje"] = "El libro se ha creado exitosamente";

                return RedirectToAction("Index");
            }
            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            //obtener el libro

            var libro = _dbContext.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Libro.Update(libro);
                _dbContext.SaveChanges();

                TempData["mensaje"] = "El libro se ha actualizado exitosamente";

                return RedirectToAction("Index");
            }
            return View();
        }

        //Http Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //obtener el libro por id
            var libro = _dbContext.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(int? idPlay)
        {
            //obtener Libro por id
            var libro = _dbContext.Libro.Find(idPlay);
            
            if (libro == null)
            {
                return NotFound();
            }
            _dbContext.Libro.Remove(libro);
            _dbContext.SaveChanges();

            TempData["mensaje"] = "El libro se ha Eliminado exitosamente";
            
            return RedirectToAction("Index");           
            
        }
    }
}
