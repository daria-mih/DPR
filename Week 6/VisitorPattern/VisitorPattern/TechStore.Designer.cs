namespace VisitorPattern
{
    partial class TechStore
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
            this.nudLaptop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCamera = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPhone = new System.Windows.Forms.NumericUpDown();
            this.Products = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbStore = new System.Windows.Forms.RadioButton();
            this.rbWebshop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhone)).BeginInit();
            this.Products.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudLaptop
            // 
            this.nudLaptop.Location = new System.Drawing.Point(63, 36);
            this.nudLaptop.Name = "nudLaptop";
            this.nudLaptop.Size = new System.Drawing.Size(39, 20);
            this.nudLaptop.TabIndex = 0;
            this.nudLaptop.ValueChanged += new System.EventHandler(this.SetVisitor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laptop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Camera:";
            // 
            // nudCamera
            // 
            this.nudCamera.Location = new System.Drawing.Point(63, 98);
            this.nudCamera.Name = "nudCamera";
            this.nudCamera.Size = new System.Drawing.Size(39, 20);
            this.nudCamera.TabIndex = 2;
            this.nudCamera.ValueChanged += new System.EventHandler(this.SetVisitor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            // 
            // nudPhone
            // 
            this.nudPhone.Location = new System.Drawing.Point(63, 68);
            this.nudPhone.Name = "nudPhone";
            this.nudPhone.Size = new System.Drawing.Size(39, 20);
            this.nudPhone.TabIndex = 4;
            this.nudPhone.ValueChanged += new System.EventHandler(this.SetVisitor);
            // 
            // Products
            // 
            this.Products.Controls.Add(this.nudPhone);
            this.Products.Controls.Add(this.label3);
            this.Products.Controls.Add(this.nudLaptop);
            this.Products.Controls.Add(this.label1);
            this.Products.Controls.Add(this.label2);
            this.Products.Controls.Add(this.nudCamera);
            this.Products.Location = new System.Drawing.Point(12, 12);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(121, 148);
            this.Products.TabIndex = 6;
            this.Products.TabStop = false;
            this.Products.Text = "Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Where are you buying it?";
            // 
            // rbStore
            // 
            this.rbStore.AutoSize = true;
            this.rbStore.Checked = true;
            this.rbStore.Location = new System.Drawing.Point(9, 32);
            this.rbStore.Name = "rbStore";
            this.rbStore.Size = new System.Drawing.Size(50, 17);
            this.rbStore.TabIndex = 8;
            this.rbStore.TabStop = true;
            this.rbStore.Text = "Store";
            this.rbStore.UseVisualStyleBackColor = true;
            this.rbStore.CheckedChanged += new System.EventHandler(this.SetVisitor);
            // 
            // rbWebshop
            // 
            this.rbWebshop.AutoSize = true;
            this.rbWebshop.Location = new System.Drawing.Point(65, 32);
            this.rbWebshop.Name = "rbWebshop";
            this.rbWebshop.Size = new System.Drawing.Size(71, 17);
            this.rbWebshop.TabIndex = 9;
            this.rbWebshop.Text = "Webshop";
            this.rbWebshop.UseVisualStyleBackColor = true;
            this.rbWebshop.CheckedChanged += new System.EventHandler(this.SetVisitor);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbWebshop);
            this.groupBox1.Controls.Add(this.rbStore);
            this.groupBox1.Location = new System.Drawing.Point(158, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase details";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(158, 80);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(113, 80);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Purchases above 3000 euros get a discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(313, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 14;
            // 
            // TechStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 182);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Products);
            this.Name = "TechStore";
            this.Text = "On/Off-line Techstore";
            ((System.ComponentModel.ISupportInitialize)(this.nudLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhone)).EndInit();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudLaptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPhone;
        private System.Windows.Forms.GroupBox Products;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbStore;
        private System.Windows.Forms.RadioButton rbWebshop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrice;
    }
}

