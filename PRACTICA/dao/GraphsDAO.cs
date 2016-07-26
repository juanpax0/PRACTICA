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
    class GraphsDAO
    {
        private MySqlConnection dbConn = new DBConnection().getConnection();

        public GraphsDAO() { }

        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>();
            string query = "call get_products";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string name = reader["NAME"].ToString();
                int quotationNum = (int)reader["QUOTATION_NUM"];

                Product h = new Product(id, name, quotationNum);
                products.Add(h);
            }

            reader.Close();
            dbConn.Close();

            return products;
        }

        public List<Product> getTopProducts(int top)
        {
            List<Product> products = new List<Product>();
            string query = string.Format("call get_top_products({0})", top);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string name = reader["NAME"].ToString();
                int quotationNum = (int)reader["QUOTATION_NUM"];

                Product p = new Product(id, name, quotationNum);
                products.Add(p);
            }

            reader.Close();
            dbConn.Close();

            return products;
        }

        public List<Product> getTopServices(int top)
        {
            List<Product> products = new List<Product>();
            string query = string.Format("call get_top_services({0})", top);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string name = reader["NAME"].ToString();
                int quotationNum = (int)reader["QUOTATION_NUM"];

                Product p = new Product(id, name, quotationNum);
                products.Add(p);
            }

            reader.Close();
            dbConn.Close();

            return products;
        }

        public List<NoProduct> getBottomProducts(int top)
        {
            List<NoProduct> products = new List<NoProduct>();
            string query = string.Format("call get_bottomtop_products({0})", top);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["NAME"].ToString();
                int quotationNum = (int)reader["QUOTATION_NUM"];

                NoProduct p = new NoProduct(name, quotationNum);
                products.Add(p);
            }

            reader.Close();
            dbConn.Close();

            return products;
        }

        public List<NoProduct> getBottomServices(int top)
        {
            List<NoProduct> products = new List<NoProduct>();
            string query = string.Format("call get_bottomtop_services({0})", top);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["NAME"].ToString();
                int quotationNum = (int)reader["QUOTATION_NUM"];

                NoProduct p = new NoProduct(name, quotationNum);
                products.Add(p);
            }

            reader.Close();
            dbConn.Close();

            return products;
        }

        public List<Family> getFamilies(string from, string until)
        {
            List<Family> families = new List<Family>();
            string query = string.Format("call get_families('{0}', '{1}')", from, until);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["FAMILY"].ToString();
                int n = int.Parse(reader["N"].ToString());

                Family f = new Family(name, n);
                families.Add(f);
            }

            reader.Close();
            dbConn.Close();

            return families;
        }

    }
}
