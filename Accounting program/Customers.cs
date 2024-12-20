using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_program
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        private void callDB()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            string sql = "select * from customers";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            customersDataGrid.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string connstring = "server=localhost;uid=root;pwd=ssoouu123;database=users";


        private void addBtn_Click(object sender, EventArgs e)
        {
            

            string insertQuery = "INSERT INTO customers (CompanyName, `Name`, Amount, StartedDate, PaymentDate, `Type`, `Status`) VALUES(@CompanyName, @Name, @Amount, @StartedDate, @PaymentDate, @Type, @Status);";
           

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Amount",int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@StartedDate", DateTime.Parse(txtStartedDate.Text));
                cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Parse(txtPaymentDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text) ;
                cmd.Parameters.AddWithValue("@Status", radioButton1.Checked ? "Working" : "Stopped Working");

                con.Open();
                cmd.ExecuteNonQuery();
            }
            callDB();

            string insertIncome = "INSERT INTO income (`From`, Amount, `Date`, `Type`) VALUES(@From, @Amount, @Date, @Type);";

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertIncome, con))
            {
                cmd.Parameters.AddWithValue("@From", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@Amount", int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(txtPaymentDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        
        private void Customers_Load(object sender, EventArgs e)
        {
            callDB();
        }

        private void customersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (customersDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = customersDataGrid.SelectedRows[0];
                var value = selectedRow.Cells[0].Value;
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string companyName = MySqlHelper.EscapeString(value.ToString());
                string insertQuery = "DELETE FROM customers WHERE CompanyName = '" + companyName + "';";
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
