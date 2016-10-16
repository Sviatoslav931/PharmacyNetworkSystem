using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using PharmaShop.Code;
using PharmaRepositories;

namespace PharmaShop
{
    public partial class MainServiceForm : Form
    {
        const string cartIsEmptyText = "Your cart is empty.";
        const string cartIsNotEmptyText = "In your cart {0} medicaments:";
        int currentShopId = CurrentUser.ShopID;
        private readonly ICustomerRepository _customerRepository;
        double totalSumm = 0;
        
        public MainServiceForm()
        {

            InitializeComponent();

            _customerRepository = new SqlCustomerRepository(ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString);
            labelUserName.Text = String.Format("User : {0} {1}", CurrentUser.FirstName, CurrentUser.Surname);

            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            textBoxMedicamentName.Text = "";
            textBoxClientCard.Text = "";
            labelCart.Text = cartIsEmptyText;
            labelTotalPrice.Text = string.Format("{0:C2}", 0);
        }
        
        private void ClearCart(bool forceClear = false)
        {
            if (forceClear ||
                ((dataGridViewCart.Rows.Count > 0) &&
                 (MessageBox.Show("Your cart is not empty. Are you sure to clear it ?",
                                  "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes))
               )
            {
                SetDefaultValues();
                ClearDataGridView(dataGridViewCart);
                CalculateCartTotalPrice();
            }
        }

        private void ClearProducts()
        {
            ClearDataGridView(dataGridViewProducts);
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Refresh();
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Catching pressing "delete" button.
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var medicament = dataGridViewCart.Rows[e.RowIndex].Cells["cartName"].Value.ToString();
                var dose = dataGridViewCart.Rows[e.RowIndex].Cells["cartDose"].Value.ToString();
                var confirm = MessageBox.Show(String.Format("Remove \"{0} {1}\" ?", medicament, dose),
                                              "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    dataGridViewCart.Rows.RemoveAt(e.RowIndex);
                    CalculateCartTotalPrice();
                }
            }
        }

        private void GetAllAvailableMedicaments(string medicamentName="")
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
                    command.CommandText = "spGetAllAvailableMedicaments";
                    command.Parameters.AddWithValue("@ShopId", currentShopId);
                    command.Parameters.AddWithValue("@MedicamentName", "%" + medicamentName + "%");
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var id = reader[0].ToString();
                        var medicamentId = reader[1].ToString();
                        var name = reader[2].ToString();
                        var dose = reader[3].ToString();
                        var price = reader[4].ToString();
                        var number = reader[5].ToString();

                        var currentIndex = dataGridViewProducts.Rows.Add(id, medicamentId, name, dose, price, number);
                        if (number == "0")
                        {
                            dataGridViewProducts.Rows[currentIndex].DefaultCellStyle.BackColor = Color.Red;
                            dataGridViewProducts.Rows[currentIndex].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    dataGridViewProducts.Sort(dataGridViewProducts.Columns["productsName"], System.ComponentModel.ListSortDirection.Ascending);
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

        private void GetRangesFromCurrShopByCurrMedicament(int medicamentId, string medicamentName, string medicamentDose)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand();
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spGetRangesFromCurrShopByCurrMedicament";
                    command.Parameters.AddWithValue("@MedicamentId", medicamentId);
                    command.Parameters.AddWithValue("@ShopId", currentShopId);
                    var reader = command.ExecuteReader();

                    var viewWholeNetwork = new WholeNetworkViewForm(medicamentId, medicamentName, medicamentDose, reader);
                    viewWholeNetwork.ShowDialog(this);

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
        
        // Calculate total price in the cart.
        private void CalculateCartTotalPrice()
        {
            double summ = 0;
            var i = 0;

            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                double totalPrice = 0;
                Double.TryParse(row.Cells["cartTotalPrice"].Value.ToString(), out totalPrice);
                summ += totalPrice;
                i++;
            }

            labelTotalPrice.Text = string.Format("{0:C2}", summ);
            labelCart.Text = (i == 0) ? cartIsEmptyText : String.Format(cartIsNotEmptyText, i);
            totalSumm = summ;
        }

        private int GetLastIdInOrders()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var lastId = 0;
                var command = new SqlCommand();
                try
                {
                    connection.Open();

                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spGetLastIdInOrders";
                    var reader = command.ExecuteScalar();
                    
                    lastId = (int) reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return lastId;
            }
        }

        private string GetShopAddressById(int currentShopId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var shopAddress = "";
                var command = new SqlCommand();
                try
                {
                    connection.Open();

                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spGetShopAddressById";
                    command.Parameters.AddWithValue("@ShopId", currentShopId);
                    var reader = command.ExecuteScalar();
                    
                    shopAddress = reader.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return shopAddress;
            }
        }

        private int GetDiscountForSumm(double totalSumm)
        {
            var discount = 0;
            if (totalSumm > 10000)
            {
                discount = 8;
            }
            else if (totalSumm > 3000)
            {
                discount = 5;
            }
            else if (totalSumm > 1000)
            {
                discount = 3;
            }
            
            return discount;
        }

        private int GetProductNumberById(int currentProductId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var productsNumber = 0;
                var command = new SqlCommand();
                try
                {
                    connection.Open();

                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spGetProductNumberById";
                    command.Parameters.AddWithValue("@productID", currentProductId);
                    var reader = command.ExecuteScalar();

                    productsNumber = (int)reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return productsNumber;
            }
        }
        
        private void DataGridViewProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddCurrentMedicamentToCart();
        }

