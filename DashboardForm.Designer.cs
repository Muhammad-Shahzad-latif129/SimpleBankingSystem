namespace SimpleBankingSystem
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            btnCustomers = new Button();
            btnAccounts = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnTransfer = new Button();
            btnStatement = new Button();
            btnStaff = new Button();
            panelMenu = new Panel();
            panelbelow = new Panel();
            btnLogout = new Button();
            flowmenu = new FlowLayoutPanel();
            btnHome = new Button();
            paneltopm = new Panel();
            picturelogo = new PictureBox();
            panellogo = new Label();
            panelHeader = new Panel();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelContainer = new Panel();
            statusBar = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblUser = new ToolStripStatusLabel();
            lblDateTime_1 = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelbelow.SuspendLayout();
            flowmenu.SuspendLayout();
            paneltopm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturelogo).BeginInit();
            panelHeader.SuspendLayout();
            panelContainer.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.SteelBlue;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(100, 120);
            btnCustomers.Margin = new Padding(90, 30, 10, 5);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(180, 45);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            btnCustomers.MouseEnter += MenuHover;
            btnCustomers.MouseLeave += MenuLeave;
            // 
            // btnAccounts
            // 
            btnAccounts.BackColor = Color.SteelBlue;
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnAccounts.ForeColor = Color.White;
            btnAccounts.Location = new Point(100, 200);
            btnAccounts.Margin = new Padding(90, 30, 10, 5);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(180, 45);
            btnAccounts.TabIndex = 2;
            btnAccounts.Text = "Accounts";
            btnAccounts.UseVisualStyleBackColor = false;
            btnAccounts.Click += btnAccounts_Click;
            btnAccounts.MouseEnter += MenuHover;
            btnAccounts.MouseLeave += MenuLeave;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.SteelBlue;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(100, 280);
            btnDeposit.Margin = new Padding(90, 30, 10, 5);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(180, 45);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            btnDeposit.MouseEnter += MenuHover;
            btnDeposit.MouseLeave += MenuLeave;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.SteelBlue;
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Location = new Point(100, 360);
            btnWithdraw.Margin = new Padding(90, 30, 10, 5);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(180, 45);
            btnWithdraw.TabIndex = 4;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            btnWithdraw.MouseEnter += MenuHover;
            btnWithdraw.MouseLeave += MenuLeave;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.SteelBlue;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(100, 440);
            btnTransfer.Margin = new Padding(90, 30, 10, 5);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(180, 45);
            btnTransfer.TabIndex = 5;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            btnTransfer.MouseEnter += MenuHover;
            btnTransfer.MouseLeave += MenuLeave;
            // 
            // btnStatement
            // 
            btnStatement.BackColor = Color.SteelBlue;
            btnStatement.FlatAppearance.BorderSize = 0;
            btnStatement.FlatStyle = FlatStyle.Flat;
            btnStatement.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnStatement.ForeColor = Color.White;
            btnStatement.Location = new Point(100, 600);
            btnStatement.Margin = new Padding(90, 30, 10, 5);
            btnStatement.Name = "btnStatement";
            btnStatement.Size = new Size(180, 45);
            btnStatement.TabIndex = 6;
            btnStatement.Text = "Statement";
            btnStatement.UseVisualStyleBackColor = false;
            btnStatement.Click += btnStatement_Click;
            btnStatement.MouseEnter += MenuHover;
            btnStatement.MouseLeave += MenuLeave;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.SteelBlue;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnStaff.ForeColor = Color.White;
            btnStaff.Location = new Point(100, 520);
            btnStaff.Margin = new Padding(90, 30, 10, 5);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(180, 45);
            btnStaff.TabIndex = 11;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            btnStaff.MouseEnter += MenuHover;
            btnStaff.MouseLeave += MenuLeave;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(panelbelow);
            panelMenu.Controls.Add(flowmenu);
            panelMenu.Controls.Add(paneltopm);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(10, 10);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(427, 574);
            panelMenu.TabIndex = 13;
            // 
            // panelbelow
            // 
            panelbelow.Controls.Add(btnLogout);
            panelbelow.Dock = DockStyle.Bottom;
            panelbelow.Location = new Point(0, 425);
            panelbelow.Name = "panelbelow";
            panelbelow.Size = new Size(427, 149);
            panelbelow.TabIndex = 16;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(280, 51);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 70);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // flowmenu
            // 
            flowmenu.AutoScroll = true;
            flowmenu.Controls.Add(btnHome);
            flowmenu.Controls.Add(btnCustomers);
            flowmenu.Controls.Add(btnAccounts);
            flowmenu.Controls.Add(btnDeposit);
            flowmenu.Controls.Add(btnWithdraw);
            flowmenu.Controls.Add(btnTransfer);
            flowmenu.Controls.Add(btnStaff);
            flowmenu.Controls.Add(btnStatement);
            flowmenu.Dock = DockStyle.Top;
            flowmenu.FlowDirection = FlowDirection.TopDown;
            flowmenu.Location = new Point(0, 192);
            flowmenu.Name = "flowmenu";
            flowmenu.Padding = new Padding(10);
            flowmenu.Size = new Size(427, 651);
            flowmenu.TabIndex = 16;
            flowmenu.WrapContents = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.SteelBlue;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(100, 40);
            btnHome.Margin = new Padding(90, 30, 10, 5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(180, 45);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            btnHome.MouseEnter += MenuHover;
            btnHome.MouseLeave += MenuLeave;
            // 
            // paneltopm
            // 
            paneltopm.Controls.Add(picturelogo);
            paneltopm.Controls.Add(panellogo);
            paneltopm.Dock = DockStyle.Top;
            paneltopm.Location = new Point(0, 0);
            paneltopm.Name = "paneltopm";
            paneltopm.Size = new Size(427, 192);
            paneltopm.TabIndex = 15;
            // 
            // picturelogo
            // 
            picturelogo.BackColor = Color.Transparent;
            picturelogo.Image = (Image)resources.GetObject("picturelogo.Image");
            picturelogo.Location = new Point(137, 22);
            picturelogo.Name = "picturelogo";
            picturelogo.Size = new Size(101, 103);
            picturelogo.SizeMode = PictureBoxSizeMode.Zoom;
            picturelogo.TabIndex = 1;
            picturelogo.TabStop = false;
            // 
            // panellogo
            // 
            panellogo.Dock = DockStyle.Bottom;
            panellogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panellogo.ForeColor = Color.White;
            panellogo.Location = new Point(0, 154);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(427, 38);
            panellogo.TabIndex = 0;
            panellogo.Text = "BANKING SYSTEM";
            panellogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(861, 98);
            panelHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.SteelBlue;
            lblWelcome.Location = new Point(6, 59);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(188, 30);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(6, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Banking System";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(panelHeader);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(437, 10);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(863, 574);
            panelContainer.TabIndex = 14;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.SteelBlue;
            statusBar.ImageScalingSize = new Size(24, 24);
            statusBar.Items.AddRange(new ToolStripItem[] { lblStatus, lblUser, lblDateTime_1 });
            statusBar.Location = new Point(10, 584);
            statusBar.Name = "statusBar";
            statusBar.RenderMode = ToolStripRenderMode.Professional;
            statusBar.Size = new Size(1290, 32);
            statusBar.TabIndex = 16;
            statusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.Text = "Ready";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 25);
            lblUser.Text = "User";
            // 
            // lblDateTime_1
            // 
            lblDateTime_1.Name = "lblDateTime_1";
            lblDateTime_1.Size = new Size(49, 25);
            lblDateTime_1.Text = "Date";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick_1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1310, 626);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            Controls.Add(statusBar);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "DashboardForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Banking System";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            panelMenu.ResumeLayout(false);
            panelbelow.ResumeLayout(false);
            flowmenu.ResumeLayout(false);
            paneltopm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturelogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContainer.ResumeLayout(false);
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCustomers;
        private Button btnAccounts;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnTransfer;
        private Button btnStatement;
        private Button btnStaff;
        private Panel panelMenu;
        private Panel paneltopm;
        private PictureBox picturelogo;
        private Label panellogo;
        private Panel panelbelow;
        private Button btnLogout;
        private FlowLayoutPanel flowmenu;
        private Button btnHome;
        private Panel panelHeader;
        private Label lblWelcome;
        private Label lblTitle;
        private Panel panelContainer;
        private StatusStrip statusBar;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblUser;
        private System.Windows.Forms.Timer timerClock;
        private ToolStripStatusLabel lblDateTime_1;
    }
}