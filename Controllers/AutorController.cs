using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Index()
        {
            return View(BibliotecaCatalogo.Autores);
        }

        public IActionResult Detalhes(int id)
        {
            var autor = BibliotecaCatalogo.Autores
                .FirstOrDefault(a => a.Id == id);

            return View(autor);
        }
    }
}