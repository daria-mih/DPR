namespace FactoryPattern
{
    partial class FormFactory
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
            this.btnPhone = new System.Windows.Forms.Button();
            this.rbNokiaPhone = new System.Windows.Forms.RadioButton();
            this.gbPhones = new System.Windows.Forms.GroupBox();
            this.rbSamsungPhone = new System.Windows.Forms.RadioButton();
            this.rbApplePhone = new System.Windows.Forms.RadioButton();
            this.gbTablets = new System.Windows.Forms.GroupBox();
            this.rbSamsungTab = new System.Windows.Forms.RadioButton();
            this.rbAppleTab = new System.Windows.Forms.RadioButton();
            this.rbNokiaTab = new System.Windows.Forms.RadioButton();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnPhablet = new System.Windows.Forms.Button();
            this.gbPhablets = new System.Windows.Forms.GroupBox();
            this.rbSamsungPhab = new System.Windows.Forms.RadioButton();
            this.rbApplePhab = new System.Windows.Forms.RadioButton();
            this.rbNokiaPhab = new System.Windows.Forms.RadioButton();
            this.gbPhones.SuspendLayout();
            this.gbTablets.SuspendLayout();
            this.gbPhablets.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(12, 118);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(121, 23);
            this.btnPhone.TabIndex = 1;
            this.btnPhone.Text = "Create Phone";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // rbNokiaPhone
            // 
            this.rbNokiaPhone.AutoSize = true;
            this.rbNokiaPhone.Checked = true;
            this.rbNokiaPhone.Location = new System.Drawing.Point(15, 19);
            this.rbNokiaPhone.Name = "rbNokiaPhone";
            this.rbNokiaPhone.Size = new System.Drawing.Size(84, 17);
            this.rbNokiaPhone.TabIndex = 2;
            this.rbNokiaPhone.TabStop = true;
            this.rbNokiaPhone.Text = "Nokia Lumia";
            this.rbNokiaPhone.UseVisualStyleBackColor = true;
            this.rbNokiaPhone.CheckedChanged += new System.EventHandler(this.rbNokiaPhone_CheckedChanged);
            // 
            // gbPhones
            // 
            this.gbPhones.Controls.Add(this.rbSamsungPhone);
            this.gbPhones.Controls.Add(this.rbApplePhone);
            this.gbPhones.Controls.Add(this.rbNokiaPhone);
            this.gbPhones.Location = new System.Drawing.Point(12, 12);
            this.gbPhones.Name = "gbPhones";
            this.gbPhones.Size = new System.Drawing.Size(121, 100);
            this.gbPhones.TabIndex = 3;
            this.gbPhones.TabStop = false;
            this.gbPhones.Text = "Phones";
            // 
            // rbSamsungPhone
            // 
            this.rbSamsungPhone.AutoSize = true;
            this.rbSamsungPhone.Location = new System.Drawing.Point(15, 65);
            this.rbSamsungPhone.Name = "rbSamsungPhone";
            this.rbSamsungPhone.Size = new System.Drawing.Size(104, 17);
            this.rbSamsungPhone.TabIndex = 4;
            this.rbSamsungPhone.Text = "Samsung Galaxy";
            this.rbSamsungPhone.UseVisualStyleBackColor = true;
            this.rbSamsungPhone.CheckedChanged += new System.EventHandler(this.rbSamsungPhone_CheckedChanged);
            // 
            // rbApplePhone
            // 
            this.rbApplePhone.AutoSize = true;
            this.rbApplePhone.Location = new System.Drawing.Point(14, 42);
            this.rbApplePhone.Name = "rbApplePhone";
            this.rbApplePhone.Size = new System.Drawing.Size(88, 17);
            this.rbApplePhone.TabIndex = 3;
            this.rbApplePhone.Text = "Apple iPhone";
            this.rbApplePhone.UseVisualStyleBackColor = true;
            this.rbApplePhone.CheckedChanged += new System.EventHandler(this.rbApplePhone_CheckedChanged);
            // 
            // gbTablets
            // 
            this.gbTablets.Controls.Add(this.rbSamsungTab);
            this.gbTablets.Controls.Add(this.rbAppleTab);
            this.gbTablets.Controls.Add(this.rbNokiaTab);
            this.gbTablets.Location = new System.Drawing.Point(205, 12);
            this.gbTablets.Name = "gbTablets";
            this.gbTablets.Size = new System.Drawing.Size(140, 100);
            this.gbTablets.TabIndex = 5;
            this.gbTablets.TabStop = false;
            this.gbTablets.Text = "Tablets";
            // 
            // rbSamsungTab
            // 
            this.rbSamsungTab.AutoSize = true;
            this.rbSamsungTab.Location = new System.Drawing.Point(15, 65);
            this.rbSamsungTab.Name = "rbSamsungTab";
            this.rbSamsungTab.Size = new System.Drawing.Size(126, 17);
            this.rbSamsungTab.TabIndex = 4;
            this.rbSamsungTab.Text = "Samsung Galaxy Tab";
            this.rbSamsungTab.UseVisualStyleBackColor = true;
            // 
            // rbAppleTab
            // 
            this.rbAppleTab.AutoSize = true;
            this.rbAppleTab.Location = new System.Drawing.Point(14, 42);
            this.rbAppleTab.Name = "rbAppleTab";
            this.rbAppleTab.Size = new System.Drawing.Size(76, 17);
            this.rbAppleTab.TabIndex = 3;
            this.rbAppleTab.Text = "Apple iPad";
            this.rbAppleTab.UseVisualStyleBackColor = true;
            // 
            // rbNokiaTab
            // 
            this.rbNokiaTab.AutoSize = true;
            this.rbNokiaTab.Checked = true;
            this.rbNokiaTab.Location = new System.Drawing.Point(15, 19);
            this.rbNokiaTab.Name = "rbNokiaTab";
            this.rbNokiaTab.Size = new System.Drawing.Size(106, 17);
            this.rbNokiaTab.TabIndex = 2;
            this.rbNokiaTab.TabStop = true;
            this.rbNokiaTab.Text = "Nokia Lumia Tab";
            this.rbNokiaTab.UseVisualStyleBackColor = true;
            // 
            // btnTablet
            // 
            this.btnTablet.Location = new System.Drawing.Point(205, 118);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(140, 23);
            this.btnTablet.TabIndex = 6;
            this.btnTablet.Text = "Create Tablet";
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
            // 
            // btnPhablet
            // 
            this.btnPhablet.Location = new System.Drawing.Point(406, 118);
            this.btnPhablet.Name = "btnPhablet";
            this.btnPhablet.Size = new System.Drawing.Size(140, 23);
            this.btnPhablet.TabIndex = 8;
            this.btnPhablet.Text = "Create Phablet";
            this.btnPhablet.UseVisualStyleBackColor = true;
            this.btnPhablet.Click += new System.EventHandler(this.btnPhablet_Click);
            // 
            // gbPhablets
            // 
            this.gbPhablets.Controls.Add(this.rbSamsungPhab);
            this.gbPhablets.Controls.Add(this.rbApplePhab);
            this.gbPhablets.Controls.Add(this.rbNokiaPhab);
            this.gbPhablets.Location = new System.Drawing.Point(406, 12);
            this.gbPhablets.Name = "gbPhablets";
            this.gbPhablets.Size = new System.Drawing.Size(140, 100);
            this.gbPhablets.TabIndex = 7;
            this.gbPhablets.TabStop = false;
            this.gbPhablets.Text = "Phablets";
            // 
            // rbSamsungPhab
            // 
            this.rbSamsungPhab.AutoSize = true;
            this.rbSamsungPhab.Location = new System.Drawing.Point(15, 65);
            this.rbSamsungPhab.Name = "rbSamsungPhab";
            this.rbSamsungPhab.Size = new System.Drawing.Size(130, 17);
            this.rbSamsungPhab.TabIndex = 4;
            this.rbSamsungPhab.Text = "Samsung Galaxy Note";
            this.rbSamsungPhab.UseVisualStyleBackColor = true;
            // 
            // rbApplePhab
            // 
            this.rbApplePhab.AutoSize = true;
            this.rbApplePhab.Location = new System.Drawing.Point(14, 42);
            this.rbApplePhab.Name = "rbApplePhab";
            this.rbApplePhab.Size = new System.Drawing.Size(111, 17);
            this.rbApplePhab.TabIndex = 3;
            this.rbApplePhab.Text = "Apple iPhone Plus";
            this.rbApplePhab.UseVisualStyleBackColor = true;
            // 
            // rbNokiaPhab
            // 
            this.rbNokiaPhab.AutoSize = true;
            this.rbNokiaPhab.Checked = true;
            this.rbNokiaPhab.Location = new System.Drawing.Point(15, 19);
            this.rbNokiaPhab.Name = "rbNokiaPhab";
            this.rbNokiaPhab.Size = new System.Drawing.Size(112, 17);
            this.rbNokiaPhab.TabIndex = 2;
            this.rbNokiaPhab.TabStop = true;
            this.rbNokiaPhab.Text = "Nokia Lumia Phab";
            this.rbNokiaPhab.UseVisualStyleBackColor = true;
            // 
            // FormFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 154);
            this.Controls.Add(this.btnPhablet);
            this.Controls.Add(this.btnTablet);
            this.Controls.Add(this.gbPhablets);
            this.Controls.Add(this.gbTablets);
            this.Controls.Add(this.gbPhones);
            this.Controls.Add(this.btnPhone);
            this.Name = "FormFactory";
            this.Text = "SmartFactory";
            this.gbPhones.ResumeLayout(false);
            this.gbPhones.PerformLayout();
            this.gbTablets.ResumeLayout(false);
            this.gbTablets.PerformLayout();
            this.gbPhablets.ResumeLayout(false);
            this.gbPhablets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.RadioButton rbNokiaPhone;
        private System.Windows.Forms.GroupBox gbPhones;
        private System.Windows.Forms.RadioButton rbSamsungPhone;
        private System.Windows.Forms.RadioButton rbApplePhone;
        private System.Windows.Forms.GroupBox gbTablets;
        private System.Windows.Forms.RadioButton rbSamsungTab;
        private System.Windows.Forms.RadioButton rbAppleTab;
        private System.Windows.Forms.RadioButton rbNokiaTab;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnPhablet;
        private System.Windows.Forms.GroupBox gbPhablets;
        private System.Windows.Forms.RadioButton rbSamsungPhab;
        private System.Windows.Forms.RadioButton rbApplePhab;
        private System.Windows.Forms.RadioButton rbNokiaPhab;
    }
}

