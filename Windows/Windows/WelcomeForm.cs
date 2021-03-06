﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using installer;
using installer.Properties;
using Newtonsoft.Json.Linq;
using Environment = System.Environment;

namespace Windows
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fix the icon for the form in the taskbar.
            this.Icon = Resources.DefaultIcon;

            // Disable next movement
            NextButton.Enabled = false;

            // Change status text to gathering data
            StatusLabel.Text = Resources.welcome_gathering_information;

            // Change status text to ready
            StatusLabel.Text = Resources.welcome_next_text;

            // Enable the button
            NextButton.Enabled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Program.HarshExit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            new InstallerOptionForm().Show();
            this.Close();
        }
    }
}