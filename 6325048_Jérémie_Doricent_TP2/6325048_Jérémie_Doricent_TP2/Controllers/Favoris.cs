using Microsoft.AspNetCore.Mvc;
using _6325048_Jérémie_Doricent_TP2.Models;

public class FavorisController : Controller
{
    private readonly BaseDonnes _bd;

    public FavorisController(BaseDonnes bd)
    {
        _bd = bd;
    }

   
    public IActionResult Index()
    {
        
        var ids = HttpContext.Session.Get<List<int>>("favoris")
                  ?? new List<int>();

        var enfants = _bd.enfant
                      .Where(e => ids.Contains(e.Id))
                      .ToList();

        return View(enfants);
    }

    [HttpPost]
    public IActionResult AjouterUnEnfant(int id)
    {
        var ids = HttpContext.Session.Get<List<int>>("favoris")
                  ?? new List<int>();

     
        if (!ids.Contains(id))
            ids.Add(id);

      
        HttpContext.Session.Set("favoris", ids);

        return RedirectToAction("Index");
    }

   
    [HttpPost]
    public IActionResult SupprimerUnEnfant(int id)
    {
 
        var ids = HttpContext.Session.Get<List<int>>("favoris")
                  ?? new List<int>();

        ids.Remove(id);

        HttpContext.Session.Set("favoris", ids);

      
        return RedirectToAction("Index");
    }
}