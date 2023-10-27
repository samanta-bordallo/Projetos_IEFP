using Microsoft.AspNetCore.Mvc;
using PotifolioSamanta.Models;

namespace PortfolioSamanta.Controllers
{
    public class PersonalBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    

    [HttpGet]
    public IActionResult RecipesBlog()
    {
        return View();
    }


    [HttpGet]
    public IActionResult AdventureBlog()
    {
        return View();
    }



    }
}
