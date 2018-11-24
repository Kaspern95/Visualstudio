using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WPFDatabase
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
            con.Open();
            cmd.CommandText = $"INSERT INTO Person VALUES (@Name, @Age)";
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static List<Person> AllPeople()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Person";
            con.Open();
            reader = cmd.ExecuteReader();
            List<Person> allPeople = new List<Person>();

            while (reader.Read())
            {
                allPeople.Add(new Person(reader[1].ToString(), (int)reader[2]));
            }
            con.Close();

            return allPeople;
        }
        public static void UpdatePerson(string name, int age, string newName, int newAge)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE PERSON SET name = '{newName}', age = {newAge} WHERE name = '{name}' AND age = {age}";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void UpdatePerson(string name, string newName, int newAge)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE PERSON SET name = '{newName}', age = {newAge} WHERE name = '{name}'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdatePerson(int age, string newName, int newAge)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE PERSON SET name = '{newName}', age = {newAge} WHERE age = {age}";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void DeletePerson(string name, int age)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            AddParam(cmd, name, "Name", SqlDbType.NVarChar);
            AddParam(cmd, age, "Age", SqlDbType.Int);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Person WHERE name = @Name AND age = @Age";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static List<Person> SelectPerson(string name, int age)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = con;
            AddParam(cmd, name, "Name", SqlDbType.NVarChar);
            AddParam(cmd, age, "Age", SqlDbType.Int);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Person";
            con.Open();
            reader = cmd.ExecuteReader();

            List<Person> selectPerson = new List<Person>();
            while (reader.Read())
            {
                if (reader[1].ToString() == name && (int)reader[2] == age)
                {
                    selectPerson.Add(new Person(reader[1].ToString(), (int)reader[2]));
                }
            }

            con.Close();
            return selectPerson;
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
    }
}
