namespace SimpleBankingSystem
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            picturelogo = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblVersion = new Label();
            lblDeveloper = new Label();
            ((System.ComponentModel.ISupportInitialize)picturelogo).BeginInit();
            SuspendLayout();
            // 
            // picturelogo
            // 
            picturelogo.BackColor = Color.Transparent;
            picturelogo.Image = (Image)resources.GetObject("picturelogo.Image");
            picturelogo.Location = new Point(245, 40);
            picturelogo.Name = "picturelogo";
            picturelogo.Size = new Size(113, 84);
            picturelogo.SizeMode = PictureBoxSizeMode.Zoom;
            picturelogo.TabIndex = 7;
            picturelogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(12, 130);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(574, 60);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "SIMPLE BANKING SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 190);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 9;
            label1.Text = "Loading...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(150, 230);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 20);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.ForeColor = Color.Gray;
            lblVersion.Location = new Point(20, 315);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(99, 25);
            lblVersion.TabIndex = 11;
            lblVersion.Text = "Versoin 1.0";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.ForeColor = Color.Gray;
            lblDeveloper.Location = new Point(298, 318);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(300, 25);
            lblDeveloper.TabIndex = 12;
            lblDeveloper.Text = "Developed By: Muhammad Shahzad";
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 350);
            Controls.Add(lblDeveloper);
            Controls.Add(lblVersion);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(picturelogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashForm";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)picturelogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturelogo;
        private Label lblTitle;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lblVersion;
        private Label lblDeveloper;
    }
}