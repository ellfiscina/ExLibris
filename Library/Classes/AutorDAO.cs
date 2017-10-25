using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library.Classes
{
    class AutorDAO
    {
        public void Criar()
        {
            try
            {
                string sql = "CREATE TABLE IF NOT EXISTS autor (idAutor INT NOT NULL AUTO_INCREMENT, Nome VARCHAR(45) NOT NULL, Sobrenome VARCHAR(45) NOT NULL, PRIMARY KEY(idAutor))";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Inserir(Autor autor)
        {
            try
            {
                string sql = "INSERT INTO autor (Nome, Sobrenome) VALUES('" + autor.Nome + "','" + autor.Sobrenome + "');";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Alterar(Autor autor)
        {
            try
            {
                string sql = "UPDATE autor SET Nome = '"+autor.Nome+"', Sobrenome = '"+autor.Sobrenome+"' WHERE idAutor = "+autor.ID+";";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Excluir(Autor autor)
        {
            try
            {
                string sql = "DELETE FROM autor WHERE idAutor='" + autor.ID + "';";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
