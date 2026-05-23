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
    public partial class DepositForm : Form
    {
        public DepositForm()
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

        private void DepositForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadTransactions();
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.BorderStyle = BorderStyle.None;
        }
        private void LoadTransactions()
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
                    "T.TransactionID, " +
                    "T.AccountNumber, " +
                    "C.FullName AS CustomerName, " +
                    "A.AccountType, " +
                    "T.TransactionType, " +
                    "T.Amount, " +
                    "T.TransactionDate " +
                    "FROM Transactions T " +
                    "INNER JOIN Account A " +
                    "ON T.AccountNumber = A.AccountNumber " +
                    "INNER JOIN Customer C " +
                    "ON A.CustomerID = C.CustomerID";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTransactions.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string accountNumber =
    cmbAccount.SelectedValue.ToString();

            //Dictionary used as cache to store account balances and minimize database queries
            if (!BankCache.AccountBalances
    .ContainsKey(accountNumber))
            {
                MessageBox.Show(
                    "Account not found.");

                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            int staffID =
    LoginForm.LoggedInStaffID;

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            SqlConnection con =
                new SqlConnection(connectionString);

            try
            {
                con.Open();

                // STEP 1: UPDATE BALANCE

                string updateQuery =
                    "UPDATE Account " +
                    "SET Balance = Balance + @amount " +
                    "WHERE AccountNumber = @accountNumber";
                string balanceQuery = "SELECT Balance FROM Account " + "WHERE AccountNumber=@accountNumber";

                SqlCommand balanceCmd =
                    new SqlCommand(balanceQuery, con);

                balanceCmd.Parameters.AddWithValue(
                    "@accountNumber",
                    accountNumber);

                decimal newBalance =
                    Convert.ToDecimal(
                        balanceCmd.ExecuteScalar());
                SqlCommand updateCmd =
                    new SqlCommand(updateQuery, con);

                updateCmd.Parameters.AddWithValue(
                    "@amount", amount);

                updateCmd.Parameters.AddWithValue(
                    "@accountNumber", accountNumber);

                updateCmd.ExecuteNonQuery();
                //Dictionary used to increase balance in cache immediately after deposit without waiting for next load
                BankCache.AccountBalances[accountNumber] += amount;
                // STEP 2: SAVE TRANSACTION

                string insertQuery =
                    "INSERT INTO Transactions " +
                    "(AccountNumber, StaffID, " +
                    "TransactionType, Amount) " +
                    "VALUES " +
                    "(@accountNumber, @staffID, " +
                    "'Deposit', @amount)";

                SqlCommand insertCmd =
                    new SqlCommand(insertQuery, con);

                insertCmd.Parameters.AddWithValue(
                    "@accountNumber", accountNumber);

                insertCmd.Parameters.AddWithValue(
                    "@staffID", staffID);

                insertCmd.Parameters.AddWithValue(
                    "@amount", amount);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Deposit Successful!");

                DashboardForm.Instance.ShowStatus("Deposit Successful");

                ReceiptForm receipt =
    new ReceiptForm();

                receipt.AccountNumber =
                    accountNumber;

                receipt.TransactionType =
                    "Deposit";

                receipt.Amount =
                    amount;

                receipt.Balance =
                    newBalance;

                receipt.Date =
                    DateTime.Now.ToString();

                receipt.ShowDialog();

                LoadTransactions();

                txtAmount.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
