namespace ObserverPattern
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
            this.TimerAge = new System.Windows.Forms.Timer(this.components);
            this.btnAddObserver = new System.Windows.Forms.Button();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbHeight = new System.Windows.Forms.RadioButton();
            this.btnBornKill = new System.Windows.Forms.Button();
            this.btnRemoveObserver = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.ListBox();
            this.lbExtension = new System.Windows.Forms.ListBox();
            this.lbValue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TimerAge
            // 
            this.TimerAge.Interval = 1000;
            this.TimerAge.Tick += new System.EventHandler(this.TimerAge_Tick);
            // 
            // btnAddObserver
            // 
            this.btnAddObserver.Location = new System.Drawing.Point(232, 336);
            this.btnAddObserver.Name = "btnAddObserver";
            this.btnAddObserver.Size = new System.Drawing.Size(97, 23);
            this.btnAddObserver.TabIndex = 0;
            this.btnAddObserver.Text = "Add Observer";
            this.btnAddObserver.UseVisualStyleBackColor = true;
            this.btnAddObserver.Click += new System.EventHandler(this.btnAddObserver_Click);
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Checked = true;
            this.rbDay.Location = new System.Drawing.Point(232, 241);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(87, 17);
            this.rbDay.TabIndex = 1;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "DayObserver";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(232, 264);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(98, 17);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.Text = "MonthObserver";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(232, 287);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(90, 17);
            this.rbYear.TabIndex = 3;
            this.rbYear.Text = "YearObserver";
            this.rbYear.UseVisualStyleBackColor = true;
            this.rbYear.CheckedChanged += new System.EventHandler(this.rbYear_CheckedChanged);
            // 
            // rbHeight
            // 
            this.rbHeight.AutoSize = true;
            this.rbHeight.Location = new System.Drawing.Point(232, 310);
            this.rbHeight.Name = "rbHeight";
            this.rbHeight.Size = new System.Drawing.Size(99, 17);
            this.rbHeight.TabIndex = 4;
            this.rbHeight.Text = "HeightObserver";
            this.rbHeight.UseVisualStyleBackColor = true;
            this.rbHeight.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
            // 
            // btnBornKill
            // 
            this.btnBornKill.Location = new System.Drawing.Point(232, 12);
            this.btnBornKill.Name = "btnBornKill";
            this.btnBornKill.Size = new System.Drawing.Size(92, 26);
            this.btnBornKill.TabIndex = 6;
            this.btnBornKill.Text = "Create person";
            this.btnBornKill.UseVisualStyleBackColor = true;
            this.btnBornKill.Click += new System.EventHandler(this.btnBornKill_Click);
            // 
            // btnRemoveObserver
            // 
            this.btnRemoveObserver.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveObserver.Name = "btnRemoveObserver";
            this.btnRemoveObserver.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveObserver.TabIndex = 11;
            // 
            // lbType
            // 
            this.lbType.FormattingEnabled = true;
            this.lbType.Location = new System.Drawing.Point(0, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(87, 368);
            this.lbType.TabIndex = 8;
            this.lbType.SelectedIndexChanged += new System.EventHandler(this.lbType_SelectedIndexChanged);
            // 
            // lbExtension
            // 
            this.lbExtension.FormattingEnabled = true;
            this.lbExtension.Location = new System.Drawing.Point(139, 0);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Size = new System.Drawing.Size(87, 368);
            this.lbExtension.TabIndex = 9;
            this.lbExtension.SelectedIndexChanged += new System.EventHandler(this.lbExtension_SelectedIndexChanged);
            // 
            // lbValue
            // 
            this.lbValue.FormattingEnabled = true;
            this.lbValue.Location = new System.Drawing.Point(93, 1);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(40, 368);
            this.lbValue.TabIndex = 10;
            this.lbValue.SelectedIndexChanged += new System.EventHandler(this.lbValue_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 370);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.lbExtension);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.btnRemoveObserver);
            this.Controls.Add(this.btnBornKill);
            this.Controls.Add(this.rbHeight);
            this.Controls.Add(this.rbYear);
            this.Controls.Add(this.rbMonth);
            this.Controls.Add(this.rbDay);
            this.Controls.Add(this.btnAddObserver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerAge;
        private System.Windows.Forms.Button btnAddObserver;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbHeight;
        private System.Windows.Forms.Button btnBornKill;
        private System.Windows.Forms.Button btnRemoveObserver;
        private System.Windows.Forms.ListBox lbType;
        private System.Windows.Forms.ListBox lbExtension;
        private System.Windows.Forms.ListBox lbValue;
    }
}

