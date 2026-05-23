namespace SimpleBankingSystem
{
    partial class AccountForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblCustomer = new Label();
            lblAccountType = new Label();
            lblBalance = new Label();
            cmbCustomer = new ComboBox();
            cmbAccountType = new ComboBox();
            txtBalance = new TextBox();
            btnCreate = new Button();
            btnClear = new Button();
            dgvAccounts = new DataGridView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            panelleft = new Panel();
            panelgrid = new Panel();
            grpTransactionHistory = new GroupBox();
            dgvTransactionHistory = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            groupBox1.SuspendLayout();
            panelleft.SuspendLayout();
            panelgrid.SuspendLayout();
            grpTransactionHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(202, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(392, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Account Management";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(6, 77);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(96, 28);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer";
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Location = new Point(6, 171);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(130, 28);
            lblAccountType.TabIndex = 2;
            lblAccountType.Text = "Account Type";
            lblAccountType.Click += lblAccountType_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(6, 284);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(131, 28);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Initial Balance";
            lblBalance.Click += lblBalance_Click;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(142, 74);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(274, 36);
            cmbCustomer.TabIndex = 4;
            // 
            // cmbAccountType
            // 
            cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Saving", "Current", "Business" });
            cmbAccountType.Location = new Point(142, 171);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(240, 36);
            cmbAccountType.TabIndex = 5;
            // 
            // txtBalance
            // 
            txtBalance.BorderStyle = BorderStyle.FixedSingle;
            txtBalance.Location = new Point(142, 284);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(200, 34);
            txtBalance.TabIndex = 6;
            txtBalance.KeyPress += DecimalOnly;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.SteelBlue;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(226, 397);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 49);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseEnter += ButtonHover;
            btnCreate.MouseLeave += ButtonLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(144, 476);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 38);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += ButtonHover;
            btnClear.MouseLeave += ButtonLeave;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Dock = DockStyle.Top;
            dgvAccounts.EnableHeadersVisualStyles = false;
            dgvAccounts.Location = new Point(10, 84);
            dgvAccounts.MultiSelect = false;
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersVisible = false;
            dgvAccounts.RowHeadersWidth = 62;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(802, 364);
            dgvAccounts.TabIndex = 9;
            dgvAccounts.CellContentClick += dgvAccounts_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtBalance);
            groupBox1.Controls.Add(lblBalance);
            groupBox1.Controls.Add(lblCustomer);
            groupBox1.Controls.Add(lblAccountType);
            groupBox1.Controls.Add(cmbCustomer);
            groupBox1.Controls.Add(cmbAccountType);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 682);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(2, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 49);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Close Account";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelleft
            // 
            panelleft.Controls.Add(groupBox1);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 0);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(447, 747);
            panelleft.TabIndex = 11;
            // 
            // panelgrid
            // 
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(grpTransactionHistory);
            panelgrid.Controls.Add(dgvAccounts);
            panelgrid.Controls.Add(panel1);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(447, 0);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(824, 747);
            panelgrid.TabIndex = 12;
            // 
            // grpTransactionHistory
            // 
            grpTransactionHistory.BackColor = Color.White;
            grpTransactionHistory.Controls.Add(dgvTransactionHistory);
            grpTransactionHistory.Dock = DockStyle.Fill;
            grpTransactionHistory.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTransactionHistory.ForeColor = Color.Navy;
            grpTransactionHistory.Location = new Point(10, 448);
            grpTransactionHistory.Name = "grpTransactionHistory";
            grpTransactionHistory.Size = new Size(802, 287);
            grpTransactionHistory.TabIndex = 10;
            grpTransactionHistory.TabStop = false;
            grpTransactionHistory.Text = "Transaction History";
            // 
            // dgvTransactionHistory
            // 
            dgvTransactionHistory.AllowUserToAddRows = false;
            dgvTransactionHistory.AllowUserToDeleteRows = false;
            dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionHistory.BackgroundColor = Color.White;
            dgvTransactionHistory.BorderStyle = BorderStyle.None;
            dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionHistory.Dock = DockStyle.Fill;
            dgvTransactionHistory.Location = new Point(3, 33);
            dgvTransactionHistory.MultiSelect = false;
            dgvTransactionHistory.Name = "dgvTransactionHistory";
            dgvTransactionHistory.ReadOnly = true;
            dgvTransactionHistory.RowHeadersVisible = false;
            dgvTransactionHistory.RowHeadersWidth = 62;
            dgvTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionHistory.Size = new Size(796, 251);
            dgvTransactionHistory.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 74);
            panel1.TabIndex = 0;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1271, 747);
            Controls.Add(panelgrid);
            Controls.Add(panelleft);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            WindowState = FormWindowState.Maximized;
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelleft.ResumeLayout(false);
            panelgrid.ResumeLayout(false);
            grpTransactionHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblCustomer;
        private Label lblAccountType;
        private Label lblBalance;
        private ComboBox cmbCustomer;
        private ComboBox cmbAccountType;
        private TextBox txtBalance;
        private Button btnCreate;
        private Button btnClear;
        private DataGridView dgvAccounts;
        private GroupBox groupBox1;
        private Panel panelleft;
        private Panel panelgrid;
        private Panel panel1;
        private Button btnDelete;
        private GroupBox grpTransactionHistory;
        private DataGridView dgvTransactionHistory;
    }
}