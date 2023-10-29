using System.Data.SqlClient;
using Beauty_Contest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beauty_Contest.Controllers
{
    public class VotacionController : Controller
    {
        private DbContext _context;
        
        public VotacionController(DbContext context)
        {
            _context = context;
        }

        public IActionResult Votar(int Id)
        {
            var concursante = _context.Concursante.FirstOrDefault(c => c.Id == Id);
            if (concursante != null)
            {
                concursante.Votos++;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
