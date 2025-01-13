using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceASP.Controllers
{
    public class ContactController : Controller
    {
        // GET : /Contact/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET : /Contact/Details
        public IActionResult Details()
        {
            return View();
        }

        // GET : /Contact/Create
        public IActionResult Create()
        {
            return View();
        }
    
}
}
