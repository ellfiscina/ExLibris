using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library.Classes
{
    class ListaDAO
    {
        public void Criar()
        {
            try
            {
                string sql = "CREATE TABLE IF NOT EXISTS lista (ISBN VARCHAR(13) NOT NULL PRIMARY KEY, Titulo VARCHAR(100), Autor VARCHAR(45), Ano INT(4))";
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void Inserir(Lista lista)
        {
            try
            {

                string sql = "INSERT INTO lista (ISBN, Titulo, Autor, Ano) VALUES('" + lista.ISBN + "','" + lista.Titulo + "','" + lista.Autor + "','" + lista.Ano + "');";

                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
