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
    public partial class AccountForm : Form
    {
        string selectedAccountNumber = "";
        public AccountForm()
        {
            InitializeComponent();
            this.FormBorderStyle =
    FormBorderStyle.None;
            this.DoubleBuffered = true;
        }
        private void LoadCustomers()
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
                    "SELECT CustomerID, FullName FROM Customer";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbCustomer.DataSource = dt;

                cmbCustomer.DisplayMember = "FullName";

                cmbCustomer.ValueMember = "CustomerID";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            dgvTransactionHistory.EnableHeadersVisualStyles =
    false;

            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.BackColor =
                Color.SteelBlue;

            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTransactionHistory.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvTransactionHistory.DefaultCellStyle.SelectionBackColor =
                Color.SteelBlue;

            dgvTransactionHistory.DefaultCellStyle.SelectionForeColor =
                Color.White;

            LoadCustomers();
            LoadAccounts();
            dgvAccounts.RowHeadersVisible = false;
            dgvAccounts.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.BorderStyle = BorderStyle.None;

        }
        private bool ValidateAccountInputs()
        {
            // CUSTOMER SELECTION

            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select customer.");
                return false;
            }

            // ACCOUNT TYPE

            if (cmbAccountType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select account type.");
                return false;
            }

            // BALANCE EMPTY

            if (string.IsNullOrWhiteSpace(
                txtBalance.Text))
            {
                MessageBox.Show(
                    "Initial balance required.");
                return false;
            }

            // SAFE BALANCE PARSING

            if (!decimal.TryParse(
                txtBalance.Text,
                out decimal balance))
            {
                MessageBox.Show(
                    "Invalid balance amount.");
                return false;
            }

            // NEGATIVE CHECK

            if (balance < 0)
            {
                MessageBox.Show(
                    "Balance cannot be negative.");
                return false;
            }

            // LARGE VALUE CHECK

            if (balance > 1000000000)
            {
                MessageBox.Show(
                    "Balance too large.");
                return false;
            }

            return true;
        }
        private bool AccountAlreadyExists(
    int customerID,
    string accountType)
        {
            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                string query =
                    "SELECT COUNT(*) FROM Account " +
                    "WHERE CustomerID=@customerID " +
                    "AND AccountType=@type";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@customerID",
                    customerID);

                cmd.Parameters.AddWithValue(
                    "@type",
                    accountType);

                int count =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                return count > 0;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateAccountInputs())
                return;
            if (!int.TryParse(cmbCustomer.SelectedValue.ToString(), out int customerID))
            {
                MessageBox.Show(
                    "Invalid customer selected.");
                return;
            }

            string accountType =
                cmbAccountType.Text;
            if (AccountAlreadyExists(customerID, accountType))
            {
                MessageBox.Show(
                    "Customer already has this account type.");

                return;
            }

            decimal.TryParse(
                txtBalance.Text,
                out decimal balance);

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            SqlConnection con =
                new SqlConnection(connectionString);

            try
            {
                con.Open();
                string accountNumber = GenerateAccountNumber();
                string query =
                        "INSERT INTO Account " +
                        "(AccountNumber, CustomerID, AccountType, Balance) " +
                        "VALUES (@accountNumber, @customerID, @type, @balance)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                cmd.Parameters.AddWithValue(
                    "@customerID", customerID);

                cmd.Parameters.AddWithValue(
                    "@type", accountType);

                cmd.Parameters.AddWithValue(
                    "@balance", balance);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully!");
                LoadAccounts();
                btnClear.PerformClick();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAccounts()
        {
            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "A.AccountNumber, " +
                    "C.FullName AS CustomerName, " +
                    "A.AccountType, " +
                    "A.Balance " +
                    "FROM Account A " +
                    "INNER JOIN Customer C " +
                    "ON A.CustomerID = C.CustomerID " +
                    "WHERE A.IsActive = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvAccounts.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBalance.Clear();

            cmbCustomer.SelectedIndex = 0;

            cmbAccountType.SelectedIndex = -1;

            txtBalance.Focus();

            selectedAccountNumber = "";
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.DarkBlue;
        }
        private void ButtonLeave(
    object sender,
    EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.SteelBlue;
        }

        private void DecimalOnly(object sender, KeyPressEventArgs e)
        {
            TextBox txt =
    sender as TextBox;

            // ALLOW CONTROL KEYS

            if (char.IsControl(e.KeyChar))
                return;

            // ALLOW DIGITS

            if (char.IsDigit(e.KeyChar))
                return;

            // ALLOW ONE DECIMAL POINT

            if (e.KeyChar == '.' &&
                !txt.Text.Contains("."))
                return;

            // BLOCK EVERYTHING ELSE

            e.Handled = true;
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAccounts.Rows[e.RowIndex];

                selectedAccountNumber =
                    row.Cells["AccountNumber"]
                    .Value.ToString();
                LoadTransactionHistory(
    selectedAccountNumber);
                cmbCustomer.Text =
                    row.Cells["CustomerName"]
                    .Value.ToString();

                cmbAccountType.Text =
                    row.Cells["AccountType"]
                    .Value.ToString();

                txtBalance.Text =
                    row.Cells["Balance"]
                    .Value.ToString();
            }
        }
        private string GenerateAccountNumber()
        {
            string year =
                DateTime.Now.Year.ToString();

            Random random =
                new Random();

            int number =
                random.Next(1000, 9999);

            return "PK" + year + number;
        }
        private void LoadTransactionHistory(
    string accountNumber)
        {
            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query =
                        "SELECT " +
                        "TransactionType, " +
                        "Amount, " +
                        "TransactionDate " +
                        "FROM Transactions " +
                        "WHERE AccountNumber=@accountNumber " +
                        "ORDER BY TransactionDate DESC";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@accountNumber",
                        accountNumber);

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvTransactionHistory.DataSource =
                        dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAccountNumber))
            {
                MessageBox.Show(
                    "Please select account.");
                return;
            }

            decimal balance =
                Convert.ToDecimal(txtBalance.Text);

            if (balance > 0)
            {
                MessageBox.Show(
                    "Account balance must be zero before closing.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to close this account?",
                    "Confirm Account Close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query =
                        "UPDATE Account " +
                        "SET IsActive = 0 " +
                        "WHERE AccountNumber=@accountNumber";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@accountNumber",
                        selectedAccountNumber);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Account Closed Successfully!");

                    LoadAccounts();

                    btnClear.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblAccountType_Click(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
