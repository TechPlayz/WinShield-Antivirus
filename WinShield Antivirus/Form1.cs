using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace WinShield_Antivirus
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void scan_Click(object sender, EventArgs e)
        {
            ScanProgressTimer.Enabled = true;
            ScanProgressTimer.Start();
            ScanProgressTimer.Interval = 1000;
            ScanProgressBar.Maximum = 100;
            ScanProgressTimer.Tick += new EventHandler(timer1_Tick);

        }

        private void Progress_Indicator_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ScanProgressBar.Value != 100)
            {
                ScanProgressBar.Value++;

            }
            else
            {
                ScanProgressTimer.Stop();
                MessageBox.Show("Virus Detected", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnExitProgram_Click(object sender, EventArgs e)
        /*
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var closing = MessageBox.Show("Are you sure that you want to close the antivirus?", "Vulnerability alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (closing == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
        */

        private void Dark_Theme_CheckedChanged(object sender, EventArgs e)
        {
            if(Dark_Theme.Checked)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }   
    }
}
