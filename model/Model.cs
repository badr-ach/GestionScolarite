using System;
using System.Data;
using System.Collections.Generic;
using System.Reflection;

namespace DB
{
    public abstract class Model
    {
        public int id = 0;

        public Model(){
            Connection.Connect();
        }

        public int Delete(string procedureName = "") {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("id", id);
                return Connection.IUD(procedureName, parameters);
            }
            catch (Exception ex)
            {
                string sql = "Delete from " + this.GetType().Name + "s where id = " + id;
                Console.WriteLine(sql);
                return Connection.IUD(sql);
            }
        }

        public int Save(string procedureName = "")
        {
            if (id == 0)
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    FieldInfo[] fields = this.GetType().GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name == "id") continue;
                        parameters.Add(fields[i].Name,fields[i].GetValue(this));
                    }

                    return Connection.IUD(procedureName, parameters);

                }
                catch (Exception ex)
                {
                    string sql = "insert into " + this.GetType().Name + "s (";
                    FieldInfo[] fields = this.GetType().GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name == "id") continue;
                        sql += fields[i].Name + ",";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ") values (";
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name == "id") continue;
                        sql += "'" + fields[i].GetValue(this) + "',";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ")";
                    Console.WriteLine(sql);
                    return Connection.IUD(sql);
                }
            }
            else
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    FieldInfo[] fields = this.GetType().GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        parameters.Add(fields[i].Name, fields[i].GetValue(this));
                    }

                    return Connection.IUD(procedureName, parameters);

                }
                catch(Exception ex)
                {
                    string sql = "Update " + this.GetType().Name + "s set ";
                    FieldInfo[] fields = this.GetType().GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name == "id") continue;
                        sql += fields[i].Name + "='" + fields[i].GetValue(this) + "',";

                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += " where id = " + this.id;
                    Console.WriteLine(sql);
                    return Connection.IUD(sql);
                }
            }
        }

        public dynamic Find() {
            string sql = "Select * from " + this.GetType().Name + "s where id = " + this.id;
            IDataReader dr = Connection.Select(sql);
            dynamic instance = Activator.CreateInstance(this.GetType());
            while (dr.Read())
            {
                FieldInfo[] fields = instance.GetType().GetFields();
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(instance, dr.GetValue(dr.GetOrdinal(fields[i].Name)));
                }
            }
            dr.Close();
            return instance;
        }

        public static dynamic find<T>(int id)
        {
            string sql = "Select * from " + typeof(T).Name + "s where id = " + id;
            IDataReader dr = Connection.Select(sql);
            dynamic instance = Activator.CreateInstance(typeof(T));
            while (dr.Read())
            {
                FieldInfo[] fields = instance.GetType().GetFields();
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(instance, dr.GetValue(dr.GetOrdinal(fields[i].Name)));
                }
            }
            dr.Close();
            return instance;
        }

        public List<dynamic> All() {
            string sql = "Select * from " + this.GetType().Name+ "s";
            List<dynamic> res = new();
            IDataReader dr = Connection.Select(sql);
            while (dr.Read())
            {
                dynamic instance = Activator.CreateInstance(this.GetType());
                FieldInfo[] fields = instance.GetType().GetFields();
                for(int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(instance, dr.GetValue(dr.GetOrdinal(fields[i].Name)));
                }
                res.Add(instance);
            }
            dr.Close();
            return res;
        }

        public static List<dynamic> all<T>()
        {
            string sql = "Select * from " + typeof(T).Name + "s";
            List<dynamic> res = new();
            Console.WriteLine(sql);
            IDataReader dr = Connection.Select(sql);
            while (dr.Read())
            {
                dynamic instance = Activator.CreateInstance(typeof(T));
                FieldInfo[] fields = instance.GetType().GetFields();
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(instance, dr.GetValue(dr.GetOrdinal(fields[i].Name)));
                }
                res.Add(instance);
            }
            dr.Close();
            return res;
        }

        public List<dynamic> Select(Dictionary<string,object> dico)
        {

            string sql = "Select * from " + this.GetType().Name + "s where ";
            foreach(KeyValuePair<string,object> kp in dico)
            {
                sql += kp.Key.ToLower() + "='" + kp.Value.ToString() + "' and ";
            }
            sql = sql.Remove(sql.Length - 4);
            Console.WriteLine(sql);
            List<dynamic> res = new();
            IDataReader dr = Connection.Select(sql);
            while (dr.Read())
            {
                dynamic instance = Activator.CreateInstance(this.GetType());
                FieldInfo[] fields = instance.GetType().GetFields();
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(instance, dr.GetValue(dr.GetOrdinal(fields[i].Name)));
                }
                res.Add(instance);
            }
            dr.Close();
            return res;
        }

        public static List<dynamic> select<T>(Dictionary<string, object> dico)
        {

            string sql = "Select * from " +typeof(T).Name + "s where ";
            foreach (KeyValuePair<string, object> kp in dico)
            {
                sql += kp.Key + "='" + kp.Value.ToString() + "' and ";
            }
            sql = sql.Remove(sql.Length - 4);
            Console.WriteLine(sql);
            List<dynamic> res = new();
            IDataReader dr = Connection.Select(sql);
            while (dr.Read())
            {
                dynamic instance = Activator.CreateInstance(typeof(T));
                FieldInfo[] fields = instance.GetType().GetFields();
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i].SetValue(instance, dr.GetValue(dr.GetOrdinal(fields[i].Name)));
                }
                res.Add(instance);
            }
            dr.Close();
            return res;
        }
    }
}
