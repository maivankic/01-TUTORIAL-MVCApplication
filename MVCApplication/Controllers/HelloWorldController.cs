using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using System.Collections.Generic;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // "Fake baza" u memoriji (ostaje dok je aplikacija pokrenuta)
        private static List<Dog> dogs = new List<Dog>();

        // GET: /HelloWorld
        public IActionResult Index()
        {
            return View(dogs);
        }

        // GET: /HelloWorld/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /HelloWorld/Create
        [HttpPost]
        public IActionResult Create(Dog dog)
        {
            if (ModelState.IsValid)
            {
                dogs.Add(dog); // dodaj psa u listu
                return RedirectToAction("Index");
            }

            return View(dog);
        }
    }
}


