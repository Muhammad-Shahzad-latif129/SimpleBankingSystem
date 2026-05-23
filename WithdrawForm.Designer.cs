namespace SimpleBankingSystem
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            lblTitle = new Label();
            lblAccount = new Label();
            lblAmount = new Label();
            cmbAccount = new ComboBox();
            txtAmount = new TextBox();
            btnWithdraw = new Button();
            dgvWithdraw = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearchAccount = new TextBox();
            lblSearch = new Label();
            panel1 = new Panel();
            panelgrid = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvWithdraw).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panelgrid.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(298, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Withdraw Money";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(7, 192);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(84, 28);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "Account";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(7, 284);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 28);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(96, 192);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(258, 36);
            cmbAccount.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(96, 284);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(165, 34);
            txtAmount.TabIndex = 4;
            txtAmount.KeyPress += DecimalOnly;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.SteelBlue;
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Location = new Point(186, 392);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(123, 38);
            btnWithdraw.TabIndex = 5;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            btnWithdraw.MouseEnter += ButtonHover;
            btnWithdraw.MouseLeave += ButtonLeave;
            // 
            // dgvWithdraw
            // 
            dgvWithdraw.AllowUserToAddRows = false;
            dgvWithdraw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWithdraw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvWithdraw.BackgroundColor = Color.White;
            dgvWithdraw.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWithdraw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWithdraw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWithdraw.Dock = DockStyle.Fill;
            dgvWithdraw.EnableHeadersVisualStyles = false;
            dgvWithdraw.Location = new Point(10, 88);
            dgvWithdraw.MultiSelect = false;
            dgvWithdraw.Name = "dgvWithdraw";
            dgvWithdraw.ReadOnly = true;
            dgvWithdraw.RowHeadersVisible = false;
            dgvWithdraw.RowHeadersWidth = 62;
            dgvWithdraw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWithdraw.Size = new Size(1012, 697);
            dgvWithdraw.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchAccount);
            groupBox1.Controls.Add(lblSearch);
            groupBox1.Controls.Add(btnWithdraw);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(cmbAccount);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(lblAccount);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 530);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.BorderStyle = BorderStyle.FixedSingle;
            txtSearchAccount.Location = new Point(186, 121);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(165, 34);
            txtSearchAccount.TabIndex = 7;
            txtSearchAccount.TextChanged += txtSearchAccount_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(6, 121);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(147, 28);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Search Account";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 797);
            panel1.TabIndex = 8;
            // 
            // panelgrid
            // 
            panelgrid.BackColor = Color.White;
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(dgvWithdraw);
            panelgrid.Controls.Add(panel2);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(399, 0);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(1034, 797);
            panelgrid.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 78);
            panel2.TabIndex = 0;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1433, 797);
            Controls.Add(panelgrid);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WithdrawForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WithdrawForm";
            WindowState = FormWindowState.Maximized;
            Load += WithdrawForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWithdraw).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panelgrid.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblAccount;
        private Label lblAmount;
        private ComboBox cmbAccount;
        private TextBox txtAmount;
        private Button btnWithdraw;
        private DataGridView dgvWithdraw;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panelgrid;
        private Panel panel2;
        private TextBox txtSearchAccount;
        private Label lblSearch;
    }
}