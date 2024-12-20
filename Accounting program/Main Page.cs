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
    public partial class Main_Page : Form
    {
        bool sidebarExpand;
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Xbtn_MouseHover(object sender, EventArgs e)
        {
            Xbtn.BackColor = Color.Red;
            Xbtn.ForeColor = Color.White;
        }

        private void Xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Xbtn_MouseLeave(object sender, EventArgs e)
        {
            Xbtn.BackColor= Color.Transparent;
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

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // if sidebar is expanded, minimize
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            } else // if sidebar is not expanded, maximize
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            // Start the timer  when we click to the menu
            sidebarTimer.Start();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
               this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f); 
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Home());
            if(sidebarExpand)
                sidebarTimer.Start();
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            loadForm(new income());
            if (sidebarExpand)
                sidebarTimer.Start();
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Expenses());
            if (sidebarExpand)
                sidebarTimer.Start();
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Employee());
            if (sidebarExpand)
                sidebarTimer.Start();
        }

        private void custBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Customers());
            if (sidebarExpand)
                sidebarTimer.Start();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Subscriptions());
            if (sidebarExpand)
                sidebarTimer.Start();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            loadForm(new Home());
        }

        bool mouseDown;
        private Point offset;
        private void headPanel_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void headPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void headPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
