namespace CommandPattern
{
    partial class RemoteConsole
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
            this.btnTV = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTV
            // 
            this.btnTV.Location = new System.Drawing.Point(12, 12);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(200, 32);
            this.btnTV.TabIndex = 0;
            this.btnTV.Text = "Create TV/Remote";
            this.btnTV.UseVisualStyleBackColor = true;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(12, 62);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(200, 32);
            this.btnRadio.TabIndex = 1;
            this.btnRadio.Text = "Create Radio/Remote";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // RemoteConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 132);
            this.Controls.Add(this.btnRadio);
            this.Controls.Add(this.btnTV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoteConsole";
            this.Text = "DeviceConsole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btnRadio;

    }
}

