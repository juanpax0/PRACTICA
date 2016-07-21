using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA.connection
{
    public class DBConnection
    {
        private const string SERVER = "127.0.0.1";
        private const string DATABASE = "practica";
        private const string UID = "root";
        private const string PASSWORD = "root";

        public DBConnection() { }

        public MySqlConnection getConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            string connString = builder.ToString();

            MySqlConnection dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
            return dbConn;
        }
    }
}
