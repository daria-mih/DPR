namespace DecoratorPattern2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLens = new System.Windows.Forms.NumericUpDown();
            this.nudExtender = new System.Windows.Forms.NumericUpDown();
            this.nudFilter = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbphoto = new System.Windows.Forms.RadioButton();
            this.rbvideo = new System.Windows.Forms.RadioButton();
            this.lbprice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbprice);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nudLens);
            this.groupBox3.Controls.Add(this.nudExtender);
            this.groupBox3.Controls.Add(this.nudFilter);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 175);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose extras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lens          599 € ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter          23.50 €";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Extender   429 €    ";
            // 
            // nudLens
            // 
            this.nudLens.Location = new System.Drawing.Point(189, 42);
            this.nudLens.Name = "nudLens";
            this.nudLens.Size = new System.Drawing.Size(120, 30);
            this.nudLens.TabIndex = 4;
            // 
            // nudExtender
            // 
            this.nudExtender.Location = new System.Drawing.Point(189, 135);
            this.nudExtender.Name = "nudExtender";
            this.nudExtender.Size = new System.Drawing.Size(120, 30);
            this.nudExtender.TabIndex = 9;
            // 
            // nudFilter
            // 
            this.nudFilter.Location = new System.Drawing.Point(189, 91);
            this.nudFilter.Name = "nudFilter";
            this.nudFilter.Size = new System.Drawing.Size(120, 30);
            this.nudFilter.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.rbphoto);
            this.groupBox2.Controls.Add(this.rbvideo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose camera type:";
            // 
            // rbphoto
            // 
            this.rbphoto.AutoSize = true;
            this.rbphoto.Checked = true;
            this.rbphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbphoto.Location = new System.Drawing.Point(7, 25);
            this.rbphoto.Name = "rbphoto";
            this.rbphoto.Size = new System.Drawing.Size(288, 29);
            this.rbphoto.TabIndex = 1;
            this.rbphoto.TabStop = true;
            this.rbphoto.Text = "Photo camera (body)   1200 €";
            this.rbphoto.UseVisualStyleBackColor = true;
            this.rbphoto.CheckedChanged += new System.EventHandler(this.rbphoto_CheckedChanged);
            // 
            // rbvideo
            // 
            this.rbvideo.AutoSize = true;
            this.rbvideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvideo.Location = new System.Drawing.Point(7, 77);
            this.rbvideo.Name = "rbvideo";
            this.rbvideo.Size = new System.Drawing.Size(288, 29);
            this.rbvideo.TabIndex = 2;
            this.rbvideo.TabStop = true;
            this.rbvideo.Text = "Video camera (body)   1700 €";
            this.rbvideo.UseVisualStyleBackColor = true;
            this.rbvideo.CheckedChanged += new System.EventHandler(this.rbvideo_CheckedChanged);
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(229, 393);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(0, 25);
            this.lbprice.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(11, 384);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 43);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 469);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Camera shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudExtender;
        private System.Windows.Forms.NumericUpDown nudFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLens;
        private System.Windows.Forms.RadioButton rbvideo;
        private System.Windows.Forms.RadioButton rbphoto;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

