using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    class Livro
    {
        private string titulo;
        private string subtitulo;
        private string idioma;
        private int edicao;
        private int pg;
        private int ano;
        private string isbn;
        private int status;
        private int estante;
        private int emprestimo;
        private int autor;
        private int editora;

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Subtitulo
        {
            get
            {
                return subtitulo;
            }
            set
            {
                subtitulo = value;
            }
        }
        public int Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public int Editora
        {
            get
            {
                return editora;
            }
            set
            {
                editora = value;
            }
        }
        public string Idioma
        {
            get
            {
                return idioma;
            }
            set
            {
                idioma = value;
            }
        }
        public int Edicao
        {
            get
            {
                return edicao;
            }
            set
            {
                edicao = value;
            }
        }
        public int Pg
        {
            get
            {
                return pg;
            }
            set
            {
                pg = value;
            }
        }
        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }
        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public int Estante
        {
            get
            {
                return estante;
            }
            set
            {
                estante = value;
            }
        }
        public int Emprestimo
        {
            get
            {
                return emprestimo;
            }
            set
            {
                emprestimo = value;
            }
        }
    }
}
