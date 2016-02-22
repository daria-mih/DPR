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
            this.lbProcess = new System.Windows.Forms.ListBox();
            this.rbFirstCome = new System.Windows.Forms.RadioButton();
            this.rbSeekTime = new System.Windows.Forms.RadioButton();
            this.rbScan = new System.Windows.Forms.RadioButton();
            this.timNextProcess = new System.Windows.Forms.Timer(this.components);
            this.tbRun = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNextProcess = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lbmin = new System.Windows.Forms.Label();
            this.lbmax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRun)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProcess
            // 
            this.lbProcess.FormattingEnabled = true;
            this.lbProcess.Location = new System.Drawing.Point(87, 12);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(79, 264);
            this.lbProcess.TabIndex = 1;
            // 
            // rbFirstCome
            // 
            this.rbFirstCome.AutoSize = true;
            this.rbFirstCome.Checked = true;
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
            // timNextProcess
            // 
            this.timNextProcess.Interval = 15;
            this.timNextProcess.Tick += new System.EventHandler(this.tNextProcess_Tick);
            // 
            // tbRun
            // 
            this.tbRun.LargeChange = 1;
            this.tbRun.Location = new System.Drawing.Point(12, 12);
            this.tbRun.Maximum = 30;
            this.tbRun.Name = "tbRun";
            this.tbRun.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbRun.Size = new System.Drawing.Size(45, 264);
            this.tbRun.TabIndex = 5;
            this.tbRun.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRun.Value = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Next process:";
            // 
            // lblNextProcess
            // 
            this.lblNextProcess.AutoSize = true;
            this.lblNextProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextProcess.Location = new System.Drawing.Point(166, 249);
            this.lblNextProcess.Name = "lblNextProcess";
            this.lblNextProcess.Size = new System.Drawing.Size(0, 31);
            this.lblNextProcess.TabIndex = 7;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(172, 154);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(117, 23);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lbmin
            // 
            this.lbmin.AutoSize = true;
            this.lbmin.Location = new System.Drawing.Point(60, 16);
            this.lbmin.Name = "lbmin";
            this.lbmin.Size = new System.Drawing.Size(0, 13);
            this.lbmin.TabIndex = 9;
            // 
            // lbmax
            // 
            this.lbmax.AutoSize = true;
            this.lbmax.Location = new System.Drawing.Point(60, 260);
            this.lbmax.Name = "lbmax";
            this.lbmax.Size = new System.Drawing.Size(0, 13);
            this.lbmax.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 289);
            this.Controls.Add(this.lbmax);
            this.Controls.Add(this.lbmin);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblNextProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRun);
            this.Controls.Add(this.rbScan);
            this.Controls.Add(this.rbSeekTime);
            this.Controls.Add(this.rbFirstCome);
            this.Controls.Add(this.lbProcess);
            this.Name = "Form1";
            this.Text = "Operating System";
            ((System.ComponentModel.ISupportInitialize)(this.tbRun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbProcess;
        private System.Windows.Forms.RadioButton rbFirstCome;
        private System.Windows.Forms.RadioButton rbSeekTime;
        private System.Windows.Forms.RadioButton rbScan;
        private System.Windows.Forms.Timer timNextProcess;
        private System.Windows.Forms.TrackBar tbRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNextProcess;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lbmin;
        private System.Windows.Forms.Label lbmax;
    }
}

