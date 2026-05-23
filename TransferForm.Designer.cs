namespace SimpleBankingSystem
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            lblTitle = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            lblAmount = new Label();
            cmbFrom = new ComboBox();
            cmbTo = new ComboBox();
            txtAmount = new TextBox();
            btnTransfer = new Button();
            dgvTransfer = new DataGridView();
            groupBox1 = new GroupBox();
            txtFromSearch = new TextBox();
            txtToSearch = new TextBox();
            panel1 = new Panel();
            panelgrid = new Panel();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            groupBox1.SuspendLayout();
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
            lblTitle.Location = new Point(271, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fund Transfer";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(6, 141);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(135, 28);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From Account";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(6, 317);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(109, 28);
            lblTo.TabIndex = 2;
            lblTo.Text = "To Account";
            lblTo.Click += lblTo_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(6, 472);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 28);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            // 
            // cmbFrom
            // 
            cmbFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbFrom.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(6, 248);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(250, 36);
            cmbFrom.TabIndex = 4;
            // 
            // cmbTo
            // 
            cmbTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(6, 403);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(250, 36);
            cmbTo.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(139, 472);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(165, 34);
            txtAmount.TabIndex = 6;
            txtAmount.KeyPress += DecimalOnly;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.SteelBlue;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(239, 559);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(150, 45);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            btnTransfer.MouseEnter += ButtonHover;
            btnTransfer.MouseLeave += ButtonLeave;
            // 
            // dgvTransfer
            // 
            dgvTransfer.AllowUserToAddRows = false;
            dgvTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransfer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransfer.BackgroundColor = Color.White;
            dgvTransfer.BorderStyle = BorderStyle.None;
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Dock = DockStyle.Fill;
            dgvTransfer.EnableHeadersVisualStyles = false;
            dgvTransfer.Location = new Point(10, 85);
            dgvTransfer.MultiSelect = false;
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransfer.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransfer.RowHeadersVisible = false;
            dgvTransfer.RowHeadersWidth = 62;
            dgvTransfer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransfer.Size = new Size(1026, 653);
            dgvTransfer.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFromSearch);
            groupBox1.Controls.Add(txtToSearch);
            groupBox1.Controls.Add(lblFrom);
            groupBox1.Controls.Add(cmbFrom);
            groupBox1.Controls.Add(btnTransfer);
            groupBox1.Controls.Add(lblTo);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(cmbTo);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 633);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Information";
            // 
            // txtFromSearch
            // 
            txtFromSearch.BorderStyle = BorderStyle.FixedSingle;
            txtFromSearch.Location = new Point(6, 188);
            txtFromSearch.Name = "txtFromSearch";
            txtFromSearch.Size = new Size(165, 34);
            txtFromSearch.TabIndex = 9;
            txtFromSearch.TextChanged += txtFromSearch_TextChanged;
            // 
            // txtToSearch
            // 
            txtToSearch.BorderStyle = BorderStyle.FixedSingle;
            txtToSearch.Location = new Point(6, 363);
            txtToSearch.Name = "txtToSearch";
            txtToSearch.Size = new Size(165, 34);
            txtToSearch.TabIndex = 8;
            txtToSearch.TextChanged += txtToSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 750);
            panel1.TabIndex = 10;
            // 
            // panelgrid
            // 
            panelgrid.BorderStyle = BorderStyle.FixedSingle;
            panelgrid.Controls.Add(dgvTransfer);
            panelgrid.Controls.Add(panelTop);
            panelgrid.Dock = DockStyle.Fill;
            panelgrid.Location = new Point(423, 0);
            panelgrid.Name = "panelgrid";
            panelgrid.Padding = new Padding(10);
            panelgrid.Size = new Size(1048, 750);
            panelgrid.TabIndex = 11;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1026, 75);
            panelTop.TabIndex = 0;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1471, 750);
            Controls.Add(panelgrid);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "TransferForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransferForm";
            WindowState = FormWindowState.Maximized;
            Load += TransferForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panelgrid.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblFrom;
        private Label lblTo;
        private Label lblAmount;
        private ComboBox cmbFrom;
        private ComboBox cmbTo;
        private TextBox txtAmount;
        private Button btnTransfer;
        private DataGridView dgvTransfer;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panelgrid;
        private Panel panelTop;
        private TextBox txtFromSearch;
        private TextBox txtToSearch;
    }
}