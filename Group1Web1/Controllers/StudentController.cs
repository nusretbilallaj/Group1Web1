using Group1Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group1Web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student studenti1 = new Student("Blend", "Krasniqi");

            return View(studenti1);
        }

        public IActionResult Pershendete()
        {
            string emri = "Ardit Hyseni";
            return View("Pershendete",emri);
        }
    }
}
