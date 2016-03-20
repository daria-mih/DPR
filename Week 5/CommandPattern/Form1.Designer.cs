namespace CommandPattern
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlace = new System.Windows.Forms.Button();
            this.nudAppetizer = new System.Windows.Forms.NumericUpDown();
            this.nudMain = new System.Windows.Forms.NumericUpDown();
            this.nudDessert = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppetizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDessert)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudDessert);
            this.groupBox1.Controls.Add(this.nudMain);
            this.groupBox1.Controls.Add(this.nudAppetizer);
            this.groupBox1.Controls.Add(this.btnPlace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appetizer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main dish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dessert";
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(42, 192);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(173, 39);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // nudAppetizer
            // 
            this.nudAppetizer.Location = new System.Drawing.Point(125, 50);
            this.nudAppetizer.Name = "nudAppetizer";
            this.nudAppetizer.Size = new System.Drawing.Size(120, 26);
            this.nudAppetizer.TabIndex = 4;
            // 
            // nudMain
            // 
            this.nudMain.Location = new System.Drawing.Point(125, 94);
            this.nudMain.Name = "nudMain";
            this.nudMain.Size = new System.Drawing.Size(120, 26);
            this.nudMain.TabIndex = 5;
            // 
            // nudDessert
            // 
            this.nudDessert.Location = new System.Drawing.Point(125, 134);
            this.nudDessert.Name = "nudDessert";
            this.nudDessert.Size = new System.Drawing.Size(120, 26);
            this.nudDessert.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Waiter\'s Pad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppetizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDessert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDessert;
        private System.Windows.Forms.NumericUpDown nudMain;
        private System.Windows.Forms.NumericUpDown nudAppetizer;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

