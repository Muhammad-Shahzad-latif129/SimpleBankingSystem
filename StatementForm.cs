using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace SimpleBankingSystem
{
    public partial class StatementForm : Form
    {
        public StatementForm()
        {
            InitializeComponent();
            this.FormBorderStyle =
    FormBorderStyle.None;
            this.DoubleBuffered = true;
        }
        private void FilterTransactions()
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
                        "SELECT * FROM Transactions " +
                        "WHERE AccountNumber LIKE @search";

                    // FILTER BY TYPE

                    if (cmbFilter.Text != "All")
                    {
                        query +=
                            " AND TransactionType=@type";
                    }

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" + txtSearch.Text + "%");

                    if (cmbFilter.Text != "All")
                    {
                        cmd.Parameters.AddWithValue(
                            "@type",
                            cmbFilter.Text);
                    }

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvStatement.DataSource =
                        dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void StatementForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            dgvStatement.RowHeadersVisible = false;
            dgvStatement.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatement.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            dgvStatement.BorderStyle = BorderStyle.None;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string accountNumber =
                cmbAccount.SelectedValue
                .ToString();

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
                    "T.TransactionType, " +
                    "A.AccountType, " +
                    "T.Amount, " +
                    "T.TransactionDate " +
                    "FROM Transactions T " +
                    "INNER JOIN Account A " +
                    "ON T.AccountNumber = A.AccountNumber " +
                    "WHERE T.AccountNumber=@account " +
                    "ORDER BY T.TransactionDate DESC";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@account", accountNumber);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvStatement.DataSource = dt;

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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (dgvStatement.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No statement data found.");

                return;
            }

            SaveFileDialog save =
                new SaveFileDialog();

            save.Filter =
                "PDF File|*.pdf";

            save.Title =
                "Save Statement";

            save.FileName =
                "BankStatement.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document document =
                        new Document();

                    PdfWriter.GetInstance(
                        document,
                        new FileStream(
                            save.FileName,
                            FileMode.Create));

                    document.Open();

                    Paragraph title =
                        new Paragraph(
                            "Simple Banking System Statement");

                    title.Alignment =
                        Element.ALIGN_CENTER;

                    title.SpacingAfter = 20f;

                    document.Add(title);

                    PdfPTable table =
                        new PdfPTable(
                            dgvStatement.Columns.Count);

                    // HEADERS

                    foreach (DataGridViewColumn column
                        in dgvStatement.Columns)
                    {
                        table.AddCell(
                            column.HeaderText);
                    }

                    // ROWS

                    foreach (DataGridViewRow row
                        in dgvStatement.Rows)
                    {
                        foreach (DataGridViewCell cell
                            in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                table.AddCell(
                                    cell.Value.ToString());
                            }
                        }
                    }

                    document.Add(table);

                    document.Close();

                    MessageBox.Show(
                        "Statement Downloaded Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }
    }
}
