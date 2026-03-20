using System.Collections.Generic;
using System.Linq;

namespace BibliotecaMVC.Models
{
    public static class BibliotecaCatalogo
    {

        public static List<Autor> Autores = new List<Autor>
        {
            new Autor
            {
                Id = 1,
                Nome = "George R. R. Martin",
                DataNascimento = "1948",
                Foto = "/img/martin.jpg",
                Biografia = "Autor da série As Crônicas de Gelo e Fogo."
            },

            new Autor
            {
                Id = 2,
                Nome = "Mary Shelley",
                DataNascimento = "1797",
                Foto = "/img/shelley.jpg",
                Biografia = "Autora de Frankenstein."
            },

            new Autor
            {
                Id = 3,
                Nome = "Robert Louis Stevenson",
                DataNascimento = "1850",
                Foto = "/img/stevenson.jpg",
                Biografia = "Autor de O Médico e o Monstro."
            },

            new Autor
            {
                Id = 4,
                Nome = "Stephen King",
                DataNascimento = "1947",
                Foto = "/img/king.jpg",
                Biografia = "Um dos maiores autores de terror."
            },

            new Autor
            {
                Id = 5,
                Nome = "William Gibson",
                DataNascimento = "1948",
                Foto = "/img/gibson.jpg",
                Biografia = "Autor pioneiro do cyberpunk."
            }
        };

        public static List<Livro> Livros = new List<Livro>
        {
            new Livro
            {
                Id = 1,
                Titulo = "Guerra dos Tronos",
                Capa = "/img/got.jpg",
                Descricao = "Primeiro livro da saga As Crônicas de Gelo e Fogo.",
                Ano = 1996,
                AutorId = 1
            },

            new Livro
            {
                Id = 2,
                Titulo = "Frankenstein",
                Capa = "/img/frankenstein.jpg",
                Descricao = "História de um cientista que cria vida artificial.",
                Ano = 1818,
                AutorId = 2
            },

            new Livro
            {
                Id = 3,
                Titulo = "O Médico e o Monstro",
                Capa = "/img/medico-monstro.jpg",
                Descricao = "Clássico da literatura sobre dualidade humana.",
                Ano = 1886,
                AutorId = 3
            },

            new Livro
            {
                Id = 4,
                Titulo = "It: A Coisa",
                Capa = "/img/it.jpg",
                Descricao = "Um grupo de crianças enfrenta um ser maligno.",
                Ano = 1986,
                AutorId = 4
            },

            new Livro
            {
                Id = 5,
                Titulo = "Neuromancer",
                Capa = "/img/neuromancer.jpg",
                Descricao = "Clássico do cyberpunk.",
                Ano = 1984,
                AutorId = 5
            }
        };

    }
}