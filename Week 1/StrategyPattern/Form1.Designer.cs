namespace StrategyPattern
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
            this.lbThreads = new System.Windows.Forms.ListBox();
            this.rbFirstCome = new System.Windows.Forms.RadioButton();
            this.rbSeekTime = new System.Windows.Forms.RadioButton();
            this.rbScan = new System.Windows.Forms.RadioButton();
            this.tNextProcess = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThreads
            // 
            this.lbThreads.FormattingEnabled = true;
            this.lbThreads.Location = new System.Drawing.Point(87, 12);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(79, 264);
            this.lbThreads.TabIndex = 1;
            this.lbThreads.SelectedIndexChanged += new System.EventHandler(this.lbThreads_SelectedIndexChanged);
            // 
            // rbFirstCome
            // 
            this.rbFirstCome.AutoSize = true;
            this.rbFirstCome.Location = new System.Drawing.Point(172, 12);
            this.rbFirstCome.Name = "rbFirstCome";
            this.rbFirstCome.Size = new System.Drawing.Size(127, 17);
            this.rbFirstCome.TabIndex = 2;
            this.rbFirstCome.TabStop = true;
            this.rbFirstCome.Text = "First Come First Serve";
            this.rbFirstCome.UseVisualStyleBackColor = true;
            this.rbFirstCome.CheckedChanged += new System.EventHandler(this.rbFirstCome_CheckedChanged);
            // 
            // rbSeekTime
            // 
            this.rbSeekTime.AutoSize = true;
            this.rbSeekTime.Location = new System.Drawing.Point(172, 53);
            this.rbSeekTime.Name = "rbSeekTime";
            this.rbSeekTime.Size = new System.Drawing.Size(128, 17);
            this.rbSeekTime.TabIndex = 3;
            this.rbSeekTime.TabStop = true;
            this.rbSeekTime.Text = "Shortest seektime first";
            this.rbSeekTime.UseVisualStyleBackColor = true;
            this.rbSeekTime.CheckedChanged += new System.EventHandler(this.rbSeekTime_CheckedChanged);
            // 
            // rbScan
            // 
            this.rbScan.AutoSize = true;
            this.rbScan.Location = new System.Drawing.Point(172, 94);
            this.rbScan.Name = "rbScan";
            this.rbScan.Size = new System.Drawing.Size(101, 17);
            this.rbScan.TabIndex = 4;
            this.rbScan.TabStop = true;
            this.rbScan.Text = "SCAN (elevator)";
            this.rbScan.UseVisualStyleBackColor = true;
            this.rbScan.CheckedChanged += new System.EventHandler(this.rbScan_CheckedChanged);
            // 
            // tNextProcess
            // 
            this.tNextProcess.Interval = 500;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 264);
            this.trackBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 289);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.rbScan);
            this.Controls.Add(this.rbSeekTime);
            this.Controls.Add(this.rbFirstCome);
            this.Controls.Add(this.lbThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbThreads;
        private System.Windows.Forms.RadioButton rbFirstCome;
        private System.Windows.Forms.RadioButton rbSeekTime;
        private System.Windows.Forms.RadioButton rbScan;
        private System.Windows.Forms.Timer tNextProcess;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

