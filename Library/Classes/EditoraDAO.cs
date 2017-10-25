using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library.Classes
{
    class EditoraDAO
    {
        public void Criar()
        {
            try
            {
                string sql = "CREATE TABLE IF NOT EXISTS editora (idEditora INT NOT NULL AUTO_INCREMENT, Nome VARCHAR(45) NOT NULL, PRIMARY KEY(idEditora))";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Inserir(Editora editora)
        {
            try
            {
                string sql = "INSERT INTO editora (Nome) VALUES('" + editora.Nome + "');";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Alterar (Editora editora, int id)
        {
            try
            {
                string sql = "UPDATE editora SET Nome = '"+editora.Nome+"' WHERE idEditora = "+id+";";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Excluir(Editora editora, int id)
        {
            try
            {
                string sql = "DELETE FROM editora WHERE idEditora='" + id + "';";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
