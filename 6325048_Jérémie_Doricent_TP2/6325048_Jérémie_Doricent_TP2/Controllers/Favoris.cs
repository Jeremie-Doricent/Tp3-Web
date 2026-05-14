using _6325048_Jérémie_Doricent_TP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _6325048_Jérémie_Doricent_TP2.Controllers
{
    public class Favoris : Controller
    {
        private readonly BaseDonnes _bd;
        public Favoris (BaseDonnes bd)
        {
            _bd = bd;
        }
        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }
            var enantsDeLaBD = _bd.enfant.Where(e =>enfantIDs.Contains(e.Id)).ToList();
            return View(enantsDeLaBD);
        }
        public IActionResult Supprimer(int id)
        {
            return View(_bd.enfant.Take(3).ToList());
        }
    }
}
