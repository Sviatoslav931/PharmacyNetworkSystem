using PharmaEntities;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace PharmaRepositories
{
    public class SqlUserRepository : IUserRepository
    {
        #region Queries

        private const string spGetUserByLoginQuery = "spGetUserByLogin";

        #endregion

        #region Private Fields

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlUserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        #region IUserRepository

        public User GetUserByLogin(string login, string password)
        {
            User user = null;
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetUserByLoginQuery;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    using (var reader = command.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            user = new User();
                            user.Id = (int)reader["Id"];
                            user.FirstName = (string)reader["FirstName"];
                            user.Surname = (string)reader["Surname"];
                            user.Login = (string)reader["Login"];
                            user.Role = (string)reader["Role"];
                            var shopId = reader["ShopID"];
                            user.ShopID = (shopId.ToString() == "") ? -1 : (int)shopId;
                            user.Disabled = (bool)reader["Disabled"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
            return user;
        }

        #endregion
    }
}
