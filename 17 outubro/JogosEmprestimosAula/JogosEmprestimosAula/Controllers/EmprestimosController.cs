using JogosEmprestimosAula.Data;
using JogosEmprestimosAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosEmprestimosAula.Controllers
{
    public class EmprestimosController : Controller
    {
        readonly private ApplicationDBContext _db;

        
        public EmprestimosController(ApplicationDBContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos= _db.Emprestimos;


            return View(emprestimos);
        }
    }
}
