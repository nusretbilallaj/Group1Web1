using Group1Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group1Web1.Controllers
{
    public class ProfesorController : Controller
    {
        public IActionResult Index()
        {
            Profesor prof = new Profesor("Leron", "Berisha");

            return View(prof);
        }
    }
}
