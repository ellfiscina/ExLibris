using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    class Lista
    {
        private string isbn;
        private string titulo;
        private string autor;
        private int ano;

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
        public string Autor
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
    }
}
