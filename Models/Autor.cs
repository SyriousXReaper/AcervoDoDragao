namespace BibliotecaMVC.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }

        public string Biografia { get; set; }

        public string DataNascimento { get; set; }

        public List<Livro> Livros { get; set; }
    }
}