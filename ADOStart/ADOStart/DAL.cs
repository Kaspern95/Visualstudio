using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOStart
{
    static class DAL
    {
        public static List<Kommune> GetAllMunicipalities()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=WindmillDB; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Municip";
            con.Open();
            reader = cmd.ExecuteReader();
            List<Kommune> kommuner = new List<Kommune>();
 
            while (reader.Read())
            {
                kommuner.Add(new Kommune(reader[0].ToString(),(int)reader[1]));
            }
            con.Close();
            return kommuner;

        }
        public static void InsertKommune(string name, int population)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=WindmillDB; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO Municip ([MunicipalityName],[PopulationNr]) VALUES ('{name}',{population})";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void InsertKommuneSafe(string name, int population)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PersonDB; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            AddParam(cmd, name, "Kommune", SqlDbType.NVarChar);
            AddParam(cmd, population, "Population", SqlDbType.Int);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Person ([name],[age]) VALUES (@Kommune, @Population)";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void AddParam(SqlCommand cmd, object value, string name, SqlDbType sqlDbType)
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
