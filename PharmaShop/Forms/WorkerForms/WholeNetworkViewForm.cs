using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmaShop
{
    public partial class WholeNetworkViewForm : Form
    {
        public WholeNetworkViewForm(int medicamentId, string medicamentName, string medicamentDose, SqlDataReader reader)
        {
            InitializeComponent();
            while (reader.Read())
            {
                var address = reader[0].ToString();
                var price = reader[1].ToString();
                var number = reader[2].ToString();
                var range = reader[3].ToString();
                
                var currentIndex = dataGridViewProducts.Rows.Add(medicamentId, medicamentName, medicamentDose, address, price, number, range);
                if (number == "0")
                {
                    dataGridViewProducts.Rows[currentIndex].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewProducts.Rows[currentIndex].DefaultCellStyle.ForeColor = Color.White;
                }

            }
            reader.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
