using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library.Classes
{
    class Select
    {
        public DataTable preencherComboAutor()
        {
            try
            {
                string sql = "SELECT idAutor, CONCAT(Sobrenome, ',' , Nome) AS Name FROM autor ORDER BY Name";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherCombo(string table, string order)
        {
            try
            {
                string sql = "SELECT * FROM "+table+" ORDER BY "+order+";";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGridMain()
        {
            try
            {
                string sql = "SELECT ISBN, Titulo, CONCAT(Sobrenome, ', ', Nome) AS Autor FROM livro INNER JOIN autor ON Autor_idAutor = idAutor WHERE Estante <> 2 ORDER BY Autor;";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGrid(string type, int value)
        {
            try
            {
                string sql = "SELECT ISBN, Titulo, CONCAT(Sobrenome, ', ', Nome) AS Autor FROM livro INNER JOIN autor ON Autor_idAutor = idAutor WHERE "+type+" = " + value+" ORDER BY Autor;";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGridAutor()
        {
            try
            {
                string sql = "SELECT a.idAutor, a.Nome, a.Sobrenome, (SELECT COUNT(*) FROM livro b WHERE a.idAutor=b.Autor_idAutor ) AS Quantidade FROM autor a;";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGridEditora()
        {
            try
            {
                string sql = "SELECT Nome FROM editora ORDER BY Nome;";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGridLista(int ano)
        {
            try
            {
                string sql = "SELECT ISBN,Titulo,Autor FROM lista WHERE Ano = " + ano + " ORDER BY Autor;";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGridAutorLivro(int id)
        {
            try
            {
                string sql = "SELECT ISBN, Titulo FROM livro INNER JOIN autor ON Autor_idAutor = idAutor WHERE idAutor = '" + id + "';";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable preencherGridCat()
        {
            //string sql = "SELECT L.ISBN, L.Titulo, A.nome FROM livro AS L INNER JOIN livro_has_categoria AS C ON (C.idLivro = L.ISBN) INNER JOIN categoria AS A ON (A.idcategoria = C.idCat);";
            string sql = "Select nome AS Nome FROM categoria ORDER BY nome;";
            return Conexao.ExecutaComando(sql);
        }
        public DataTable preencherGridCatL(string nome)
        {
            string sql = "SELECT L.ISBN, L.Titulo FROM livro AS L INNER JOIN livro_has_categoria AS C ON (C.idLivro = L.ISBN) WHERE C.idCat = (SELECT idcategoria FROM categoria WHERE nome = '" + nome + "');";
            return Conexao.ExecutaComando(sql);
        }
        public string preencherStats(string table, string type, int value)
        {
            string sql = "SELECT Count(*) as Total FROM "+table+" WHERE "+type+" = "+value+";";
            return Conexao.ExComando(sql);
        }
        public string preencherGridStatusT(string cat, string type)
        {
            try
            {
                string sql = "SELECT Titulo FROM livro WHERE "+cat+"=(SELECT "+type+"("+cat+") FROM livro WHERE Estante = 1);";
                return Conexao.ExComando(sql);
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }
        public string preencherGridStatusA(string cat, string type)
        {
            try
            {
                string sql = "SELECT CONCAT(Sobrenome, ', ', Nome) AS Autor FROM livro INNER JOIN autor ON Autor_idAutor = idAutor WHERE "+cat+"=(SELECT "+type+"("+cat+ ") FROM livro WHERE Estante = 1);";
                return Conexao.ExComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public string preencherGridStatusP(string cat, string type)
        {
            try
            {
                string sql = "SELECT "+type+"("+cat+ ") FROM livro WHERE Estante = 1;";
                return Conexao.ExComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public string preencherText(string value, string text)
        {
            string sql = "SELECT " + value + " FROM livro WHERE Titulo='" + text + "';";
            return Conexao.ExComando(sql);
        }
        public string preencherTextA(string text)
        {
            string sql = "SELECT CONCAT(Sobrenome, ',' , Nome) FROM autor INNER JOIN livro ON Autor_idAutor = idAutor WHERE Titulo='" + text + "';";
            return Conexao.ExComando(sql);
        }
        public string preencherTextE(string text)
        {
            string sql = "SELECT Nome FROM editora INNER JOIN livro ON Editora_idEditora = idEditora WHERE Titulo='" + text + "';";
            return Conexao.ExComando(sql);
        }
        public string preencherTextN(string text, string nome)
        {
            string sql = "SELECT "+nome+ " FROM autor WHERE CONCAT(Sobrenome, ', ', Nome) = '" + text + "';";
            return Conexao.ExComando(sql);
        }
        public string selectCoisa(int id, string x)
        {
            string sql = "SELECT "+x+" FROM autor WHERE idAutor = '" + id + "';";
            return Conexao.ExComando(sql);
        }
        public string selectIDEd(string text)
        {
            string sql = "SELECT idEditora FROM editora WHERE Nome = '" + text + "';";
            return Conexao.ExComando(sql);
        }
        public string selectT(string isbn, string thing)
        {
            string sql = "SELECT "+ thing +" FROM livro WHERE ISBN='" + isbn + "';";
            return Conexao.ExComando(sql);
        }
        public string selectSum(string ano)
        {
            string sql = "SELECT SUM(Pg) FROM livro JOIN lista ON livro.isbn = lista.isbn WHERE lista.Ano = "+ano+";";
            return Conexao.ExComando(sql);
        }

    }
}
