using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinShield_Antivirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scan_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            
        }

        private void Progress_Indicator_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
                
                //lst.Add("C:\\Windows\\System32\\shell32.dll\n");
                /*
                foreach (string pl in lst)
                {
                    //listView1.Items.Add(pl);
                    listView1.Items.Add(new ListViewItem(new string[] { "HI"}));

                }
                */
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            listView1.View = View.Details;
            listView1.Columns.Add("Files:");
        }
    }
}
