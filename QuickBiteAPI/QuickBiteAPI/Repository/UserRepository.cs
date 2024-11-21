using QuickBiteAPI.Models;
using Npgsql;
using System.Net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace QuickBiteAPI.Repository
{
    public class UserRepository : IUser
    {
        private readonly string _connectionString;
        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }       
        public void addUser(UserModel user)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    string sqlQuery = "";
                    conn.Open();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public IEnumerable<UserModel> getUsers()
        {
            var users = new List<UserModel>();
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    string sqlQuery = "select * from Users";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, conn);
                    conn.Open();
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var userData = new UserModel()
                        {
                            userId = (int)reader["userId"],
                            userName = Convert.ToString((string)reader["userName"]),
                            email = Convert.ToString((string)reader["email"]),
                            phone = Convert.ToString((string)reader["phone"]),
                            address = Convert.ToString((string)reader["address"]),
                            passwordHash = Convert.ToString((string)reader["passwordHash"]),
                            userRole = Convert.ToString((string)reader["userRole"]),
                            createdAt = Convert.ToDateTime(reader["createdAt"]),
                        };
                        users.Add(userData);
                    }
                    return users;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
