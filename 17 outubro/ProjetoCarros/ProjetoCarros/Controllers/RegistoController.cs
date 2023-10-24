using ProjetoCarros.Data;
using ProjetoCarros.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoCarros.Controllers
{
    public class RegistoController : Controller
    {
        readonly private ApplicationDBContext _db;


        public RegistoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CarrosModel> registos = _db.Registo;


            return View(registos);
        }

        [HttpGet]
        public IActionResult NovoRegisto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovoRegisto(CarrosModel registo)
        {
            if (ModelState.IsValid)
            {
                _db.Registo.Add(registo);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registo);
        }

        [HttpGet]
        public IActionResult EditarRegisto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CarrosModel registo = _db.Registo.FirstOrDefault(x => x.Id == id);
            if (registo == null)
            {
                return NotFound(id);
            }

            return View(registo);
        }
        [HttpPost]
        public IActionResult EditarRegisto(CarrosModel registo)
        {
            if (ModelState.IsValid)
            {
                _db.Registo.Update(registo);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registo);


        }


        [HttpGet]
        public IActionResult EliminarRegisto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CarrosModel registo = _db.Registo.FirstOrDefault(x => x.Id == id);
            if (registo == null)
            {
                return NotFound(id);
            }

            return View(registo);
        }

        [HttpPost]
        public IActionResult EliminarRegisto(CarrosModel registo)
        {
            if (registo == null)
            {
                return NotFound();
            }

            _db.Registo.Remove(registo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
