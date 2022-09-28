using AUT02_02_BauteViviana_Listas.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUT02_02_BauteViviana_Listas.Controllers
{
    public class PersonajeController : Controller
    {
        public static List<Personaje> myList = new List<Personaje>()
        {
            new Personaje { Id = 1, Name = "Phil", Family = "Dunphy", NChildren = 3 },
            new Personaje { Id = 2, Name = "Gloria Delgado", Family = "Pritchett", NChildren = 1 }
        };

        public IActionResult Index()
        {
            return View(myList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string Name, string Family, int NChildren)
        {
            if (ModelState.IsValid)
            {
                myList.Add(new Personaje { Id = myList.Count + 1, Name = Name, Family = Family, NChildren = NChildren });
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


    }
}
