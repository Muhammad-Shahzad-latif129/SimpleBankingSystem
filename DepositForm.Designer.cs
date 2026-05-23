namespace SimpleBankingSystem
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            lblTitle = new Label();
            lblAccount = new Label();
            lblAmount = new Label();
            cmbAccount = new ComboBox();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            dgvTransactions = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearchAccount = new TextBox();
            lblSearch = new Label();
            panelleft = new Panel();
            panelgrid = new Panel();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            groupBox1.SuspendLayout();
            panelleft.SuspendLayout();
            panelgrid.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(287, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Deposit Money";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(7, 230);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(84, 28);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "Account";
            lblAccount.Click += lblAccount_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(7, 306);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 28);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(128, 227);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(288, 36);
            cmbAccount.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(128, 306);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(185, 34);
            txtAmount.TabIndex = 4;
            txtAmount.KeyPress += DecimalOnly;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.SteelBlue;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(214, 372);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(123, 38);
            btnDeposit.TabIndex = 5;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            btnDeposit.MouseEnter += ButtonHover;
            btnDeposit.MouseLeave += ButtonLeave;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.Location = new Point(10, 87);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(843, 529);
            dgvTransactions.TabIndex = 6;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchAccount);
            groupBox1.Controls.Add(lblSearch);
            groupBox1.Controls.Add(btnDeposit);
            groupBox1.Controls.Add(cmbAccount);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(lblAccount);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 586);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.BorderStyle = BorderStyle.FixedSingle;
            txtSearchAccount.Location = new Point(163, 133);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(150, 34);
            txtSearchAccount.TabIndex = 7;
            txtSearchAccount.TextChanged += txtSearchAccount_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(8, 133);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(147, 28);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Search Account";
            // 
            // panelleft
            // 
            panelleft.Controls.Add(groupBox1);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 0);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(441, 628);
            panelleft.TabIndex = 8;
            // 
            // panelgrid
            // 
            panelgrid.BackColor = Color.White;
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(dgvTransactions);
            panelgrid.Controls.Add(panelTop);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(441, 0);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(865, 628);
            panelgrid.TabIndex = 9;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(843, 77);
            panelTop.TabIndex = 0;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1306, 628);
            Controls.Add(panelgrid);
            Controls.Add(panelleft);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DepositForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepositForm";
            WindowState = FormWindowState.Maximized;
            Load += DepositForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelleft.ResumeLayout(false);
            panelgrid.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblAccount;
        private Label lblAmount;
        private ComboBox cmbAccount;
        private TextBox txtAmount;
        private Button btnDeposit;
        private DataGridView dgvTransactions;
        private GroupBox groupBox1;
        private Panel panelleft;
        private Panel panelgrid;
        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearchAccount;
    }
}