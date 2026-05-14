using _6325048_Jérémie_Doricent_TP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _6325048_Jérémie_Doricent_TP2.Controllers
{
    public class GestionEnfantController : Controller
    {
        private readonly BaseDonnes _bd;

        public GestionEnfantController(BaseDonnes bd)
        {
            _bd = bd;
        }
        // GET: GestionEnfantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GestionEnfantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionEnfantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionEnfantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionEnfantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionEnfantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int id)
        {
            var enfantBd = _bd.enfant.FirstOrDefault(x => x.Id == id);
            if (enfantBd == null) { return View("non Trouver"); }
            return View(enfantBd);
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var enfantBd = _bd.enfant.FirstOrDefault(x => x.Id == id);

            enfantBd.Parent.Enfant.Remove(enfantBd);

            _bd.enfant.Remove(enfantBd);

            return RedirectToAction("Index", "Home");
        }
    }
}
