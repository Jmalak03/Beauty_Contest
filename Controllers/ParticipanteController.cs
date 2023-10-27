using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Beauty_Contest.Controllers
{
    public class ParticipanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        public IActionResult Modificar()
        {
            return View();
        }

    }
}
