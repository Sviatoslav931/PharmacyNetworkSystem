using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PharmaShop
{
    public partial class MainAdminForm : Form
    {
        const int percentOfSalary = 10;
        public MainAdminForm()
        {
            InitializeComponent();
        }
        
        private void ShowAllUsersExcludeAdmins()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                try
                {
                    connection.Open();

                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spGetAllUsersExcludeAdmin";
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var id = reader[0].ToString();
                        var firstName = reader[1].ToString();
                        var lastName = reader[2].ToString();
                        
                        var currentIndex = dataGridViewEmployees.Rows.Add(id, firstName, lastName);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonShowEmployees_Click(object sender, EventArgs e)
        {
            ShowAllUsersExcludeAdmins();
        }

        private string CalcSalary(string userId, DateTime dateStart, DateTime dateEnd)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand();
                try
                {
                    connection.Open();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"SELECT 
                                                SUM(orderSumm) 
                                            FROM Orders 
                                            WHERE 
                                                userId = "+ userId + 
                                                @" AND(orderDate BETWEEN '" 
                                                + dateStart.ToString("MM/dd/yyyy") 
                                                + "' AND '" 
                                                + dateEnd.ToString("MM/dd/yyyy")
                                                + "') AND orderDelete = 0";

                    var reader = command.ExecuteScalar();
                    if (reader == null)
                    {
                        return "0";
                    }
                    return reader.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return "0";
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonCalcSalary_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.Rows.Count > 0)
            {
                var userId = dataGridViewEmployees.CurrentRow.Cells["employeeId"].Value.ToString();
                var dateStart = dateTimePickerCalcSalaryFrom.Value.Date;
                var dateEnd = dateTimePickerCalcSalaryTo.Value.Date;
                double salary;
                if (!Double.TryParse(CalcSalary(userId, dateStart, dateEnd).ToString(), out salary))
                {
                    salary = 0;

                }
                else
                {
                    salary = salary * percentOfSalary / 100;
                }
                MessageBox.Show(String.Format("Salary for current period : {0}", salary.ToString("0.00"), "Sallary"));
            }
            else
            {
                MessageBox.Show("Select employee.");
            }
        }
    }
}
