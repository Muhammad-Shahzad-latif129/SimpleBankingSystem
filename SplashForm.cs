using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleBankingSystem
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        double fadeSpeed = 0.05;
        int progress = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // FADE IN

            if (this.Opacity < 1)
            {
                this.Opacity += fadeSpeed;
            }

            // PROGRESS BAR

            progress++;

            if (progress <= 100)
            {
                progressBar1.Value = progress;
            }

            // OPEN LOGIN

            if (progress >= 100)
            {
                timer1.Stop();

                LoginForm login =
                    new LoginForm();

                login.Show();

                this.Hide();
            }
        }
    }
}
