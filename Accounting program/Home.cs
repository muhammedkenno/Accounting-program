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
    public partial class Home : Form
    {
        public string connstring = "server=localhost;uid=root;pwd=ssoouu123;database=users";
        int CYear = DateTime.Now.Year;
        int CMonth = DateTime.Now.Month;
        string CMonthName = DateTime.Now.ToString("MMMM");
        public Home()
        {
            InitializeComponent();
        }
        private object CallIncome(int i)
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT SUM(amount) AS total FROM income WHERE MONTH(date) = "+ i +" AND YEAR(date) = "+ CYear + ";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            
            object amount = cmd.ExecuteScalar();
            con.Close();
            return amount;
        }

        private object CallExpenses(int i)
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT SUM(Amount) AS total FROM expenses WHERE MONTH(date) = " + i + " AND YEAR(date) = " + CYear + ";";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            object amount = cmd.ExecuteScalar();
            
            return amount;
        }

        private void FillChart()
        {
            for (int i = 1; i <= 12; i++)
            {
                string inAmount = CallIncome(i).ToString();
                string outAmount = CallExpenses(i).ToString();
                chart1.Series["Income"].XValueMember = CMonth.ToString();
                chart1.Series["Income"].YValueMembers = inAmount;
                chart1.Series["Income"].Points.AddXY(i.ToString(), inAmount);
                chart1.Series["Expenses"].XValueMember = CMonth.ToString();
                chart1.Series["Expenses"].YValueMembers = outAmount;
                chart1.Series["Expenses"].Points.AddXY(i.ToString(), outAmount);
            }
            
        }

        private object employeesNum()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT COUNT(type) AS COUNTER FROM employee;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            object num = cmd.ExecuteScalar();
            return num;
        }

        private object clientsNum()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT COUNT(type) AS COUNTER FROM customers;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            object num = cmd.ExecuteScalar();
            return num;
        }

        private object subscNum()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT COUNT(type) AS COUNTER FROM subscriptions;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            object num = cmd.ExecuteScalar();
            return num;
        }

        private object currentYearsProfits()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT \r\n    (income.total_income - expenses.total_expenses) AS profit\r\nFROM \r\n    (SELECT SUM(amount) AS total_income FROM income WHERE YEAR(date) = " + CYear.ToString() + " ) AS income,\r\n    (SELECT SUM(amount) AS total_expenses FROM expenses WHERE YEAR(date) = " + CYear.ToString() + " ) AS expenses;\r\n";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            object num = cmd.ExecuteScalar();
            return num;
        }
        private object currentMonthsProfits()
        {
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string sql = "SELECT \r\n    (income.total_income - expenses.total_expenses) AS profit\r\nFROM \r\n    (SELECT SUM(amount) AS total_income FROM income WHERE MONTH(date) = " + CMonth.ToString() + " ) AS income,\r\n    (SELECT SUM(amount) AS total_expenses FROM expenses WHERE MONTH(date) = " + CMonth.ToString() + " ) AS expenses;\r\n";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            object num = cmd.ExecuteScalar();
            return num;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            FillChart();
            yearLbl.Text = CYear.ToString();
            monthLbl.Text = CMonthName.ToString();

            yearlyProfit.Text = currentYearsProfits().ToString();
            monthlyProfit.Text = currentMonthsProfits().ToString();
            employeeNum.Text = employeesNum().ToString();
            subsNum.Text = subscNum().ToString();
            clientNum.Text = clientsNum().ToString();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
