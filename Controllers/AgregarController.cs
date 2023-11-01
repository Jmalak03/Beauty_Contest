using Beauty_Contest.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beauty_Contest.Controllers
{
    public class AgregarController : Controller
    {
        private List<AgregarModel> personasList = new List<AgregarModel>() { };
        public IActionResult Index(AgregarModel persona)
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(AgregarModel persona)
        {


            personasList.Add(persona);

            return View("Index");

        }
    }
}
    
