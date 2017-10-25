using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    class CategoriaDAO
    {
        public void Criar()
        {
            try
            {
                string sql = "CREATE TABLE IF NOT EXISTS categoria (idcategoria INT NOT NULL AUTO_INCREMENT, Nome VARCHAR(45) NOT NULL, PRIMARY KEY(idcategoria))";
                string sql2 = "CREATE TABLE IF NOT EXISTS livro_has_categoria (idCat INT NOT NULL, idLivro VARCHAR(13) NOT NULL, PRIMARY KEY(idCat,idLivro), FOREIGN KEY (idCat) REFERENCES categoria (idcategoria), FOREIGN KEY (idLivro) REFERENCES livro (ISBN))";
                Conexao.ExecutaComando(sql);
                Conexao.ExecutaComando(sql2);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Inserir(Categoria cat)
        {
            try
            {
                string sql = "INSERT INTO categoria (nome) VALUES ('" + cat.Nome + "');";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void InserirCat(Categoria cat, Livro livro)
        {
            try
            {
                string sql = "INSERT INTO livro_has_categoria (idCat,idLivro) VALUES ('"+cat.Id+"','"+livro.ISBN+"');";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