        private bool AddCurrentMedicamentToCart()
        {
            // if nothing to add.
            var currentMedicament = dataGridViewProducts.CurrentRow;
            if (currentMedicament == null)
            {
                MessageBox.Show("There is nothing to put in the cart.");
                return false;
            }

            // if current medicament has been already sold.
            var medicament = currentMedicament.Cells["productsName"].Value.ToString();
            var dose = currentMedicament.Cells["productsDose"].Value.ToString();
            var maxNumberOfCurrentMedicamentText = currentMedicament.Cells["productsNumber"].Value.ToString();
            if (maxNumberOfCurrentMedicamentText == "0")
            {
                MessageBox.Show(String.Format("All \"{0} {1}\" has been sold already.", medicament, dose));
                return false;
            }

            // if current medicament already in the cart.
            var id = currentMedicament.Cells["productsID"].Value.ToString();
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (id == row.Cells["cartID"].Value.ToString())
                {
                    MessageBox.Show(String.Format("Can't add current medicament. \"{0} {1}\" is already in cart.", medicament, dose));
                    return false;
                }
            }
            
            // request for how many items of current medicament should we add.
            var currNumber = 1;
            if (maxNumberOfCurrentMedicamentText != "1")
            {
                var numberRequest = new SetNumberForm(maxNumberOfCurrentMedicamentText);
                var respond = numberRequest.ShowDialog(this);
                if (respond != DialogResult.OK)
                {
                    // when close the dilog without pressing OK button
                    return false;
                }
                
                currNumber = numberRequest.returnNumber;
                numberRequest.Dispose();
            }
            
            // add exact number of current medicament.
            var priceText = currentMedicament.Cells["productsPrice"].Value.ToString();
            double price;
            Double.TryParse(priceText, out price);
            dataGridViewCart.Rows.Add(id, medicament, dose, priceText, currNumber, price*currNumber);

            CalculateCartTotalPrice();
            return true;
        }

