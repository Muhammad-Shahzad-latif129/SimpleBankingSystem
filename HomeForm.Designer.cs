namespace SimpleBankingSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            panelWelcome = new Panel();
            lblWelcome = new Label();
            panelStats = new Panel();
            recenttransactions = new Label();
            panelStaff = new Panel();
            label8 = new Label();
            label4 = new Label();
            lblTotalStaff = new Label();
            panelTransactions = new Panel();
            label7 = new Label();
            label3 = new Label();
            lblTotalTransactions = new Label();
            panelAccounts = new Panel();
            label6 = new Label();
            lblTotalAccounts = new Label();
            label2 = new Label();
            panelCustomer = new Panel();
            label5 = new Label();
            lblTotalCustomers = new Label();
            label1 = new Label();
            panelGridContainer = new Panel();
            dgvRecentTransactions = new DataGridView();
            panelRecent = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panelWelcome.SuspendLayout();
            panelStats.SuspendLayout();
            panelStaff.SuspendLayout();
            panelTransactions.SuspendLayout();
            panelAccounts.SuspendLayout();
            panelCustomer.SuspendLayout();
            panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            panelRecent.SuspendLayout();
            SuspendLayout();
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.White;
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(0, 0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(1293, 100);
            panelWelcome.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Navy;
            lblWelcome.Location = new Point(3, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(491, 60);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back, Admin";
            // 
            // panelStats
            // 
            panelStats.AutoSize = true;
            panelStats.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelStats.Controls.Add(recenttransactions);
            panelStats.Controls.Add(panelStaff);
            panelStats.Controls.Add(panelTransactions);
            panelStats.Controls.Add(panelAccounts);
            panelStats.Controls.Add(panelCustomer);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 100);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(1293, 184);
            panelStats.TabIndex = 1;
            // 
            // recenttransactions
            // 
            recenttransactions.AutoSize = true;
            recenttransactions.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recenttransactions.ForeColor = Color.Navy;
            recenttransactions.Location = new Point(12, 139);
            recenttransactions.Name = "recenttransactions";
            recenttransactions.Size = new Size(315, 45);
            recenttransactions.TabIndex = 0;
            recenttransactions.Text = "Recent Transactions";
            // 
            // panelStaff
            // 
            panelStaff.BackColor = Color.White;
            panelStaff.BorderStyle = BorderStyle.FixedSingle;
            panelStaff.Controls.Add(panel4);
            panelStaff.Controls.Add(label8);
            panelStaff.Controls.Add(label4);
            panelStaff.Controls.Add(lblTotalStaff);
            panelStaff.Location = new Point(1051, 23);
            panelStaff.Margin = new Padding(15);
            panelStaff.Name = "panelStaff";
            panelStaff.Padding = new Padding(10);
            panelStaff.Size = new Size(242, 112);
            panelStaff.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Emoji", 12F);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(-1, 23);
            label8.Name = "label8";
            label8.Size = new Size(47, 32);
            label8.TabIndex = 6;
            label8.Text = "👨‍💼";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(52, 26);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 4;
            label4.Text = "Total Staff";
            // 
            // lblTotalStaff
            // 
            lblTotalStaff.AutoSize = true;
            lblTotalStaff.BackColor = Color.White;
            lblTotalStaff.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalStaff.ForeColor = Color.Black;
            lblTotalStaff.Location = new Point(0, 57);
            lblTotalStaff.Name = "lblTotalStaff";
            lblTotalStaff.Size = new Size(46, 54);
            lblTotalStaff.TabIndex = 3;
            lblTotalStaff.Text = "0";
            // 
            // panelTransactions
            // 
            panelTransactions.BackColor = Color.White;
            panelTransactions.BorderStyle = BorderStyle.FixedSingle;
            panelTransactions.Controls.Add(panel3);
            panelTransactions.Controls.Add(label7);
            panelTransactions.Controls.Add(label3);
            panelTransactions.Controls.Add(lblTotalTransactions);
            panelTransactions.Location = new Point(703, 23);
            panelTransactions.Margin = new Padding(15);
            panelTransactions.Name = "panelTransactions";
            panelTransactions.Padding = new Padding(10);
            panelTransactions.Size = new Size(247, 112);
            panelTransactions.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Emoji", 12F);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(-1, 23);
            label7.Name = "label7";
            label7.Size = new Size(47, 32);
            label7.TabIndex = 6;
            label7.Text = "💰";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(52, 23);
            label3.Name = "label3";
            label3.Size = new Size(183, 28);
            label3.TabIndex = 4;
            label3.Text = "Total Transactions";
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.BackColor = Color.White;
            lblTotalTransactions.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalTransactions.ForeColor = Color.Black;
            lblTotalTransactions.Location = new Point(0, 55);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(46, 54);
            lblTotalTransactions.TabIndex = 3;
            lblTotalTransactions.Text = "0";
            // 
            // panelAccounts
            // 
            panelAccounts.BackColor = Color.White;
            panelAccounts.BorderStyle = BorderStyle.FixedSingle;
            panelAccounts.Controls.Add(panel2);
            panelAccounts.Controls.Add(label6);
            panelAccounts.Controls.Add(lblTotalAccounts);
            panelAccounts.Controls.Add(label2);
            panelAccounts.Location = new Point(345, 23);
            panelAccounts.Margin = new Padding(15);
            panelAccounts.Name = "panelAccounts";
            panelAccounts.Padding = new Padding(10);
            panelAccounts.Size = new Size(255, 112);
            panelAccounts.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Emoji", 12F);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(-2, 23);
            label6.Name = "label6";
            label6.Size = new Size(47, 32);
            label6.TabIndex = 4;
            label6.Text = "💳";
            // 
            // lblTotalAccounts
            // 
            lblTotalAccounts.AutoSize = true;
            lblTotalAccounts.BackColor = Color.White;
            lblTotalAccounts.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalAccounts.ForeColor = Color.Black;
            lblTotalAccounts.Location = new Point(-1, 55);
            lblTotalAccounts.Name = "lblTotalAccounts";
            lblTotalAccounts.Size = new Size(46, 54);
            lblTotalAccounts.TabIndex = 2;
            lblTotalAccounts.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(63, 27);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Total Accounts";
            label2.Click += label2_Click;
            // 
            // panelCustomer
            // 
            panelCustomer.BackColor = Color.White;
            panelCustomer.BorderStyle = BorderStyle.FixedSingle;
            panelCustomer.Controls.Add(panel1);
            panelCustomer.Controls.Add(label5);
            panelCustomer.Controls.Add(lblTotalCustomers);
            panelCustomer.Controls.Add(label1);
            panelCustomer.Location = new Point(20, 23);
            panelCustomer.Margin = new Padding(15);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Padding = new Padding(10);
            panelCustomer.Size = new Size(247, 112);
            panelCustomer.TabIndex = 0;
            panelCustomer.Paint += panelCustomer_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Emoji", 12F);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(-1, 23);
            label5.Name = "label5";
            label5.Size = new Size(47, 32);
            label5.TabIndex = 3;
            label5.Text = "👤";
            label5.Click += label5_Click;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.BackColor = Color.White;
            lblTotalCustomers.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalCustomers.ForeColor = Color.Black;
            lblTotalCustomers.Location = new Point(0, 55);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(46, 54);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "0";
            lblTotalCustomers.Click += lblTotalCustomers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(52, 27);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Total Customers";
            // 
            // panelGridContainer
            // 
            panelGridContainer.BorderStyle = BorderStyle.FixedSingle;
            panelGridContainer.Controls.Add(dgvRecentTransactions);
            panelGridContainer.Dock = DockStyle.Fill;
            panelGridContainer.Location = new Point(20, 20);
            panelGridContainer.Name = "panelGridContainer";
            panelGridContainer.Padding = new Padding(10);
            panelGridContainer.Size = new Size(1253, 372);
            panelGridContainer.TabIndex = 2;
            // 
            // dgvRecentTransactions
            // 
            dgvRecentTransactions.AllowUserToAddRows = false;
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentTransactions.BackgroundColor = Color.White;
            dgvRecentTransactions.BorderStyle = BorderStyle.None;
            dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTransactions.Dock = DockStyle.Fill;
            dgvRecentTransactions.Location = new Point(10, 10);
            dgvRecentTransactions.MultiSelect = false;
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.ReadOnly = true;
            dgvRecentTransactions.RowHeadersVisible = false;
            dgvRecentTransactions.RowHeadersWidth = 62;
            dgvRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentTransactions.Size = new Size(1231, 350);
            dgvRecentTransactions.TabIndex = 0;
            // 
            // panelRecent
            // 
            panelRecent.BackColor = Color.White;
            panelRecent.Controls.Add(panelGridContainer);
            panelRecent.Dock = DockStyle.Fill;
            panelRecent.Location = new Point(0, 284);
            panelRecent.Name = "panelRecent";
            panelRecent.Padding = new Padding(20);
            panelRecent.Size = new Size(1293, 412);
            panelRecent.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(10, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 10);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(13, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 10);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(13, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 10);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Crimson;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(13, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 10);
            panel4.TabIndex = 7;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1293, 696);
            Controls.Add(panelRecent);
            Controls.Add(panelStats);
            Controls.Add(panelWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "Home";
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelStaff.ResumeLayout(false);
            panelStaff.PerformLayout();
            panelTransactions.ResumeLayout(false);
            panelTransactions.PerformLayout();
            panelAccounts.ResumeLayout(false);
            panelAccounts.PerformLayout();
            panelCustomer.ResumeLayout(false);
            panelCustomer.PerformLayout();
            panelGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            panelRecent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelWelcome;
        private Label lblWelcome;
        private Panel panelStats;
        private Panel panelCustomer;
        private Panel panelStaff;
        private Panel panelTransactions;
        private Panel panelAccounts;
        private Label label1;
        private Label lblTotalAccounts;
        private Label label2;
        private Label lblTotalCustomers;
        private Label lblTotalStaff;
        private Label lblTotalTransactions;
        private Label label4;
        private Label label3;
        private Label recenttransactions;
        private Panel panelGridContainer;
        private DataGridView dgvRecentTransactions;
        private Panel panelRecent;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}