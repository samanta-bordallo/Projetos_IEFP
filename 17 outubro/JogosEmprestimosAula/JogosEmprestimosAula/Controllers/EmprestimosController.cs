﻿using JogosEmprestimosAula.Data;
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

        [HttpGet]
        public IActionResult NovoRegisto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovoRegisto(EmprestimosModel emprestimos)
        {
            if(ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult EditarRegisto(int? id)
        {
            if(id == null)
            {
                return NotFound(); 
            }
            EmprestimosModel emprestimos = _db.Emprestimos.FirstOrDefault(x => x.Id == id);
            if(emprestimos == null)
            {
                return NotFound(id);
            }

            return View(emprestimos);
        }
    }
}
