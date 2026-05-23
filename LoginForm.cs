using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
namespace SimpleBankingSystem
{
    public partial class LoginForm : Form
    {
        public static string LoggedInRole = "";
        public static int LoggedInStaffID = 0;
        public LoginForm()
        {

            InitializeComponent();

            this.AcceptButton = btnLogin;

            this.WindowState =
                FormWindowState.Maximized;

            this.FormBorderStyle =
                FormBorderStyle.None;
            this.KeyPreview = true;

            this.DoubleBuffered = true;

        }
        private void LoginForm_KeyDown(
    object sender,
    KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UIHelper.RoundButton(btnLogin);
            txtUsername.Text = "Enter Username";
            txtUsername.ForeColor = Color.Gray;

            txtPassword.Text = "Enter Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
            string connectionString =
                        "Server=localhost\\SQLEXPRESS;" +
                        "Database=SimpleBankingSystemDB;" +
                        "Trusted_Connection=True;";
            SqlConnection con = new(connectionString);
            try
            {
                con.Open();
                //MessageBox.Show("Database Connected Successfully!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username =
                txtUsername.Text.Trim();

            string password =
                txtPassword.Text.Trim();
            if (username == "Enter Username" ||
    password == "Enter Password")
            {
                MessageBox.Show(
                    "Please enter username and password.");

                return;
            }
            string hashedPassword =
    HashPassword(password);

            // EMPTY CHECK

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter username and password.");

                return;
            }

            // LENGTH VALIDATION

            if (username.Length > 50)
            {
                MessageBox.Show(
                    "Username too long.");

                return;
            }

            if (password.Length > 50)
            {
                MessageBox.Show(
                    "Password too long.");

                return;
            }

            string connectionString =
                "Server=localhost\\SQLEXPRESS;" +
                "Database=SimpleBankingSystemDB;" +
                "Trusted_Connection=True;";

            try
            {
                Cursor = Cursors.WaitCursor;

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string query =
                        "SELECT StaffID, Role " +
                        "FROM Staff " +
                        "WHERE Username=@username " +
                        "AND PasswordHash=@password";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@username",
                            username);

                        cmd.Parameters.AddWithValue(
                            "@password",
                            hashedPassword);

                        SqlDataReader reader =
                            cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            LoggedInStaffID =
                                Convert.ToInt32(
                                    reader["StaffID"]);

                            LoggedInRole =
                                reader["Role"].ToString();

                            // LOAD BALANCES INTO CACHE (Dictionary Data structure)
                            //Accounts loaded here and there balance because they are needed for the dashboard statistics and we want to avoid multiple database calls later on.
                            //used in withdraw , deposit, transfer and statement forms to show the current balance without needing to query the database again.
                            BankCache.LoadBalances();

                            Cursor = Cursors.Default;

                            this.Hide();

                            DashboardForm dashboard =
                                new DashboardForm();

                            dashboard.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            Cursor = Cursors.Default;

                            MessageBox.Show(
                                "Invalid Username or Password");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;

                MessageBox.Show(
                    "System error: " + ex.Message);
            }
        }
        public static string HashPassword(
    string password)
        {
            using (SHA256 sha256 =
                SHA256.Create())
            {
                byte[] bytes =
                    Encoding.UTF8.GetBytes(password);

                byte[] hash =
                    sha256.ComputeHash(bytes);

                StringBuilder builder =
                    new StringBuilder();

                foreach (byte b in hash)
                {
                    builder.Append(
                        b.ToString("x2"));
                }

                return builder.ToString();
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

        private void UsernameInput(object sender, KeyPressEventArgs e)
        {
            // BLOCK SPACES

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text !=
                "Enter Password")
            {
                txtPassword.UseSystemPasswordChar =
                    !chkShowPassword.Checked;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsername_Enter(
    object sender,
    EventArgs e)
        {
            if (txtUsername.Text ==
                "Enter Username")
            {
                txtUsername.Text = "";

                txtUsername.ForeColor =
                    Color.Black;
            }
        }
        private void txtUsername_Leave(
    object sender,
    EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtUsername.Text))
            {
                txtUsername.Text =
                    "Enter Username";

                txtUsername.ForeColor =
                    Color.Gray;
            }
        }
        private void txtPassword_Enter(
    object sender,
    EventArgs e)
        {
            if (txtPassword.Text ==
                "Enter Password")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor =
                    Color.Black;

                txtPassword.UseSystemPasswordChar =
                    true;
            }
        }
        private void txtPassword_Leave(
    object sender,
    EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar =
                    false;

                txtPassword.Text =
                    "Enter Password";

                txtPassword.ForeColor =
                    Color.Gray;
            }
        }
    }
}

