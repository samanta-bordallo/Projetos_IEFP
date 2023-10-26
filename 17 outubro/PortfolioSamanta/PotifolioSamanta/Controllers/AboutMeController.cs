using Microsoft.AspNetCore.Mvc;

namespace PortfolioSamanta.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
