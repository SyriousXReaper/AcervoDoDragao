using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;
using System.Linq;

namespace BibliotecaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string termo)
        {
            var livros = BibliotecaCatalogo.Livros;

            foreach (var livro in livros)
            {
                livro.Autor = BibliotecaCatalogo.Autores.FirstOrDefault(a => a.Id == livro.AutorId);
            }

            if (!string.IsNullOrEmpty(termo))
            {
                termo = termo.ToLower();

                livros = livros
                    .Where(l =>
                        l.Titulo.ToLower().Contains(termo) ||
                        l.Autor.Nome.ToLower().Contains(termo)
                    )
                    .ToList();
            }

            return View(livros); 
        }
    }
}