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
    public partial class loginForm : Form
    {
        public string connstring = "server=localhost;uid=root;pwd=ssoouu123;database=users";
        public loginForm()
        {
            InitializeComponent();
            
        }
        

        public int attempts = 5;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string sql = "select Password from userstable where Email = '" + txtUserName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string pass = "" + reader["Password"];
                if (txtPassword.Text == pass)
                {
                    new Main_Page().Show();
                    this.Hide();
                }
                else
                {
                    attempts--;
                    txtPassword.Clear();
                    txtPassword.Focus();
                    lblFeedback.Text = "Password is wrong! " + attempts + " attempts remained";
                    lblFeedback.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                lblFeedback.Text = "Check your email address and password again!";
                lblFeedback.ForeColor = System.Drawing.Color.Red;
                txtUserName.Focus();
            }

            if (attempts == 0)
            {

                timer5.Start();
                lblFeedback.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Xbtn_MouseLeave(object sender, EventArgs e)
        {
            Xbtn.BackColor = Color.Transparent;
            Xbtn.ForeColor = Color.Black;
        }

        private void Xbtn_MouseEnter(object sender, EventArgs e)
        {
            Xbtn.BackColor = Color.Red;
            Xbtn.ForeColor = Color.White;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                loginBtn.PerformClick();
                e.Handled = true;
            }
        }
        public int time = 300;
        private void timer5_Tick_1(object sender, EventArgs e)
        {
            timer5.Interval = 1000;
            if (time > 0)
            {
                time--;
                int minute = time / 60;
                int second = time % 60;
                lblFeedback.Text = "Too many attempts!\nYou can try again after " + minute + ":" + second + " minutes.";
                loginBtn.Enabled = false;

            }
            else
            {
                time = 300;
                timer5.Stop();
                attempts = 5;
                loginBtn.Enabled = true;
                lblFeedback.ForeColor = System.Drawing.Color.Black;
                lblFeedback.Text = "";
            }
        }

        bool mouseDown;
        private Point offset;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
