using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library.Classes
{
    class LivroDAO
    {
        public void Criar()
        {
            try
            {
                string sql = "CREATE TABLE IF NOT EXISTS livro (ISBN VARCHAR(13) NOT NULL, Titulo VARCHAR(100) NOT NULL, Subtitulo VARCHAR(100), Pg VARCHAR(4) NULL, Ano VARCHAR(4) NULL, Edicao VARCHAR(3) NULL, Idioma VARCHAR(45) NULL, Autor_idAutor INT NOT NULL, Editora_idEditora INT NOT NULL, Status INT NOT NULL, Estante INT NOT NULL,  Emprestimo INT NOT NULL, PRIMARY KEY (ISBN, Autor_idAutor, Editora_idEditora), FOREIGN KEY (Autor_idAutor) REFERENCES autor (idAutor), FOREIGN KEY (Editora_idEditora) REFERENCES Editora (idEditora))";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Inserir(Livro livro)
        {
            try
            {
                string sql = "INSERT INTO livro (ISBN, Titulo, Subtitulo, Pg, Ano, Edicao, Idioma, Autor_idAutor, Editora_idEditora, Status, Estante, Emprestimo) VALUES('" + livro.ISBN + "','" + livro.Titulo + "','" + livro.Subtitulo + "','" + livro.Pg + "','" + livro.Ano + "','" + livro.Edicao + "','" + livro.Idioma + "','" + livro.Autor + "','" + livro.Editora + "','" + livro.Status + "','" + livro.Estante + "','"+livro.Emprestimo+"');";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Alterar(Livro livro)
        {
            try
            {
                string sql = "UPDATE livro SET Titulo='" + livro.Titulo + "', Subtitulo='" + livro.Subtitulo + "', Pg='" + livro.Pg + "', Ano='" + livro.Ano + "', Edicao='" + livro.Edicao + "', Idioma='" + livro.Idioma + "', Status="+livro.Status+", Estante="+livro.Estante+", Emprestimo="+livro.Emprestimo+" WHERE ISBN = "+livro.ISBN+";";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Excluir(Livro livro)
        {
            try
            {
                string sql = "DELETE FROM livro WHERE ISBN='"+livro.ISBN+"';";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

    }
}
