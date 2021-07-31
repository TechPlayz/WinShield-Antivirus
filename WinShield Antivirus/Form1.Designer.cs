
namespace WinShield_Antivirus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.scan = new System.Windows.Forms.Button();
            this.Progress_Indicator = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Patience = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.scanned_file_heading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 34);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(798, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(324, 105);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(128, 23);
            this.scan.TabIndex = 1;
            this.scan.Text = "Scan for viruses";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // Progress_Indicator
            // 
            this.Progress_Indicator.AutoSize = true;
            this.Progress_Indicator.ForeColor = System.Drawing.Color.DarkBlue;
            this.Progress_Indicator.Location = new System.Drawing.Point(13, 15);
            this.Progress_Indicator.Name = "Progress_Indicator";
            this.Progress_Indicator.Size = new System.Drawing.Size(51, 13);
            this.Progress_Indicator.TabIndex = 2;
            this.Progress_Indicator.Text = "Progress:";
            this.Progress_Indicator.Click += new System.EventHandler(this.Progress_Indicator_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Patience
            // 
            this.Patience.AutoSize = true;
            this.Patience.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Patience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patience.ForeColor = System.Drawing.Color.Crimson;
            this.Patience.Location = new System.Drawing.Point(221, 158);
            this.Patience.Name = "Patience";
            this.Patience.Size = new System.Drawing.Size(363, 25);
            this.Patience.TabIndex = 4;
            this.Patience.Text = "Please be patient until scan ends";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 140);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // scanned_file_heading
            // 
            this.scanned_file_heading.AutoSize = true;
            this.scanned_file_heading.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanned_file_heading.Location = new System.Drawing.Point(12, 79);
            this.scanned_file_heading.Name = "scanned_file_heading";
            this.scanned_file_heading.Size = new System.Drawing.Size(112, 23);
            this.scanned_file_heading.TabIndex = 6;
            this.scanned_file_heading.Text = "Scanned Files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scanned_file_heading);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Patience);
            this.Controls.Add(this.Progress_Indicator);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "WinShield Antivirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Label Progress_Indicator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Patience;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label scanned_file_heading;
    }
}

