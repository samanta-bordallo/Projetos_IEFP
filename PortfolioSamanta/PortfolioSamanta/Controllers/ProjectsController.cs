using PotifolioSamanta.Models;
using Microsoft.AspNetCore.Mvc;
using PotifolioSamanta.Data;

namespace PortfolioSamanta.Controllers
{
    public class ProjectsController : Controller
    {
        readonly private ApplicationDBContext _db;


        public ProjectsController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ProjectsModel> projects = _db.Projects;


            return View(projects);
        }

        [HttpGet]
        public IActionResult NewProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewProject(ProjectsModel Projects)
        {
            if (ModelState.IsValid)
            {
                _db.Projects.Add(Projects);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Projects);
        }
        [HttpGet]
        public IActionResult EditProject(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProjectsModel Projects = _db.Projects.FirstOrDefault(x => x.Id == id);
            if (Projects == null)
            {
                return NotFound(id);
            }

            return View(Projects);
        }
        [HttpPost]
        public IActionResult EditProject(ProjectsModel Projects)
        {
            if (ModelState.IsValid)
            {
                _db.Projects.Update(Projects);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Projects);


        }


        [HttpGet]
        public IActionResult DeleteProject(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProjectsModel Projects = _db.Projects.FirstOrDefault(x => x.Id == id);
            if (Projects == null)
            {
                return NotFound(id);
            }

            return View(Projects);
        }

        [HttpPost]
        public IActionResult DeleteProject(ProjectsModel Projects)
        {
            if (Projects == null)
            {
                return NotFound();
            }

            _db.Projects.Remove(Projects);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
