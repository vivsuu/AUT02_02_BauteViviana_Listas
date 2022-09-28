using AUT02_02_BauteViviana_Listas.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUT02_02_BauteViviana_Listas.Controllers
{
    public class PersonajeController : Controller
    {
        public static List<Personaje> myList = new List<Personaje>();
        public void LPersonajes()
        {
            myList.Add(new Personaje { Id = 1, Name = "Phil", Family = "Dunphy", NChildren = 3 });
            myList.Add(new Personaje { Id = 2, Name = "Gloria Delgado", Family = "Pritchett", NChildren = 1 });

        }
        public IActionResult Index()
        {
            if (myList.Count.Equals(0))
            {
                LPersonajes();
            }
            return View(myList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Personaje newPersonaje)
        {
            if (ModelState.IsValid)
            {
                myList.Add(newPersonaje);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newPersonaje);
            }
        }


    }
}
