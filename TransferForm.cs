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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            this.FormBorderStyle =
    FormBorderStyle.None;
            this.DoubleBuffered = true;
        }
        private void SearchToAccount()
        {
            string search =
                txtToSearch.Text.Trim();

            for (int i = 0;
                 i < cmbTo.Items.Count;
                 i++)
            {
                DataRowView row =
                    (DataRowView)
                    cmbTo.Items[i];

                string accountNumber =
                    row["AccountNumber"]
                    .ToString();

                if (accountNumber.Contains(search))
                {
                    cmbTo.SelectedIndex = i;

                    return;
                }
            }
        }
        private void SearchFromAccount()
        {
            string search =
                txtFromSearch.Text.Trim();

            for (int i = 0;
                 i < cmbFrom.Items.Count;
                 i++)
            {
                DataRowView row =
                    (DataRowView)
                    cmbFrom.Items[i];

                string accountNumber =
                    row["AccountNumber"]
                    .ToString();

                if (accountNumber.Contains(search))
                {
                    cmbFrom.SelectedIndex = i;

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

                cmbFrom.DataSource = dt.Copy();

                cmbFrom.DisplayMember =
                    "DisplayText";

                cmbFrom.ValueMember =
                    "AccountNumber";

                cmbTo.DataSource = dt;

                cmbTo.DisplayMember =
                    "DisplayText";

                cmbTo.ValueMember =
                    "AccountNumber";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTransfers()
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
                    "T.AccountNumber AS SenderAccount, " +
                    "C.FullName AS SenderName, " +
                    "A.AccountType, " +
                    "T.Amount, " +
                    "T.TransactionDate " +
                    "FROM Transactions T " +
                    "INNER JOIN Account A " +
                    "ON T.AccountNumber = A.AccountNumber " +
                    "INNER JOIN Customer C " +
                    "ON A.CustomerID = C.CustomerID " +
                    "WHERE T.TransactionType='Transfer' " +
                    "ORDER BY T.TransactionDate DESC";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTransfer.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();

            LoadTransfers();
            dgvTransfer.RowHeadersVisible = false;
            dgvTransfer.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransfer.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            dgvTransfer.BorderStyle = BorderStyle.None;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // VALIDATE ACCOUNT SELECTION

            if (cmbFrom.SelectedValue == null ||
                cmbTo.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select accounts.");
                return;
            }

            string fromAccount =
                cmbFrom.SelectedValue.ToString();

            string toAccount =
                cmbTo.SelectedValue.ToString();

            // SAME ACCOUNT CHECK

            if (fromAccount == toAccount)
            {
                MessageBox.Show(
                    "Cannot transfer to same account!");
                return;
            }

            // EMPTY AMOUNT CHECK

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show(
                    "Please enter amount.");
                return;
            }

            // SAFE AMOUNT PARSING

            if (!decimal.TryParse(
                txtAmount.Text,
                out decimal amount))
            {
                MessageBox.Show(
                    "Enter valid numeric amount.");
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

                    // SQL TRANSACTION
                    // Ensures all database operations succeed together

                    SqlTransaction transaction =
                        con.BeginTransaction();

                    try
                    {
                        // ================================
                        // DSA USED HERE -> DICTIONARY
                        // Hash Table Lookup
                        // O(1) Fast Searching
                        // ================================

                        // CHECK SENDER ACCOUNT EXISTS
                        // USING DICTIONARY CACHE

                        if (!BankCache.AccountBalances
                            .ContainsKey(fromAccount))
                        {
                            MessageBox.Show(
                                "Sender account not found.");

                            transaction.Rollback();

                            return;
                        }

                        // GET BALANCE FROM DICTIONARY
                        // INSTEAD OF SQL QUERY

                        decimal currentBalance =
                            BankCache.AccountBalances
                            [fromAccount];

                        // INSUFFICIENT BALANCE CHECK

                        if (amount > currentBalance)
                        {
                            MessageBox.Show(
                                "Insufficient Balance!");

                            transaction.Rollback();

                            return;
                        }

                        // CHECK RECEIVER EXISTS
                        // USING DICTIONARY CACHE

                        if (!BankCache.AccountBalances
                            .ContainsKey(toAccount))
                        {
                            MessageBox.Show(
                                "Receiver account not found.");

                            transaction.Rollback();

                            return;
                        }

                        // ================================
                        // DATABASE OPERATIONS
                        // ================================

                        // DEDUCT FROM SENDER

                        string deductQuery =
                            "UPDATE Account " +
                            "SET Balance = Balance - @amount " +
                            "WHERE AccountNumber=@from";

                        SqlCommand deductCmd =
                            new SqlCommand(
                                deductQuery,
                                con,
                                transaction);

                        deductCmd.Parameters.AddWithValue(
                            "@amount",
                            amount);

                        deductCmd.Parameters.AddWithValue(
                            "@from",
                            fromAccount);

                        deductCmd.ExecuteNonQuery();

                        // ADD TO RECEIVER

                        string addQuery =
                            "UPDATE Account " +
                            "SET Balance = Balance + @amount " +
                            "WHERE AccountNumber=@to";

                        SqlCommand addCmd =
                            new SqlCommand(
                                addQuery,
                                con,
                                transaction);

                        addCmd.Parameters.AddWithValue(
                            "@amount",
                            amount);

                        addCmd.Parameters.AddWithValue(
                            "@to",
                            toAccount);

                        addCmd.ExecuteNonQuery();

                        // ================================
                        // DSA USED HERE -> CACHE UPDATE
                        // SYNCHRONIZING DICTIONARY
                        // ================================

                        // UPDATE SENDER BALANCE
                        // IN DICTIONARY CACHE

                        BankCache.AccountBalances
                            [fromAccount] -= amount;

                        // UPDATE RECEIVER BALANCE
                        // IN DICTIONARY CACHE

                        BankCache.AccountBalances
                            [toAccount] += amount;

                        // SAVE TRANSACTION HISTORY

                        string insertQuery =
                            "INSERT INTO Transactions " +
                            "(AccountNumber, StaffID, " +
                            "TransactionType, Amount) " +
                            "VALUES " +
                            "(@from, @staffID, " +
                            "'Transfer', @amount)";

                        SqlCommand insertCmd =
                            new SqlCommand(
                                insertQuery,
                                con,
                                transaction);

                        insertCmd.Parameters.AddWithValue(
                            "@from",
                            fromAccount);

                        insertCmd.Parameters.AddWithValue(
                            "@staffID",
                            staffID);

                        insertCmd.Parameters.AddWithValue(
                            "@amount",
                            amount);

                        insertCmd.ExecuteNonQuery();

                        // COMMIT DATABASE TRANSACTION

                        transaction.Commit();

                        MessageBox.Show(
                            "Transfer Successful!");
                        DashboardForm.Instance.ShowStatus( "Transfer Completed");

                        LoadTransfers();

                        txtAmount.Clear();
                    }
                    catch
                    {
                        transaction.Rollback();

                        throw;
                    }
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

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void txtFromSearch_TextChanged(object sender, EventArgs e)
        {
            SearchFromAccount();
        }

        private void txtToSearch_TextChanged(object sender, EventArgs e)
        {
            SearchToAccount();
        }
    }
}
