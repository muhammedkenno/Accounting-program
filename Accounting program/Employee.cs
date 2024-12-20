using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_program
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        public string connstring = "server=localhost;uid=root;pwd=ssoouu123;database=users";
        public void callDB()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            string sql = "select * from employee";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            employeesDataGrid.DataSource = dataTable;
        }
        private void add_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO employee (`Name`,WorkHours, Salary, DateHired, PaymentDate, `Type`, `Status`) VALUES(@Name,@WorkHours, @Salary, @DateHired, @PaymentDate, @Type, @Status);";

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@WorkHours", int.Parse(txtHours.Text));
                cmd.Parameters.AddWithValue("@Salary", int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@DateHired", DateTime.Parse(txtStartedDate.Text));
                cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Parse(txtPaymentDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Status", radioButton1.Checked ? "Working" : "Stopped Working");

                con.Open();
                cmd.ExecuteNonQuery();
                callDB();
            }
            string insertExpense = "INSERT INTO expenses (`For`, Amount, `Date`, `Type`) VALUES(@For, @Amount, @Date, @Type);";

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertExpense, con))
            {
                cmd.Parameters.AddWithValue("@For", txtName.Text);
                cmd.Parameters.AddWithValue("@Amount", int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(txtPaymentDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text == "Monthly" ? "Monthly" : "Once");

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void employeesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            callDB();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (employeesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = employeesDataGrid.SelectedRows[0];
                var value = selectedRow.Cells[0].Value;
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string Name = MySqlHelper.EscapeString(value.ToString());
                string insertQuery = "DELETE FROM employee WHERE Name = '" + Name + "';";
                MySqlCommand cmd = new MySqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                callDB();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
