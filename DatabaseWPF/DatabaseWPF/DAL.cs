using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseWPF
{
    class DAL
    {
        public static void CreatePerson(string name, int age)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            AddParam(cmd, name, "Name", SqlDbType.NVarChar);
            AddParam(cmd, age, "Age", SqlDbType.Int);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Person (name, age) VALUES (@Name, @Age)";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private static void AddParam(SqlCommand cmd, object value, string name, SqlDbType sqlDbType)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@" + name;
            parameter.Value = value;
            parameter.SqlDbType = sqlDbType;
            parameter.Size = 255;
            cmd.Parameters.Add(parameter);
        }

        public static List<Person> GetAllPerson()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Person";
            con.Open();
            reader = cmd.ExecuteReader();
            List<Person> persons = new List<Person>();

            while (reader.Read())
            {
                persons.Add(new Person(reader[1].ToString(), (int)reader[2]));
            }
            con.Close();
            return persons;
        }
    }
}
