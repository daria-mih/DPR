namespace FactoryPattern
{
    partial class FormPhablet
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
            this.lblCalling = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalling
            // 
            this.lblCalling.AutoSize = true;
            this.lblCalling.Location = new System.Drawing.Point(212, 670);
            this.lblCalling.Name = "lblCalling";
            this.lblCalling.Size = new System.Drawing.Size(0, 13);
            this.lblCalling.TabIndex = 5;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(52, 670);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(100, 23);
            this.btnCall.TabIndex = 4;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPhablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 705);
            this.Controls.Add(this.lblCalling);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPhablet";
            this.Text = "FormPhablet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalling;
        private System.Windows.Forms.Button btnCall;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}