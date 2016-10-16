using PharmaEntities;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace PharmaRepositories
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        #region Queries

        private const string spGetCustomerByCard = "spGetCustomerByCard";

        #endregion

        #region Private Fields

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlCustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        #region ICustomerRepository

        public Customer GetCustomerByCard(int card)
        {
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetCustomerByCard;
                    command.Parameters.AddWithValue("@customerCard", card);
                    using (var reader = command.ExecuteReader())
                    {
                        Customer customer = null;
                        if (reader.Read())
                        {
                            customer = new Customer();
                            customer.Id = (int)reader["customerID"];
                            customer.Card = (int)reader["customerCard"];
                            customer.TotalSumm = Double.Parse(reader["customerTotalSumm"].ToString());
                            customer.Discount = (int)reader["customerDiscount"];
                            customer.Delete = (bool)reader["customerDelete"];
                        }
                        return customer;
                    }
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion
    }
}
