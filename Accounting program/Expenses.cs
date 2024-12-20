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

namespace Accounting_program
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }
        private void callDB()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            string sql = "select * from expenses";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ExpensesDataGrid.DataSource = dataTable;
        }

        public string connstring = "server=localhost;uid=root;pwd=ssoouu123;database=users";
        private void add_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO expenses (`For`, Amount, `Date`, `Type`) VALUES(@For, @Amount, @Date, @Type);";

            using (MySqlConnection con = new MySqlConnection(connstring))
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@For", txtFor.Text);
                cmd.Parameters.AddWithValue("@Amount", int.Parse(txtAmount.Text));
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(txtDate.Text));
                cmd.Parameters.AddWithValue("@Type", txtType.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                callDB();
            }
        }

        private void ExpensesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            callDB();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ExpensesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ExpensesDataGrid.SelectedRows[0];
                var value = selectedRow.Cells[0].Value;
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string Forwho = MySqlHelper.EscapeString(value.ToString());
                string insertQuery = "DELETE FROM Expenses WHERE `For` = '" + Forwho + "';";
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
