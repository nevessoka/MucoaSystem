using MucoaSystem.model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MucoaSystem.data
{
    public class UserRepository
    {
        
        private const string HOST = "mysql.railway.internal";
        private const string USR = "root";
        private const string PWD = "ZVZBObRlJAinkpUdmOWalkVgMOaoLlkM";
        private const string DATABASE = "Login";
        private string connectionString;
        public UserRepository() { 
            MySqlConnection con = new MySqlConnection();
            this.connectionString = "Server="+HOST+ ";Database= "+DATABASE+"; UID=" + USR+ ";Password=" + PWD+ ";SslMode=None;";
        }

        public User Read(User user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Login.usuarios WHERE nome = @nome and senha=@senha";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nome", user.Name);
                command.Parameters.AddWithValue("@senha", user.Password);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = (int)reader["id"],
                            Name = reader["Nome"].ToString(),
                            Password = reader["senha"].ToString(),
                            //Telefone = reader["Telefone"].ToString(),
                            //Email = reader["Email"].ToString(),
                            //DataNascimento = (DateTime)reader["DataNascimento"],
                            //IsAtivo = (bool)reader["IsAtivo"]
                        };
                    }
                }
            }
            return null;
        }
    }
}
