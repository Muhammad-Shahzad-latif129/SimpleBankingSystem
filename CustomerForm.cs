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
    public partial class CustomerForm : Form
    {
        int selectedCustomerID = 0;
        public CustomerForm()
        {
            InitializeComponent();
            this.FormBorderStyle =
    FormBorderStyle.None;
            this.DoubleBuffered = true;
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInputs())
                return;

            if (CNICExists(txtCNIC.Text))
            {
                MessageBox.Show(
                    "CNIC already exists.");
                return;
            }
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string cnic = txtCNIC.Text;

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                string query =
                    "INSERT INTO Customer " +
                    "(FullName, Phone, CNIC, Address, Email) " +
                    "VALUES (@name, @phone, @cnic, @address, @email)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Added Successfully!");
                LoadCustomers();
                btnClear.PerformClick();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                    "SELECT * FROM Customer";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvCustomers.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            txtSearch.Text =
    "Search Customer...";

            txtSearch.ForeColor =
                Color.Gray;
            txtCNIC.Text = "12345-1234567-1";

            txtCNIC.ForeColor =
                Color.Gray;
            txtPhone.Text = "03XXXXXXXXX";

            txtPhone.ForeColor =
                Color.Gray;
            txtEmail.Text = "example@email.com";

            txtEmail.ForeColor =
                Color.Gray;
            LoadCustomers();
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.BorderStyle = BorderStyle.None;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCustomers.Rows[e.RowIndex];

                if (row.Cells["CustomerID"].Value
                    != null)
                {
                    selectedCustomerID =
                        Convert.ToInt32(
                            row.Cells["CustomerID"].Value);

                    txtName.Text =
                        row.Cells["FullName"]
                        .Value.ToString();

                    txtPhone.Text =
                        row.Cells["Phone"]
                        .Value.ToString();

                    txtAddress.Text =
                        row.Cells["Address"]
                        .Value.ToString();

                    txtCNIC.Text =
                        row.Cells["CNIC"]
                        .Value.ToString();

                    txtEmail.Text = row.Cells["Email"].Value.ToString();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInputs())
                return;

            if (selectedCustomerID == 0)
            {
                MessageBox.Show(
                    "Please select customer.");
                return;
            }

            if (CNICExists(
                txtCNIC.Text,
                selectedCustomerID))
            {
                MessageBox.Show(
                    "CNIC already exists.");
                return;
            }
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
                    "UPDATE Customer SET " +
                    "FullName=@name, " +
                    "Phone=@phone, " +
                    "Address=@address, " +
                    "Email=@email, " +
                    "CNIC=@cnic " +
                    "WHERE CustomerID=@id";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", selectedCustomerID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Updated!");

                LoadCustomers();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NumbersOnly(
    object sender,
    KeyPressEventArgs e)
        {
            // ALLOW CONTROL KEYS

            if (char.IsControl(e.KeyChar))
                return;

            // ALLOW ONLY DIGITS

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool ValidateCustomerInputs()
        {
            // FULL NAME

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Full Name is required.");
                return false;
            }

            if (txtName.Text.Length > 50)
            {
                MessageBox.Show(
                    "Full Name too long.");
                return false;
            }

            // NAME SHOULD NOT CONTAIN NUMBERS

            if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Name cannot contain numbers.");
                return false;
            }

            // PHONE

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone is required.");
                return false;
            }

            // PHONE MUST BE NUMERIC

            if (!txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Phone must contain only numbers.");
                return false;
            }

            // PHONE LENGTH

            if (txtPhone.Text.Length < 10 ||
                txtPhone.Text.Length > 15)
            {
                MessageBox.Show(
                    "Invalid phone number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.");
                return false;
            }

            try
            {
                var mail =
                    new System.Net.Mail.MailAddress(
                        txtEmail.Text);

                if (mail.Address != txtEmail.Text)
                {
                    MessageBox.Show(
                        "Invalid email format.");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(
                    "Invalid email format.");
                return false;
            }
            // CNIC

            if (string.IsNullOrWhiteSpace(txtCNIC.Text))
            {
                MessageBox.Show("CNIC is required.");
                return false;
            }

            // ADDRESS

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.");
                return false;
            }

            return true;
        }
        private bool CNICExists(
            string cnic,
            int currentCustomerID = 0)
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
                    "SELECT COUNT(*) FROM Customer " +
                    "WHERE CNIC=@cnic " +
                    "AND CustomerID!=@id";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@cnic",
                    cnic);

                cmd.Parameters.AddWithValue(
                    "@id",
                    currentCustomerID);

                int count =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                return count > 0;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == 0)
            {
                MessageBox.Show(
                    "Please select customer.");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this customer?",
                    "Confirm Delete",
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
                        "DELETE FROM Customer " +
                        "WHERE CustomerID=@id";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        selectedCustomerID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Customer Deleted!");

                    LoadCustomers();

                    btnClear.PerformClick();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Cannot delete customer because accounts exist.\n" +
                            "Delete customer accounts first.",
                            "Delete Blocked",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtCNIC.Clear();
            txtEmail.Clear();
            selectedCustomerID = 0;

            txtName.Focus();
        }
        private void SearchCustomers()
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
                    "SELECT * FROM Customer " +
                    "WHERE FullName LIKE @search " +
                    "OR CNIC LIKE @search " +
                    "OR Email LIKE @search";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text + "%");

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvCustomers.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            // IGNORE PLACEHOLDER

            if (txtSearch.ForeColor ==
                Color.Gray)
                return;

            // EMPTY SEARCH

            if (string.IsNullOrWhiteSpace(
                txtSearch.Text))
            {
                LoadCustomers();
            }
            else
            {
                SearchCustomers();
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

        private void CNICInput(object sender, KeyPressEventArgs e)
        {
            // ALLOW CONTROL KEYS

            if (char.IsControl(e.KeyChar))
                return;

            // ALLOW DIGITS

            if (char.IsDigit(e.KeyChar))
                return;

            // ALLOW DASH

            if (e.KeyChar == '-')
                return;

            e.Handled = true;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "example@email.com")
            {
                txtEmail.Text = "";

                txtEmail.ForeColor =
                    Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text =
                    "example@email.com";

                txtEmail.ForeColor =
                    Color.Gray;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "03XXXXXXXXX")
            {
                txtPhone.Text = "";

                txtPhone.ForeColor =
                    Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text =
                    "03XXXXXXXXX";

                txtPhone.ForeColor =
                    Color.Gray;
            }
        }

        private void txtCNIC_Enter(object sender, EventArgs e)
        {
            if (txtCNIC.Text ==
    "12345-1234567-1")
            {
                txtCNIC.Text = "";

                txtCNIC.ForeColor =
                    Color.Black;
            }
        }

        private void txtCNIC_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
    txtCNIC.Text))
            {
                txtCNIC.Text =
                    "12345-1234567-1";

                txtCNIC.ForeColor =
                    Color.Gray;
            }
        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            // IGNORE PLACEHOLDER

            if (txtCNIC.ForeColor ==
                Color.Gray)
                return;

            // REMOVE DASHES

            string numbers =
                txtCNIC.Text.Replace("-", "");

            // ALLOW ONLY DIGITS

            numbers =
                new string(
                    numbers
                    .Where(char.IsDigit)
                    .ToArray());

            // LIMIT LENGTH

            if (numbers.Length > 13)
            {
                numbers =
                    numbers.Substring(0, 13);
            }

            // FORMAT CNIC

            string formatted = "";

            if (numbers.Length > 0)
            {
                formatted =
                    numbers.Substring(
                        0,
                        Math.Min(5, numbers.Length));
            }

            if (numbers.Length > 5)
            {
                formatted += "-" +
                    numbers.Substring(
                        5,
                        Math.Min(7,
                        numbers.Length - 5));
            }

            if (numbers.Length > 12)
            {
                formatted += "-" +
                    numbers.Substring(12, 1);
            }

            // PREVENT CURSOR JUMP BUG

            txtCNIC.TextChanged -=
                txtCNIC_TextChanged;

            txtCNIC.Text = formatted;

            txtCNIC.SelectionStart =
                txtCNIC.Text.Length;

            txtCNIC.TextChanged +=
                txtCNIC_TextChanged;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text ==
    "Search Customer...")
            {
                txtSearch.Text = "";

                txtSearch.ForeColor =
                    Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
    txtSearch.Text))
            {
                txtSearch.Text =
                    "Search Customer...";

                txtSearch.ForeColor =
                    Color.Gray;
            }
        }
     

    }
}
