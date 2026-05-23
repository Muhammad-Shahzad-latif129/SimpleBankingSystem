using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
namespace SimpleBankingSystem
{
    public partial class StaffForm : Form
    {
        int selectedStaffID = 0;
        public StaffForm()
        {
            InitializeComponent();
            this.FormBorderStyle =
    FormBorderStyle.None;
            this.DoubleBuffered = true;
        }

        private void LoadStaff()
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
                    "SELECT * FROM Staff";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvStaff.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            
            LoadStaff();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            string hashedPassword =
    LoginForm.HashPassword(
        txtPassword.Text);

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query =
                        "INSERT INTO Staff (FullName, Username, PasswordHash, Role) " +
                        "VALUES (@fullname, @username, @password, @role)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", cmbRole.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Staff added successfully!");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvStaff.Rows[e.RowIndex];

                selectedStaffID =
                    Convert.ToInt32(
                        row.Cells["StaffID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value
    .ToString();
                txtUsername.Text =
                    row.Cells["Username"].Value
                    .ToString();

                txtPassword.Text =
                    row.Cells["PasswordHash"].Value
                    .ToString();

                cmbRole.Text =
                    row.Cells["Role"].Value
                    .ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    "UPDATE Staff " +
                    "SET FullName=@fullname, " +
                    "Username=@username, " +
                    "PasswordHash=@password, " +
                    "Role=@role " +
                    "WHERE StaffID=@id";

                SqlCommand cmd =
                    new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                cmd.Parameters.AddWithValue(
                    "@password",
                    txtPassword.Text);

                cmd.Parameters.AddWithValue(
                    "@role",
                    cmbRole.Text);

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedStaffID);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Staff Updated Successfully!");

                LoadStaff();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    "DELETE FROM Staff " +
                    "WHERE StaffID=@id";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@id",
                    selectedStaffID);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Staff Deleted Successfully!");

                LoadStaff();

                ClearFields();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            txtFullName.Clear();
            txtUsername.Clear();

            txtPassword.Clear();

            cmbRole.SelectedIndex = -1;

            selectedStaffID = 0;

        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.");
                return false;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.");
                return false;
            }

            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void LettersOnly(object sender, KeyPressEventArgs e)
        {
            // ALLOW CONTROL KEYS

            if (char.IsControl(e.KeyChar))
                return;

            // ALLOW LETTERS + SPACE

            if (char.IsLetter(e.KeyChar) ||
                e.KeyChar == ' ')
                return;

            // BLOCK EVERYTHING ELSE

            e.Handled = true;
        }

        private void UsernameInput(object sender, KeyPressEventArgs e)
        {
            // BLOCK SPACES

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
