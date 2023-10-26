using PotifolioSamanta.Models;
using Microsoft.AspNetCore.Mvc;
using PotifolioSamanta.Data;
using PortfolioSamanta.Models;

namespace PortfolioSamanta.Controllers
{
    public class AboutMeController : Controller
    {
        readonly private ApplicationDBContext _db;


        public AboutMeController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AboutMeModel> AboutMe = _db.AboutMe;


            return View(AboutMe);
        }
    }
}