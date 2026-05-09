using _6325048_Jérémie_Doricent_TP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _6325048_Jérémie_Doricent_TP2.Controllers
{
    public class HomeController : Controller
    {
        private readonly BaseDonnes _bd;

        
        public HomeController(BaseDonnes bd)
        {
            _bd = bd;
        }

        public IActionResult Index()
        {
            return View(_bd.parent);
        }

    }
}
