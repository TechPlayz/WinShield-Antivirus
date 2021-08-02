
namespace WinShield_Antivirus
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ScanProgressBar = new System.Windows.Forms.ProgressBar();
            this.scan = new System.Windows.Forms.Button();
            this.Progress_Indicator = new System.Windows.Forms.Label();
            this.ScanProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.Patience = new System.Windows.Forms.Label();
            this.shield_win_pic = new System.Windows.Forms.PictureBox();
            this.Dark_Theme = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.Hyped_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shield_win_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hyped_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanProgressBar
            // 
            this.ScanProgressBar.Location = new System.Drawing.Point(212, 120);
            this.ScanProgressBar.Maximum = 1000;
            this.ScanProgressBar.Name = "ScanProgressBar";
            this.ScanProgressBar.Size = new System.Drawing.Size(576, 23);
            this.ScanProgressBar.TabIndex = 0;
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(465, 149);
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
            this.Progress_Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Progress_Indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress_Indicator.ForeColor = System.Drawing.Color.Tomato;
            this.Progress_Indicator.Location = new System.Drawing.Point(209, 80);
            this.Progress_Indicator.Name = "Progress_Indicator";
            this.Progress_Indicator.Size = new System.Drawing.Size(60, 13);
            this.Progress_Indicator.TabIndex = 2;
            this.Progress_Indicator.Text = "Progress:";
            this.Progress_Indicator.Click += new System.EventHandler(this.Progress_Indicator_Click);
            // 
            // ScanProgressTimer
            // 
            this.ScanProgressTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Patience
            // 
            this.Patience.AutoSize = true;
            this.Patience.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Patience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patience.ForeColor = System.Drawing.Color.Crimson;
            this.Patience.Location = new System.Drawing.Point(335, 223);
            this.Patience.Name = "Patience";
            this.Patience.Size = new System.Drawing.Size(363, 25);
            this.Patience.TabIndex = 4;
            this.Patience.Text = "Please be patient until scan ends";
            // 
            // shield_win_pic
            // 
            this.shield_win_pic.BackColor = System.Drawing.Color.Transparent;
            this.shield_win_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shield_win_pic.Image = ((System.Drawing.Image)(resources.GetObject("shield_win_pic.Image")));
            this.shield_win_pic.Location = new System.Drawing.Point(12, 11);
            this.shield_win_pic.Name = "shield_win_pic";
            this.shield_win_pic.Size = new System.Drawing.Size(31, 27);
            this.shield_win_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shield_win_pic.TabIndex = 8;
            this.shield_win_pic.TabStop = false;
            // 
            // Dark_Theme
            // 
            this.Dark_Theme.AutoSize = true;
            this.Dark_Theme.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dark_Theme.ForeColor = System.Drawing.Color.DarkRed;
            this.Dark_Theme.Location = new System.Drawing.Point(694, 11);
            this.Dark_Theme.Name = "Dark_Theme";
            this.Dark_Theme.Size = new System.Drawing.Size(94, 20);
            this.Dark_Theme.TabIndex = 9;
            this.Dark_Theme.Text = "Dark Theme";
            this.Dark_Theme.UseVisualStyleBackColor = true;
            this.Dark_Theme.CheckedChanged += new System.EventHandler(this.Dark_Theme_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(49, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(197, 12);
            this.Title.TabIndex = 10;
            this.Title.Text = "WinShield Antivirus";
            // 
            // Hyped_Pic
            // 
            this.Hyped_Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hyped_Pic.BackgroundImage")));
            this.Hyped_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hyped_Pic.Location = new System.Drawing.Point(3, 58);
            this.Hyped_Pic.Name = "Hyped_Pic";
            this.Hyped_Pic.Size = new System.Drawing.Size(200, 380);
            this.Hyped_Pic.TabIndex = 11;
            this.Hyped_Pic.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hyped_Pic);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Dark_Theme);
            this.Controls.Add(this.shield_win_pic);
            this.Controls.Add(this.Patience);
            this.Controls.Add(this.Progress_Indicator);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.ScanProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "WinShield Antivirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shield_win_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hyped_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ScanProgressBar;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Label Progress_Indicator;
        private System.Windows.Forms.Timer ScanProgressTimer;
        private System.Windows.Forms.Label Patience;
        private System.Windows.Forms.PictureBox shield_win_pic;
        private System.Windows.Forms.CheckBox Dark_Theme;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Hyped_Pic;
    }
}

