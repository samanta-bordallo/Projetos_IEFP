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
    }
}
