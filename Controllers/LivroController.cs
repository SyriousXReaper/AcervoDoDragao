using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Detalhes(int id)
        {
            var livro = BibliotecaCatalogo.Livros.FirstOrDefault(l => l.Id == id);

            if (livro == null)
                return NotFound();

            livro.Autor = BibliotecaCatalogo.Autores.FirstOrDefault(a => a.Id == livro.AutorId);

            return View(livro);
        }
    }
}