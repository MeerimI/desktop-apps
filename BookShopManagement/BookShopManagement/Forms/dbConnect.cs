using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookShopManagement
{
    class dbConnect
    {
        public MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='bookshop';username=root;password=root;CharSet=utf8;");

        public void Execat(string Zapros)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Zapros;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public int ReadData(string Zapros)
        {
            connection.Open();
            int Flag = 0;
            string sql = Zapros;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() != null)
                {
                    Flag = 1;
                }
            }
            connection.Close();
            return Flag;
        }
    }
}
