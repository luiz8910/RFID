using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ReadTagsSync
{
    class dbConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public dbConnection()
        {
            init();
        }

        private void init()
        {
            server = "localhost";
            database = "RFID";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool openConnection()
        {
            try
            {
                if(Convert.ToString(connection.State) != "Open")
                    connection.Open();
                
                return true;
            }

            catch (MySqlException ex) {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Insert(String nome, String id_leitura)
        {
            string query = "Insert into leitura (id_nome, qtde, id_leitura) values('" + nome + "','1', '"+ id_leitura + "')";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.ExecuteNonQuery();
        }

        public void Update(String nome, String id_leitura)
        {
            string select = "Select qtde from leitura where id_nome = '" + nome + "' and id_leitura = '" + id_leitura + "'";

            MySqlCommand cmd = new MySqlCommand(select, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int qtde = 0;

            while(reader.Read())
            {
                qtde = Convert.ToInt32(reader["qtde"]);
            }

            reader.Close();

            qtde++;

            string query = "Update leitura set qtde = '"+qtde+"' where id_nome = '"+nome+"'";

            cmd = new MySqlCommand(query, connection);

            cmd.ExecuteNonQuery();
        }

        public string exibirNomeProduto(String palavra)
        {
            if (this.openConnection())
            {
                string query = "Select nome from produtos where palavra = '"+palavra+"'";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                string nome = "";

                while(reader.Read())
                {
                    nome = Convert.ToString(reader["nome"]);
                }

                reader.Close();

                if (nome == null)
                    return null;
                else
                    return nome;
            }
            else {
                Console.WriteLine("Sem conexão com o banco de dados");
            }
            
            return null;
            
        }

        
    }
}
