using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController1 : Controller
    {
        public IActionResult Index()
        {
            Dog dog = new Dog()
            {
                Name = "Rex",
                Age = 2
            };

            return View(dog);
        }
        public string Hello()
        {
            return "Hello from hello action";
        }
    }
}
