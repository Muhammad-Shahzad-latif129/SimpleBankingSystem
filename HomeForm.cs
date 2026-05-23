using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleBankingSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.Load += HomeForm_Load;
            this.DoubleBuffered = true;

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadRecentTransactions();

            lblWelcome.Text =
                "Welcome Back, " +
                LoginForm.LoggedInRole;
            LoadTotalCustomers();
            LoadTotalAccounts();
            LoadTotalTransactions();
            LoadTotalStaff();
           

        }

        private void LoadRecentTransactions()
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

                string query =
                    "SELECT TOP 10 " +
                    "TransactionType, " +
                    "Amount, " +
                    "AccountNumber, " +
                    "TransactionDate " +
                    "FROM Transactions " +
                    "ORDER BY TransactionDate DESC";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvRecentTransactions.DataSource =
                    dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTotalCustomers()
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

                string query =
                    "SELECT COUNT(*) FROM Customer";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                int total =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                lblTotalCustomers.Text =
                    total.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTotalAccounts()
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

                string query =
                    "SELECT COUNT(*) FROM Account";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                int total =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                lblTotalAccounts.Text =
                    total.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTotalTransactions()
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

                string query =
                    "SELECT COUNT(*) FROM Transactions";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                int total =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                lblTotalTransactions.Text =
                    total.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTotalStaff()
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

                string query =
                    "SELECT COUNT(*) FROM Staff";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                int total =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                lblTotalStaff.Text =
                    total.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
