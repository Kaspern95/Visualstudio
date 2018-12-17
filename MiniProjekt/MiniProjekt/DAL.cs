using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MiniProjekt
{
    static class DAL
    {

        public static void CreateProduct(string name, int isAvailable)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            AddParam(cmd, name, "Name", SqlDbType.NVarChar);
            AddParam(cmd, isAvailable, "IsAvailable", SqlDbType.Int);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Product VALUES (@Name, @IsAvailable)";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static List<Booking> GetAllBookings()
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Booking";
            con.Open();
            reader = cmd.ExecuteReader();
            List<Booking> booking = new List<Booking>();
            while (reader.Read())
            {
                booking.Add(new Booking((int)reader[0], (System.DateTime)reader[1], (System.DateTime)reader[2], (string)reader[3]));
            }
            con.Close();

            return booking;
        }
        public static List<Product> CheckProduct()
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Product";
            con.Open();
            reader = cmd.ExecuteReader();
            List<Product> product = new List<Product>();
            while (reader.Read())
            {
                product.Add(new Product((int)reader[0], (string)reader[1], (bool)reader[2]));
            }
            con.Close();

            return product;
        }
        public static void Login(string mail)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            AddParam(cmd, mail, "Mail", SqlDbType.NVarChar);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [User] WHERE Mail = @Mail";
            con.Open();
            reader = cmd.ExecuteReader();
            List<User> user = new List<User>();
            while (reader.Read())
            {
                user.Add(new User((int)reader[0], (string)reader[1], (string)reader[2], (bool)reader[3]));
            }
            con.Close();
        }
        public static void DeleteProduct(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            AddParam(cmd, id, "ID", SqlDbType.Int);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Product WHERE ID = @ID";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void EditProduct(string name, int isAvailable, int id)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            AddParam(cmd, name, "Name", SqlDbType.NVarChar);
            AddParam(cmd, isAvailable, "IsAvailable", SqlDbType.Int);
            AddParam(cmd, id, "ID", SqlDbType.Int);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Product SET Name=@Name, Available=@IsAvailable WHERE ID=@ID";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Lend(Booking lend, Product product, User person)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=BookingSystem; Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            AddParam(cmd, product.Name, "ProductName", SqlDbType.NVarChar);
            AddParam(cmd, product.Id, "ProductId", SqlDbType.Int);
            AddParam(cmd, lend.StartDate, "StartDate", SqlDbType.DateTime);
            AddParam(cmd, lend.Duration, "Duration", SqlDbType.Int);
            AddParam(cmd, person.Mail, "Mail", SqlDbType.NVarChar);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO Booking VALUES (@StartDate,@Duration,@ProductName,(SELECT ID FROM [User] WHERE Mail = @Mail),(SELECT ID FROM Product WHERE Name = @ProductName AND ID = @ProductId))";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void AddParam(SqlCommand cmd, object value, string name, SqlDbType sqlDbType)
        {
            SqlParameter prm = new SqlParameter();
            prm.ParameterName = "@" + name;
            prm.Value = value;
            prm.SqlDbType = sqlDbType;
            prm.Size = 255;
            cmd.Parameters.Add(prm);

        }
    }
}
