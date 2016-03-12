namespace DecoratorPattern
{
    partial class StartForm
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
            this.btnArduino = new System.Windows.Forms.Button();
            this.btnBreadboard = new System.Windows.Forms.Button();
            this.btnArduinoDuo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArduino
            // 
            this.btnArduino.Location = new System.Drawing.Point(59, 23);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(120, 23);
            this.btnArduino.TabIndex = 0;
            this.btnArduino.Text = "Decorate ArduinoUno";
            this.btnArduino.UseVisualStyleBackColor = true;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // btnBreadboard
            // 
            this.btnBreadboard.Location = new System.Drawing.Point(59, 81);
            this.btnBreadboard.Name = "btnBreadboard";
            this.btnBreadboard.Size = new System.Drawing.Size(120, 23);
            this.btnBreadboard.TabIndex = 1;
            this.btnBreadboard.Text = "Decorate Breadboard";
            this.btnBreadboard.UseVisualStyleBackColor = true;
            this.btnBreadboard.Click += new System.EventHandler(this.btnBreadboard_Click);
            // 
            // btnArduinoDuo
            // 
            this.btnArduinoDuo.Location = new System.Drawing.Point(59, 52);
            this.btnArduinoDuo.Name = "btnArduinoDuo";
            this.btnArduinoDuo.Size = new System.Drawing.Size(120, 23);
            this.btnArduinoDuo.TabIndex = 2;
            this.btnArduinoDuo.Text = "Decorate ArduinoDuo";
            this.btnArduinoDuo.UseVisualStyleBackColor = true;
            this.btnArduinoDuo.Click += new System.EventHandler(this.btnArduinoDuo_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 127);
            this.Controls.Add(this.btnArduinoDuo);
            this.Controls.Add(this.btnBreadboard);
            this.Controls.Add(this.btnArduino);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.Text = "Start a decorator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Button btnBreadboard;
        private System.Windows.Forms.Button btnArduinoDuo;
    }
}