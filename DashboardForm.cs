using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SimpleBankingSystem
{
    public partial class DashboardForm : Form
    {
        public static DashboardForm Instance;
        private Button currentButton;
        private void ActivateButton(
    Button clickedButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor =
                    Color.SteelBlue;

                currentButton.ForeColor =
                    Color.White;
            }

            currentButton = clickedButton;

            currentButton.BackColor =
                Color.DarkBlue;

            currentButton.ForeColor =
                Color.White;
        }

        public DashboardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Instance = this;
        }
        public void ShowStatus(
    string message)
        {
            lblStatus.Text = message;
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCustomers);

            OpenForm(new CustomerForm());
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAccounts);
            OpenForm(new AccountForm());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDeposit);
            OpenForm(new DepositForm());
        }



        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            ActivateButton(btnWithdraw);
            OpenForm(new WithdrawForm());

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ActivateButton(btnTransfer);
            OpenForm(new TransferForm());

        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            ActivateButton(btnStatement);
            OpenForm(new StatementForm());
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
           
            ShowStatus(
    "Welcome to Simple Banking System");
            lblUser.Text =
    "Role: " +
    LoginForm.LoggedInRole;
            lblWelcome.Text =
    "Welcome, " +
    LoginForm.LoggedInRole;
            OpenForm(new HomeForm());
            LoadStatistics();
            if (LoginForm.LoggedInRole == "Teller")
            {
                btnCustomers.Visible = false;

                btnAccounts.Visible = false;

                btnTransfer.Visible = false;

                btnStaff.Visible = false;
            }
            // MANAGER

            if (LoginForm.LoggedInRole == "Manager")
            {
                btnDeposit.Visible = false;

                btnWithdraw.Visible = false;

                btnStaff.Visible = false;
            }


        }
        private void MenuHover(
            object sender,
            EventArgs e)
        {
            Button btn =
                (Button)sender;

            if (btn != currentButton)
            {
                btn.BackColor =
                    Color.RoyalBlue;
            }
        }
        private void MenuLeave(
            object sender,
            EventArgs e)
        {
            Button btn =
                (Button)sender;

            if (btn != currentButton)
            {
                btn.BackColor =
                    Color.SteelBlue;
            }
        }
        private void LoadStatistics()
        {
            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            SqlConnection con =
                new SqlConnection(connectionString);

            try
            {
                con.Open();

                // TOTAL CUSTOMERS

                string customerQuery =
                    "SELECT COUNT(*) FROM Customer";

                SqlCommand customerCmd =
                    new SqlCommand(customerQuery, con);

                int totalCustomers =
                    Convert.ToInt32(
                        customerCmd.ExecuteScalar());


                // TOTAL ACCOUNTS

                string accountQuery =
                    "SELECT COUNT(*) FROM Account";

                SqlCommand accountCmd =
                    new SqlCommand(accountQuery, con);

                int totalAccounts =
                    Convert.ToInt32(
                        accountCmd.ExecuteScalar());


                // TOTAL TRANSACTIONS

                string transactionQuery =
                    "SELECT COUNT(*) FROM Transactions";

                SqlCommand transactionCmd =
                    new SqlCommand(transactionQuery, con);

                int totalTransactions =
                    Convert.ToInt32(
                        transactionCmd.ExecuteScalar());


                // TOTAL BALANCE

                string balanceQuery =
                    "SELECT SUM(Balance) FROM Account";

                SqlCommand balanceCmd =
                    new SqlCommand(balanceQuery, con);

                object result =
                    balanceCmd.ExecuteScalar();

                decimal totalBalance = 0;

                if (result != DBNull.Value)
                {
                    totalBalance =
                        Convert.ToDecimal(result);
                }



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(btnStaff);
            OpenForm(new StaffForm());
        }
        private void OpenForm(Form childForm)
        {
            panelContainer.Controls.Clear();

            childForm.TopLevel = false;

            childForm.FormBorderStyle =
                FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);

            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm.LoggedInRole = "";

                LoginForm.LoggedInStaffID = 0;

                LoginForm login =
                    new LoginForm();

                login.Show();

                this.Close();
            }
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHome);
            OpenForm(new HomeForm());
        }

        private void timerClock_Tick_1(object sender, EventArgs e)
        {
            lblDateTime_1.Text =
                DateTime.Now.ToString(
                    "hh:mm:ss tt");
        }

        private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
