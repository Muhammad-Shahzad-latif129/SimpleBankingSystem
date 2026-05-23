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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
            this.FormBorderStyle =
    FormBorderStyle.None;
            this.DoubleBuffered = true;
        }
        private void SearchAccount()
        {
            string search =
                txtSearchAccount.Text.Trim();

            for (int i = 0;
                 i < cmbAccount.Items.Count;
                 i++)
            {
                DataRowView row =
                    (DataRowView)
                    cmbAccount.Items[i];

                string accountNumber =
                    row["AccountNumber"]
                    .ToString();

                if (accountNumber.Contains(search))
                {
                    cmbAccount.SelectedIndex = i;

                    return;
                }
            }
        }
        private void LoadAccounts()
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
                    "SELECT " +
                    "A.AccountNumber, " +
                    "A.AccountNumber + ' - ' + " +
                    "C.FullName + ' - ' + " +
                    "A.AccountType AS DisplayText " +
                    "FROM Account A " +
                    "INNER JOIN Customer C " +
                    "ON A.CustomerID = C.CustomerID " +
                    "WHERE A.IsActive = 1";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbAccount.DataSource = dt;

                cmbAccount.DisplayMember =
                    "DisplayText";

                cmbAccount.ValueMember =
                    "AccountNumber";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTransactions()
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
                    "T.TransactionID, " +
                    "T.TransactionType, " +
                    "T.AccountNumber, " +
                    "C.FullName AS CustomerName, " +
                    "A.AccountType, " +
                    "T.Amount, " +
                    "T.TransactionDate " +
                    "FROM Transactions T " +
                    "INNER JOIN Account A " +
                    "ON T.AccountNumber = A.AccountNumber " +
                    "INNER JOIN Customer C " +
                    "ON A.CustomerID = C.CustomerID " +
                    "WHERE T.TransactionType = 'Withdraw' " +
                    "ORDER BY T.TransactionDate DESC";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvWithdraw.DataSource = dt;

                dgvWithdraw.Columns["TransactionID"].HeaderText =
                   "Transaction ID";

                dgvWithdraw.Columns["TransactionType"].HeaderText =
                    "Type";

                dgvWithdraw.Columns["AccountNumber"].HeaderText =
                    "Account No";

                dgvWithdraw.Columns["CustomerName"].HeaderText =
                    "Customer Name";

                dgvWithdraw.Columns["AccountType"].HeaderText =
                    "Account Type";

                dgvWithdraw.Columns["Amount"].HeaderText =
                    "Amount";

                dgvWithdraw.Columns["TransactionDate"].HeaderText =
                    "Date";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();

            LoadTransactions();
            dgvWithdraw.RowHeadersVisible = false;
            dgvWithdraw.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
            dgvWithdraw.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            dgvWithdraw.BorderStyle = BorderStyle.None;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // ACCOUNT VALIDATION

            if (cmbAccount.SelectedValue == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            string accountNumber =
                        cmbAccount.SelectedValue.ToString();

            // EMPTY AMOUNT CHECK

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter amount.");
                return;
            }

            // SAFE AMOUNT PARSING

            if (!decimal.TryParse(
                txtAmount.Text,
                out decimal amount))
            {
                MessageBox.Show(
                    "Enter a valid numeric amount.");
                return;
            }

            // NEGATIVE / ZERO CHECK

            if (amount <= 0)
            {
                MessageBox.Show(
                    "Amount must be greater than zero.");
                return;
            }

            int staffID =
    LoginForm.LoggedInStaffID;

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    if (!BankCache.AccountBalances
                        .ContainsKey(accountNumber))
                    {
                        MessageBox.Show(
                            "Account not found.");

                        return;
                    }

                    decimal currentBalance =
                        BankCache.AccountBalances
                        [accountNumber];

                    if (amount > currentBalance)
                    {
                        MessageBox.Show(
                            "Insufficient Balance!");

                        return;
                    }


                    // UPDATE BALANCE

                    string updateQuery =
                            "UPDATE Account " +
                            "SET Balance = Balance - @amount " +
                            "WHERE AccountNumber=@accountNumber";

                    using (SqlCommand updateCmd =
                        new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue(
                            "@amount",
                            amount);

                        updateCmd.Parameters.AddWithValue(
                            "@accountNumber",
                            accountNumber);

                        updateCmd.ExecuteNonQuery();
                        BankCache.AccountBalances[accountNumber] -= amount;
                    }

                    // INSERT TRANSACTION

                    string insertQuery =
                        "INSERT INTO Transactions " +
                        "(AccountNumber, StaffID, " +
                        "TransactionType, Amount) " +
                        "VALUES " +
                        "(@accountNumber, @staffID, " +
                        "'Withdraw', @amount)";

                    using (SqlCommand insertCmd =
                        new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue(
                            "@accountNumber",
                            accountNumber);

                        insertCmd.Parameters.AddWithValue(
                            "@staffID",
                            staffID);

                        insertCmd.Parameters.AddWithValue(
                            "@amount",
                            amount);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Withdraw Successful!");
                    DashboardForm.Instance.ShowStatus(
    "Withdraw Successful");
                    LoadTransactions();

                    txtAmount.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "System Error: " + ex.Message);
            }
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.DarkBlue;
        }

        private void ButtonLeave(object sender, EventArgs e)
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

        private void txtSearchAccount_TextChanged(object sender, EventArgs e)
        {
            SearchAccount();
        }
    }
}
