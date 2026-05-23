namespace SimpleBankingSystem
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvStaff = new DataGridView();
            lblFullName = new Label();
            txtFullName = new TextBox();
            groupBox1 = new GroupBox();
            panelleft = new Panel();
            panel1 = new Panel();
            panelgrid = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            groupBox1.SuspendLayout();
            panelleft.SuspendLayout();
            panel1.SuspendLayout();
            panelgrid.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(179, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Staff Management";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(17, 180);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(23, 258);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(23, 338);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 28);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(193, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 34);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(193, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 34);
            txtUsername.TabIndex = 5;
            txtUsername.KeyPress += UsernameInput;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Teller", "Manager" });
            cmbRole.Location = new Point(193, 338);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 36);
            cmbRole.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(13, 544);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 38);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += ButtonHover;
            btnAdd.MouseLeave += ButtonLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(270, 426);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 38);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += ButtonHover;
            btnUpdate.MouseLeave += ButtonLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(13, 426);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 38);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += ButtonHover;
            btnDelete.MouseLeave += ButtonLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(270, 544);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 38);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += ButtonHover;
            btnClear.MouseLeave += ButtonLeave;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStaff.BackgroundColor = Color.White;
            dgvStaff.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Dock = DockStyle.Fill;
            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.Location = new Point(10, 10);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersVisible = false;
            dgvStaff.RowHeadersWidth = 62;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(815, 669);
            dgvStaff.TabIndex = 11;
            dgvStaff.CellClick += dgvStaff_CellClick;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(23, 107);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 28);
            lblFullName.TabIndex = 12;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(193, 107);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 34);
            txtFullName.TabIndex = 13;
            txtFullName.KeyPress += LettersOnly;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(lblRole);
            groupBox1.Location = new Point(11, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 627);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Information";
            // 
            // panelleft
            // 
            panelleft.Controls.Add(groupBox1);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 0);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(425, 786);
            panelleft.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(425, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 95);
            panel1.TabIndex = 0;
            // 
            // panelgrid
            // 
            panelgrid.BackColor = Color.White;
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(dgvStaff);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(425, 95);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(837, 691);
            panelgrid.TabIndex = 16;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1262, 786);
            Controls.Add(panelgrid);
            Controls.Add(panel1);
            Controls.Add(panelleft);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffForm";
            WindowState = FormWindowState.Maximized;
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelleft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelgrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ComboBox cmbRole;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvStaff;
        private Label lblFullName;
        private TextBox txtFullName;
        private GroupBox groupBox1;
        private Panel panelleft;
        private Panel panel1;
        private Panel panelgrid;
    }
}