using MySql.Data.MySqlClient;
using PRACTICA.connection;
using PRACTICA.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA.dao
{
    class LoginDAO
    {
        private MySqlConnection dbConn = new DBConnection().getConnection();

        public bool login(Person person)
        {
            /*string query = string.Format("call login('{0}', '{1}')", person.id, person.password);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int respN = (int)reader["N"];
            object respADM = (respN == 1) ? (int)reader["IS_ADM"] : 0;

            reader.Close();
            dbConn.Close();*/

            return true;
        }
    }
}
