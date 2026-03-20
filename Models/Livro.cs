namespace BibliotecaMVC.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Capa { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}