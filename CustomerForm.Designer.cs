namespace SimpleBankingSystem
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            panelleft = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            lblName = new Label();
            txtName = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblAddress = new Label();
            lblPhone = new Label();
            txtCNIC = new TextBox();
            lblCNIC = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            panelgrid = new Panel();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
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
            lblTitle.Location = new Point(129, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(415, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Management";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.Location = new Point(10, 166);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(841, 634);
            dgvCustomers.TabIndex = 13;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(6, 99);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(188, 30);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Search Customer";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(215, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(138, 34);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // panelleft
            // 
            panelleft.Controls.Add(txtEmail);
            panelleft.Controls.Add(lblEmail);
            panelleft.Controls.Add(label1);
            panelleft.Controls.Add(btnClear);
            panelleft.Controls.Add(btnDelete);
            panelleft.Controls.Add(lblName);
            panelleft.Controls.Add(txtName);
            panelleft.Controls.Add(btnUpdate);
            panelleft.Controls.Add(btnAdd);
            panelleft.Controls.Add(lblAddress);
            panelleft.Controls.Add(lblPhone);
            panelleft.Controls.Add(txtCNIC);
            panelleft.Controls.Add(lblCNIC);
            panelleft.Controls.Add(txtPhone);
            panelleft.Controls.Add(txtAddress);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 0);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(399, 812);
            panelleft.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(138, 335);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 34);
            txtEmail.TabIndex = 15;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 335);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(261, 48);
            label1.TabIndex = 13;
            label1.Text = "Customer Info";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(270, 695);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 50);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += ButtonHover;
            btnClear.MouseLeave += ButtonLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(35, 695);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 50);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += ButtonHover;
            btnDelete.MouseLeave += ButtonLeave;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 162);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(138, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 34);
            txtName.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(270, 608);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 48);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += ButtonHover;
            btnUpdate.MouseLeave += ButtonLeave;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(35, 608);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 48);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += ButtonHover;
            btnAdd.MouseLeave += ButtonLeave;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 508);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 252);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // txtCNIC
            // 
            txtCNIC.BorderStyle = BorderStyle.FixedSingle;
            txtCNIC.Location = new Point(138, 424);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(255, 34);
            txtCNIC.TabIndex = 8;
            txtCNIC.TextChanged += txtCNIC_TextChanged;
            txtCNIC.Enter += txtCNIC_Enter;
            txtCNIC.Leave += txtCNIC_Leave;
            // 
            // lblCNIC
            // 
            lblCNIC.AutoSize = true;
            lblCNIC.Location = new Point(12, 430);
            lblCNIC.Name = "lblCNIC";
            lblCNIC.Size = new Size(56, 28);
            lblCNIC.TabIndex = 4;
            lblCNIC.Text = "CNIC";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(138, 252);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(255, 34);
            txtPhone.TabIndex = 6;
            txtPhone.Enter += txtPhone_Enter;
            txtPhone.KeyPress += NumbersOnly;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(138, 502);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(255, 34);
            txtAddress.TabIndex = 7;
            // 
            // panelgrid
            // 
            panelgrid.BackColor = Color.White;
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(dgvCustomers);
            panelgrid.Controls.Add(panelTop);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(399, 0);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(863, 812);
            panelgrid.TabIndex = 18;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(841, 156);
            panelTop.TabIndex = 14;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1262, 812);
            Controls.Add(panelgrid);
            Controls.Add(panelleft);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            WindowState = FormWindowState.Maximized;
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panelleft.ResumeLayout(false);
            panelleft.PerformLayout();
            panelgrid.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel panelleft;
        private TextBox txtCNIC;
        private Button btnAdd;
        private Label lblCNIC;
        private Button btnUpdate;
        private TextBox txtAddress;
        private Button btnDelete;
        private Label lblAddress;
        private Button btnClear;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtName;
        private Label lblName;
        private Panel panelgrid;
        private Panel panelTop;
        private Label label1;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}