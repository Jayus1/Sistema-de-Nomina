using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisNomina
{
    abstract public class BD
    {

        private static string _connectionstring= "Data Source=DESKTOP-4EK1U3G;Initial Catalog=BdNomina;Integrated Security=True";
        public static SqlConnection _connection;

        //public DB(string server, string db, string user, string password)
        //{
        //    _connectionstring = $"Data Source={server}; Initial Catalog={db}: User={user}; Password={password};";
        //}

        public static void Connect()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }
        
        public static void Disconnect()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }

    }
}
