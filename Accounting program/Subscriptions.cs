using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Accounting_program
{
    public partial class Subscriptions : Form
    {
        public Subscriptions()
        {
            InitializeComponent();
        }

        public string connstring = "server=localhost;uid=root;pwd=ssoouu123;database=users";

        public void callDB()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            string sql = "select * from subscriptions";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            subscriptionsDataGrid.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO subscriptions (CompanyName, Amount, PaymentDate, `Type`, `Status`) VALUES(@CompanyName, @Amount, @PaymentDate, @Type, @Status);";

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@Amount", int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Parse(txtPaymentDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Status", radioButton1.Checked ? "Subscribed" : "Stoped Subscription");

                con.Open();
                cmd.ExecuteNonQuery();
                callDB();
            }
            string insertExpense = "INSERT INTO expenses (`For`, Amount, `Date`, `Type`) VALUES(@For, @Amount, @Date, @Type);";

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertExpense, con))
            {
                cmd.Parameters.AddWithValue("@For", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@Amount", int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(txtPaymentDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text == "Monthly" ? "Monthly" : "Once");

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {
            callDB();
            txtType.Enabled = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (subscriptionsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = subscriptionsDataGrid.SelectedRows[0];
                var value = selectedRow.Cells[0].Value;
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string CName = MySqlHelper.EscapeString(value.ToString());
                string insertQuery = "DELETE FROM subscriptions WHERE CompanyName = '" + CName + "';";
                MySqlCommand cmd = new MySqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                callDB();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
