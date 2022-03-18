using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace DB
{
    public class Connection
    {
        private static IDbConnection con;
        private static IDbCommand cmd;

        public static void Connect()
        {
            if (con == null)
            {
                Dictionary<string, string> dbConfig = new Dictionary<string, string>();
                foreach (string line in System.IO.File.ReadLines(@"../../../.env"))
                {
                    string[] tokens = line.Split('=');
                    dbConfig.Add(tokens[0], tokens[1]);
                }
                switch (dbConfig["dialect"].ToLower())
                {
                    case "mysql":
                        Console.WriteLine("here");
                        con = new MySqlConnection("server="+ dbConfig["server"]+";user id="+ dbConfig["username"]
                            +";password="+ dbConfig["password"]+";persistsecurityinfo=True;database="+ dbConfig["dbname"]);
                        cmd = new MySqlCommand();
                        break;
                    case "sqlserver":
                        con = new SqlConnection("server=" + dbConfig["server"] + ";user id=" + dbConfig["username"]
                            + ";password=" + dbConfig["password"] + ";database=" + dbConfig["dbname"]);
                        cmd = new SqlCommand();
                        break;
                }
            }
            if (con.State.ToString() == "Closed")
            {
                con.Open();
                cmd.Connection = con;
            }
        }

        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();
        }

        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }

    }
}
