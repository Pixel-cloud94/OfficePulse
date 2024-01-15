using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace OfficePulse
{
    public class User : DbConnection
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string userPassword;
        private string department;
        public bool participation = false;
        public bool isAdmin = false;
        

        public void loadUser()
        {
            GetConnection().Open();

            
        }

        public void deleteUser()
        {
            GetConnection().Open();
        }

        public void registerUser(string firstname, string lastname, string username, int departmentId, int roleId, bool isAdmin, string password)
        {
            SqlConnection conn = GetConnection();
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                {
                    
                    cmd.CommandText = "INSERT INTO users (firstname, lastname, username, department_id, role_id, is_admin) OUTPUT INSERTED.user_id VALUES (@firstname, @lastname, @username, @departmentId, @roleId, @isAdmin)";
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@departmentId", departmentId);
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.Parameters.AddWithValue("@isAdmin", isAdmin);

                    
                    int userId = (int)cmd.ExecuteScalar();

                    
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                    
                    cmd.CommandText = "INSERT INTO user_passwords (user_id, hashed_password) VALUES (@userId, @hashedPassword)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void collectResults()
        {
            GetConnection().Open();
        }
    

    }

   
    
}
