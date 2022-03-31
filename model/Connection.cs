using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace DB
{
    public class Connection
    {
        private static IDbConnection con;
        private static IDbCommand cmd;
        private static Dictionary<string, string> dbConfig = new Dictionary<string, string>();
        public static void Connect()
        {
            if (con == null)
            {
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
                        con = new SqlConnection("Server=" + dbConfig["server"] + ";Database=" + dbConfig["dbname"] + ";User id=" + dbConfig["username"]
                            + ";Password=" + dbConfig["password"]);
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
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();
        }

        public static IDataReader Select(string req)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }

        public static int IUD(string procedurename, Dictionary<string, object> args)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (KeyValuePair<string, object> kp in args)
            {
                cmd.Parameters.Add(CreateParameter(kp.Key,kp.Value));
            }
            cmd.CommandText = procedurename;
            return cmd.ExecuteNonQuery();
        }


        private static IDataParameter CreateParameter(string parameterName, object value)
        {
            IDataParameter parameter = null;
            switch (dbConfig["dialect"].ToLower())
            {
                case "mysql":
                    parameter = new MySqlParameter() { ParameterName = parameterName, Value = value };
                    break;
                case "sqlserver":
                    parameter = new SqlParameter() { ParameterName = parameterName, Value = value };
                    break;
            }
            return parameter;
        }
    }
}
