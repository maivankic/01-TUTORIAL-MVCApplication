using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            Dog dog = new Dog()
            {
                Name = "Bobi",
                Age = 3
            };

            return View(dog);
        }
    }
}