        // change number of current medicament in the cart event.
        private void DataGridViewCartChangeNumber(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCart.Columns[e.ColumnIndex].Name == "cartNumber")
            {
                double price = 0;
                var number = 1;
                double totalPrice = 0;
                var currentRowCart = dataGridViewCart.Rows[e.RowIndex];

                Double.TryParse(currentRowCart.Cells["cartPrice"].Value.ToString(), out price);
                
                // when enter not a number.
                if ((currentRowCart.Cells["cartNumber"].Value == null) || (!Int32.TryParse(currentRowCart.Cells["cartNumber"].Value.ToString(), out number)))
                {
                    number = 1;
                    dataGridViewCart.Rows[e.RowIndex].Cells["cartNumber"].Value = number;
                }

                // when enter number more than "1" check if it not bigger than possible maxValue.
                if (number > 1)
                {
                    foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                    {
                        var cartID = currentRowCart.Cells["cartID"].Value.ToString();
                        if (cartID == row.Cells["productsID"].Value.ToString())
                        {
                            var maxNumber = 1;
                            Int32.TryParse(row.Cells["productsNumber"].Value.ToString(), out maxNumber);
                            if (number > maxNumber)
                            {
                                number = maxNumber;
                                currentRowCart.Cells["cartNumber"].Value = number;

                                var sb = new StringBuilder();
                                sb.AppendFormat("Not enouph such medicament in this shop.");
                                sb.AppendLine();
                                if (maxNumber == 1)
                                {
                                    sb.AppendFormat("This is the last one.");
                                }
                                else
                                {
                                    sb.AppendFormat("Try enter number between 1 and {0}", maxNumber);
                                }
                                sb.AppendLine();
                                sb.AppendFormat("Press button \"Show current medicament in whole network\" to check number of this medicament in another shops.");
                                
                                MessageBox.Show(sb.ToString());                               
                            }
                            break;
                        }
                    }
                    
                }
                else if (number < 1)
                {
                    number = 1;
                    dataGridViewCart.Rows[e.RowIndex].Cells["cartNumber"].Value = number;
                }
                

                totalPrice = price * number;
                dataGridViewCart.Rows[e.RowIndex].Cells["cartTotalPrice"].Value = totalPrice.ToString("0.00");

                CalculateCartTotalPrice();
            }
        }

        private void buttonWholeSearch_Click(object sender, EventArgs e)
        {
            int medicamentId;
            string medicamentName;
            string medicamentDose;
            if (dataGridViewProducts.Rows.Count > 0)
            {
                medicamentId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["medicamentID"].Value);
                medicamentName = dataGridViewProducts.CurrentRow.Cells["productsName"].Value.ToString();
                medicamentDose = dataGridViewProducts.CurrentRow.Cells["productsDose"].Value.ToString();
                GetRangesFromCurrShopByCurrMedicament(medicamentId, medicamentName, medicamentDose);
            }
            else
            {
                MessageBox.Show("No medicament selected.");
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void buttonShowOwnCatalog_Click(object sender, EventArgs e)
        {
            ClearProducts();
            GetAllAvailableMedicaments();
        }

        private void buttonSearchMedicament_Click(object sender, EventArgs e)
        {
            if (textBoxMedicamentName.Text.Length > 2)
            {
                ClearProducts();
                GetAllAvailableMedicaments(textBoxMedicamentName.Text);
            }
            else
            {
                MessageBox.Show("Enter at least 3 symbols.");
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearProducts();
            ClearCart();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            AddCurrentMedicamentToCart();
        }

        private void buttonConfirmSelling_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count > 0)
            {
                var cardText = textBoxClientCard.Text;
                int card;
                var customerIdText = "NULL";
                var customerDiscountText = "NULL";
                var customerDiscount = 0;
                double customerTotalSumm = 0;
                double customerTotalSummToUpdate = 0;

                PharmaEntities.Customer customer = null;

                if (Int32.TryParse(cardText, out card))
                {
                    customer = _customerRepository.GetCustomerByCard(card);
                    if (customer != null)
                    {
                        customerIdText = customer.Id.ToString();
                        customerDiscountText = customer.Discount.ToString();
                        customerDiscount = customer.Discount;
                        customerTotalSumm = customer.TotalSumm;

                        customerTotalSummToUpdate = customerTotalSumm + totalSumm;
                    }
                    else
                    {
                        MessageBox.Show("Enter valid card number.");
                        return;
                    }
                }
                else if (cardText != "")
                {
                    MessageBox.Show("Enter valid card number.");
                    return;
                }

                var currDateTime = DateTime.Now;
                var newOrderId = GetLastIdInOrders() + 1;

                // BEGIN TRANSACTION
                var transactionExecuteCorrect = false;
                var connectionString = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    var transaction = connection.BeginTransaction("CreateOrderTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        // insert new order
                        command.CommandText =
                            @"insert into Orders (
                                orderId, 
                                orderDate, 
                                customerId, 
                                userId, 
                                shopId, 
                                orderSumm, 
                                orderDiscount) 
                              values ("
                                + newOrderId + ", '"
                                + currDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', "
                                + customerIdText + ", "
                                + CurrentUser.Id + ", "
                                + currentShopId + ", "
                                + totalSumm.ToString().Replace(',', '.') + ", "
                                + customerDiscountText + ")";
                        command.ExecuteNonQuery();

                        // update current customer
                        if (customer != null)
                        {
                            command.CommandText =
                                @"UPDATE 
                                        Customers 
                                  SET 
                                        customerTotalSumm = " + customerTotalSummToUpdate.ToString().Replace(',', '.') + @", 
                                        customerDiscount = " + GetDiscountForSumm(customerTotalSummToUpdate) +
                                @"WHERE customerID = " + customerIdText;
                            command.ExecuteNonQuery();
                        }

                        // update all products in cart
                        foreach (DataGridViewRow row in dataGridViewCart.Rows)
                        {
                            var productId = Int32.Parse(row.Cells["cartID"].Value.ToString());
                            var productNumberToSell = Int32.Parse(row.Cells["cartNumber"].Value.ToString());
                            var productNumberBeforeSell = GetProductNumberById(productId);
                            var productNumberAfterSell = productNumberBeforeSell - productNumberToSell;

                            if (productNumberAfterSell >= 0)
                            {
                                command.CommandText =
                                    @"UPDATE 
                                            Products 
                                      SET 
                                            productNumber = " + productNumberAfterSell +
                                    @"WHERE productID = " + productId;
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                transactionExecuteCorrect = false;
                                ClearProducts();
                                throw new Exception("The number of medicament already has been changed.");
                            }
                        }

                        // Attempt to commit the transaction.
                        transaction.Commit();
                        transactionExecuteCorrect = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(String.Format("Commit Exception Type: {0}", ex.GetType()));
                        MessageBox.Show(String.Format("  Message: {0}", ex.Message));

                        // Attempt to roll back the transaction.
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            MessageBox.Show(String.Format("Rollback Exception Type: {0}", ex2.GetType()));
                            MessageBox.Show(String.Format("  Message: {0}", ex2.Message));
                        }
                    }
                }
                // END TRANSACTION

                if (transactionExecuteCorrect)
                {
                    var sb = new StringBuilder();
                    sb.AppendFormat("DateTime : {0}", currDateTime.ToString(@"MM\/dd\/yyyy HH:mm"));
                    sb.AppendLine();
                    sb.AppendFormat("Shop : {0}", GetShopAddressById(currentShopId));
                    sb.AppendLine();
                    sb.AppendFormat("Cashier : {0} {1}", CurrentUser.FirstName, CurrentUser.Surname);
                    sb.AppendLine();
                    sb.AppendFormat("Total : {0}", totalSumm);
                    sb.AppendLine();
                    if (customer != null)
                    {
                        sb.AppendFormat("Card : {0}", cardText);
                        sb.AppendLine();
                        sb.AppendFormat("Discount : {0}%", customerDiscount);
                        sb.AppendLine();
                        double totalSummIncludeDiscount = totalSumm * (100 - customerDiscount) / 100;
                        sb.AppendFormat("Total with discount : {0}", string.Format("{0:0.00}", totalSummIncludeDiscount));
                        sb.AppendLine();
                    }
                    ClearCart(true);
                    ClearProducts();
                    MessageBox.Show(sb.ToString(), "Bill", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Something wrong with connection to DB. Try again in a few minutes or just restart the program, if it doesn't helps, contact your network administrator.");
                }
            }
        }

    }
}