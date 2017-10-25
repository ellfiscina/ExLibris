using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace Library.Classes
{
    class Conexao
    {
        public static string montarStringConexao()
        {
            string servidor = "localhost";
            string banco = "biblioteca";
            string usuario = "root";
            string senha = "";
            string stringConexao = "";

            return stringConexao = ("server=" + servidor + ";database=" + banco + ";user=" + usuario + ";password=" + senha);
        }

        public static MySqlConnection getConexao()
        {
            MySqlConnection con = new MySqlConnection();
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.ConnectionString = montarStringConexao();
                    con.Open();
                    return con;
                }
                else
                {
                    con.Open();
                    return con;
                }
            }
            catch (MySqlException)
            {
                return getConexao();
            }
        }
        public static DataTable ExecutaComando(string sqlComando)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sqlComando, getConexao());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public static string ExComando(string sqlComando)
        {
            string str=null;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(sqlComando, Conexao.getConexao());
                MySqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    str = DR1.GetValue(0).ToString();
                }
                return str;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


    }
}
