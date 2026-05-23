namespace SimpleBankingSystem
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            lblTitle = new Label();
            lblAccount = new Label();
            lblType = new Label();
            lblAmount = new Label();
            lblBalance = new Label();
            lblDate = new Label();
            lblAccountValue = new Label();
            lblTypeValue = new Label();
            lblAmountValue = new Label();
            lblBalanceValue = new Label();
            lblDateValue = new Label();
            btnDownload = new Button();
            panelTop = new Panel();
            btnClose = new Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(352, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "BANK RECEIPT";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.Location = new Point(93, 135);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(98, 30);
            lblAccount.TabIndex = 2;
            lblAccount.Text = "Account";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblType.Location = new Point(93, 213);
            lblType.Name = "lblType";
            lblType.Size = new Size(63, 30);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAmount.Location = new Point(93, 287);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(96, 30);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBalance.Location = new Point(93, 360);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(93, 30);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Balance";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDate.Location = new Point(93, 443);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(62, 30);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date";
            // 
            // lblAccountValue
            // 
            lblAccountValue.AutoSize = true;
            lblAccountValue.Font = new Font("Segoe UI", 11F);
            lblAccountValue.Location = new Point(278, 135);
            lblAccountValue.Name = "lblAccountValue";
            lblAccountValue.Size = new Size(71, 30);
            lblAccountValue.TabIndex = 7;
            lblAccountValue.Text = "label1";
            // 
            // lblTypeValue
            // 
            lblTypeValue.AutoSize = true;
            lblTypeValue.Font = new Font("Segoe UI", 11F);
            lblTypeValue.Location = new Point(278, 213);
            lblTypeValue.Name = "lblTypeValue";
            lblTypeValue.Size = new Size(71, 30);
            lblTypeValue.TabIndex = 8;
            lblTypeValue.Text = "label2";
            // 
            // lblAmountValue
            // 
            lblAmountValue.AutoSize = true;
            lblAmountValue.Font = new Font("Segoe UI", 11F);
            lblAmountValue.Location = new Point(278, 287);
            lblAmountValue.Name = "lblAmountValue";
            lblAmountValue.Size = new Size(71, 30);
            lblAmountValue.TabIndex = 9;
            lblAmountValue.Text = "label3";
            // 
            // lblBalanceValue
            // 
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Font = new Font("Segoe UI", 11F);
            lblBalanceValue.Location = new Point(278, 360);
            lblBalanceValue.Name = "lblBalanceValue";
            lblBalanceValue.Size = new Size(71, 30);
            lblBalanceValue.TabIndex = 10;
            lblBalanceValue.Text = "label4";
            // 
            // lblDateValue
            // 
            lblDateValue.AutoSize = true;
            lblDateValue.Font = new Font("Segoe UI", 11F);
            lblDateValue.Location = new Point(278, 443);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(71, 30);
            lblDateValue.TabIndex = 11;
            lblDateValue.Text = "label5";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.SteelBlue;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(93, 535);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(186, 45);
            btnDownload.TabIndex = 12;
            btnDownload.Text = "Download PDF";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            btnDownload.MouseEnter += ButtonHover;
            btnDownload.MouseLeave += ButtonLeave;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SteelBlue;
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1007, 70);
            panelTop.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(760, 535);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(186, 45);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1007, 619);
            Controls.Add(btnClose);
            Controls.Add(panelTop);
            Controls.Add(btnDownload);
            Controls.Add(lblDateValue);
            Controls.Add(lblBalanceValue);
            Controls.Add(lblAmountValue);
            Controls.Add(lblTypeValue);
            Controls.Add(lblAccountValue);
            Controls.Add(lblDate);
            Controls.Add(lblBalance);
            Controls.Add(lblAmount);
            Controls.Add(lblType);
            Controls.Add(lblAccount);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReceiptForm";
            Load += ReceiptForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAccount;
        private Label lblType;
        private Label lblAmount;
        private Label lblBalance;
        private Label lblDate;
        private Label lblAccountValue;
        private Label lblTypeValue;
        private Label lblAmountValue;
        private Label lblBalanceValue;
        private Label lblDateValue;
        private Button btnDownload;
        private Panel panelTop;
        private Button btnClose;
    }
}