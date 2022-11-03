using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BaseConexão
{
    public class Conexao
    {
        public Boolean conectado { get; set; }
        public String mensagem;
        //Conexões MySQL
        public MySqlConnection cnn = new();
        public MySqlCommand comand = new();
        public MySqlDataReader reader;

        public string sql { get; set; }
        public string server { get; set; }
        public string porta { get; set; }
        public string user { get; set; }
        public string senha { get; set; }
        public string database { get; set; }

        /// <summary>
        /// Cria o objeto de conexão 
        /// </summary>
        /// <param name="_server"></param>
        /// <param name="_porta"></param>
        /// <param name="_user"></param>
        /// <param name="_senha"></param>
        /// <param name="_database"></param>
        public Conexao(string _server, string _porta, string _user, string _senha, string _database)
        {
            conectado = false;

            server = _server;
            porta = _porta;
            user = _user;  
            senha = _senha;
            database = _database;

            conectar();
        }

        public void conectar()
        {
            try
            {
                if (database == "") throw new Exception("Banco não informado");
                cnn.ConnectionString = "server=" + server + ";Port=" + porta + ";uid=" + user + ";pwd=" + senha + ";SslMode=none" + "; database=" + database + ";";
                cnn.Open();
                conectado = true;
                ExecuteMysql();
                comand.CommandTimeout = 300;
                MessageBox.Show("Conectado ao Banco " + database);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conectado = false;
                MessageBox.Show("Erro de conexão " + database + " - " + e.Message);
            }
        }

        public void ExecuteMysql()
        {
            comand.Connection = cnn;
            comand.CommandType = CommandType.Text;
        }

        public bool ComandoSql(String sql)
        {
            cnn.Close();
            comand.CommandText = sql;
            try
            {
                cnn.Open();
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na SQL:: " + e.Message);
                return false;
            }
            return true;
        }

        public void setReader()
        {
            try
            {
                reader = comand.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }



    }
}
