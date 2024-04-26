using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace OfficePulse
{
    public class User : DbConnection
    {
        private string firstname { get; set; }
        private string lastname { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private int departmentId { get; set; }

        private int roleId { get; set; }

        private bool isAdmin { get; set; }

        public User(string firstname, string lastname, string username, string password, int departmentId, int roleId, bool isAdmin) {

            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.departmentId = departmentId;
            this.roleId = roleId;
            this.isAdmin = isAdmin;

        }

        public User() {
        
        }

        



       

        public void registerUser()
        {
           

            MySqlConnection conn = GetConnection();
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                {
                    cmd.CommandText = "INSERT INTO users (firstname, lastname, username, department_id, role_id, isAdmin) VALUES (@firstname, @lastname, @username, @departmentId, @roleId, @isAdmin)";
                    cmd.Parameters.AddWithValue("@firstname", this.firstname);
                    cmd.Parameters.AddWithValue("@lastname", this.lastname);
                    cmd.Parameters.AddWithValue("@username", this.username);
                    cmd.Parameters.AddWithValue("@departmentId", this.departmentId);
                    cmd.Parameters.AddWithValue("@roleId", this.roleId);
                    cmd.Parameters.AddWithValue("@isAdmin", this.isAdmin);

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    object result = cmd.ExecuteScalar();
                    long userId = result != null ? Convert.ToInt64(result) : 0;

                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(this.password);

                    cmd.CommandText = "INSERT INTO passwords (user_id, hashedpw) VALUES (@userId, @hashedPassword)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void deleteUser(string username)
        {
            MySqlConnection conn = GetConnection();

            conn.Open();
            string sql = "DELETE FROM users WHERE username = @username;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
            conn.Close();
            fillDgvUser();

                    }


        public Dictionary<string, int> GetRoles()
        {
            Dictionary<string, int> roles = new Dictionary<string, int>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT role_id, name FROM Roles";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader["name"].ToString(), Convert.ToInt32(reader["role_id"]));
                        }
                    }
                }
            }

            return roles;
        }

        public DataTable fillDgvUser()
        {
            DataTable dt = new DataTable();
            var conn = GetConnection();

            conn.Open();
            string sql = "SELECT users.user_id, users.username, users.firstname, users.lastname, department.name AS department_name, roles.name AS role_name FROM users INNER JOIN department ON users.department_id = department.department_id INNER JOIN roles ON users.role_id = roles.role_id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);



            conn.Close();

            return dt;
        }

    }



   
    
}