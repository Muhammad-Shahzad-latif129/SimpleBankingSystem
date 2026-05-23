namespace SimpleBankingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            pnlLeft = new Panel();
            label1 = new Label();
            picturelogo = new PictureBox();
            pnlRight = new Panel();
            lblwelcome = new Label();
            pnlLoginCard = new Panel();
            chkShowPassword = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturelogo).BeginInit();
            pnlRight.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 242);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Banking System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(104, 68);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(110, 187);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(271, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 37);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.MouseEnter += txtPassword_Enter;
            txtPassword.MouseLeave += txtPassword_Leave;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(271, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 37);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyPress += UsernameInput;
            txtUsername.MouseEnter += txtUsername_Enter;
            txtUsername.MouseLeave += txtUsername_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(271, 384);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += ButtonHover;
            btnLogin.MouseLeave += ButtonLeave;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.SteelBlue;
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(picturelogo);
            pnlLeft.Controls.Add(lblTitle);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(450, 823);
            pnlLeft.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 387);
            label1.Name = "label1";
            label1.Size = new Size(434, 48);
            label1.TabIndex = 7;
            label1.Text = "Smart • Secure • Reliable";
            // 
            // picturelogo
            // 
            picturelogo.BackColor = Color.Transparent;
            picturelogo.Image = (Image)resources.GetObject("picturelogo.Image");
            picturelogo.Location = new Point(154, 46);
            picturelogo.Name = "picturelogo";
            picturelogo.Size = new Size(130, 131);
            picturelogo.SizeMode = PictureBoxSizeMode.Zoom;
            picturelogo.TabIndex = 6;
            picturelogo.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(lblwelcome);
            pnlRight.Controls.Add(pnlLoginCard);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(450, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(846, 823);
            pnlRight.TabIndex = 7;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.ForeColor = Color.Navy;
            lblwelcome.Location = new Point(331, 46);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(327, 60);
            lblwelcome.TabIndex = 1;
            lblwelcome.Text = "Welcome Back";
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.White;
            pnlLoginCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginCard.Controls.Add(chkShowPassword);
            pnlLoginCard.Controls.Add(pictureBox2);
            pnlLoginCard.Controls.Add(pictureBox1);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(lblUsername);
            pnlLoginCard.Location = new Point(226, 136);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(547, 547);
            pnlLoginCard.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(271, 250);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(172, 32);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1296, 823);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Banking System - Login";
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturelogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Panel pnlLeft;
        private Panel pnlRight;
        private Panel pnlLoginCard;
        private PictureBox picturelogo;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox chkShowPassword;
        private Label lblwelcome;
    }
}
