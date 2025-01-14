using ExerciceASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceASP.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            // Liste de contacts (modèle)
            List<Contact> contacts = new List<Contact>
            {
                new Contact { Name = "Nathan", Email = "Nathan@gmail.com" },
                new Contact { Name = "Clément", Email = "Clément@gmail.com" },
                new Contact { Name = "Périodique", Email = "Périodique@gmail.com" }
            };

            return View(contacts);
        }

        public IActionResult Details(string name)
        {
            Contact contact = new Contact { Name = name, Email = $"{name.ToLower()}@gmail.com" };
            return View(contact);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
