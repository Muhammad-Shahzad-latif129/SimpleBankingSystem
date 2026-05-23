namespace SimpleBankingSystem
{
    partial class StatementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementForm));
            lblTitle = new Label();
            lblAccount = new Label();
            cmbAccount = new ComboBox();
            btnShow = new Button();
            dgvStatement = new DataGridView();
            panel1 = new Panel();
            btnDownload = new Button();
            label1 = new Label();
            panelgrid = new Panel();
            panelTop = new Panel();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStatement).BeginInit();
            panel1.SuspendLayout();
            panelgrid.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(262, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mini Statement";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(12, 197);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(161, 28);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "Account Number";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(201, 197);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(221, 36);
            cmbAccount.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.SteelBlue;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.ForeColor = Color.White;
            btnShow.Location = new Point(222, 306);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(200, 39);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show Statement\r\n";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            btnShow.MouseEnter += ButtonHover;
            btnShow.MouseLeave += ButtonLeave;
            // 
            // dgvStatement
            // 
            dgvStatement.AllowUserToAddRows = false;
            dgvStatement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStatement.BackgroundColor = Color.White;
            dgvStatement.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStatement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStatement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatement.Dock = DockStyle.Fill;
            dgvStatement.EnableHeadersVisualStyles = false;
            dgvStatement.Location = new Point(10, 140);
            dgvStatement.MultiSelect = false;
            dgvStatement.Name = "dgvStatement";
            dgvStatement.ReadOnly = true;
            dgvStatement.RowHeadersVisible = false;
            dgvStatement.RowHeadersWidth = 62;
            dgvStatement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatement.Size = new Size(798, 471);
            dgvStatement.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDownload);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(lblAccount);
            panel1.Controls.Add(cmbAccount);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 623);
            panel1.TabIndex = 6;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.SteelBlue;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(222, 400);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(200, 39);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "Download PDF";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(90, 20);
            label1.Name = "label1";
            label1.Size = new Size(159, 48);
            label1.TabIndex = 4;
            label1.Text = "Account";
            // 
            // panelgrid
            // 
            panelgrid.BackColor = Color.White;
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(dgvStatement);
            panelgrid.Controls.Add(panelTop);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(438, 0);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(820, 623);
            panelgrid.TabIndex = 7;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cmbFilter);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(798, 130);
            panelTop.TabIndex = 5;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Deposit", "Withdraw", "Transfer" });
            cmbFilter.Location = new Point(601, 78);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(182, 36);
            cmbFilter.TabIndex = 3;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(199, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(151, 28);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Account:";
            // 
            // StatementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1258, 623);
            Controls.Add(panelgrid);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatementForm";
            WindowState = FormWindowState.Maximized;
            Load += StatementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStatement).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelgrid.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblAccount;
        private ComboBox cmbAccount;
        private Button btnShow;
        private DataGridView dgvStatement;
        private Panel panel1;
        private Panel panelgrid;
        private Panel panelTop;
        private Label label1;
        private Button btnDownload;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cmbFilter;
    }
}