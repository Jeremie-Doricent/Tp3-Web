using _6325048_Jérémie_Doricent_TP2.Models;
using _6325048_Jérémie_Doricent_TP2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace _6325048_Jérémie_Doricent_TP2.Controllers
{
    public class EnfantController : Controller
    {
        private readonly BaseDonnes _bd;

       
        public EnfantController(BaseDonnes bd)
        {
            _bd = bd;
        }

        
        public IActionResult Recherche()
        {
            var model1 = new PageRechercheViewModel();
            model1.Criteres = new CritereRechercheViewModel();
            model1.Criteres.Est = true;
            model1.Criteres.Ouest = true;
            model1.Criteres.estjoueur = true;
            model1.Resultat = _bd.enfant.ToList();
           
            return View(model1);
        }
        [Route("enfant/detail/{id:int}")]   
        [Route("enfant/{id:int}")]          
        [Route("{id:int}")]
        public IActionResult Detail(int id)
        {
            foreach (Enfant enfant  in _bd.enfant)
            {
              
                List<int> listeEnfant = HttpContext.Session.Get<List<int>>("EnfantID");

                if (enfant.Id == id)
                {
                    if (listeEnfant == null)
                    {
                        listeEnfant = new List<int>();
                    }

                    
                    listeEnfant.Add(id);

                
                    HttpContext.Session.Set<List<int>>("EnfantID", listeEnfant);

                   Enfant rare = _bd.enfant.Where(d => d.Id == id).Single();
                   ;
                }
            }
        
            return RedirectToAction("Index","favoris", id);
        }

        public IActionResult Detail(string nom)
        {
            var enfantTrouve = _bd.enfant
                .Where(e => e.Nom == nom)
                .SingleOrDefault();

            if (enfantTrouve == null)
            {
                return View("NonTrouve");
            }

            return View(enfantTrouve);
        }

        public IActionResult Filtrer(CritereRechercheViewModel critere)
        {
            IEnumerable<Enfant> donnes = _bd.enfant;

            if (critere.Nom != null && critere.Nom != "")
                donnes = donnes.Where(f => f.Nom.ToLower().Contains(critere.Nom.ToLower()));

            var test = donnes.ToList();

            if (critere.Est == true)
                donnes = donnes.Where(f => f.IdParent == 1 );

            
           
            if (critere.Ouest == true)
                donnes = donnes.Where(f => f.IdParent == 2); 

            if (critere.estjoueur == true)
                donnes = donnes.Where(f => f.IdParent == 3);

            if (critere.Est == false && critere.Ouest == false && critere.estjoueur == false && critere.Nom == null && critere.Nom == "")
            {
                donnes = _bd.enfant.ToList();
            }
               
            PageRechercheViewModel pageRechercheViewModel = new PageRechercheViewModel();
            pageRechercheViewModel.Resultat = donnes.ToList();
            pageRechercheViewModel.Criteres = critere;

            return View( "Recherche",pageRechercheViewModel);
        }
    }
}
