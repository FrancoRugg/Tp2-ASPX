using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.api.Handlers
{
    class MysqlHandler
    {

        public static string GenerarStringBuilder() //Genera conección a bddd
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Database = "tp2";
            builder.UserID = "root";
            builder.Password = "root";

            return builder.ToString();
        }

        public static string GetJson(string query)
        {
            DataTable dt = GetDataTable( query);
            return JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);
        }


        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();

            string connStr = GenerarStringBuilder();
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }

        public static bool Exec(string query)
        {
            bool result = false;

            string connStr = GenerarStringBuilder();
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();
            try
            {
                command.ExecuteReader();
                result = true;

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error : "+ ex);
                result = false;
            }
            conn.Close();
            return result;

        }

    }
}
