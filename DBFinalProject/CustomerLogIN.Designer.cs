namespace DBFinalProject
{
    partial class CustomerLogIN
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.extCust = new System.Windows.Forms.Button();
            this.bckCust = new System.Windows.Forms.Button();
            this.NxtCust = new System.Windows.Forms.Button();
            this.PassCustomer = new System.Windows.Forms.TextBox();
            this.EmailCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.LogIn = new System.Windows.Forms.Label();
            this.CUSTOMER = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.leftPanel.Controls.Add(this.extCust);
            this.leftPanel.Controls.Add(this.bckCust);
            this.leftPanel.Controls.Add(this.NxtCust);
            this.leftPanel.Controls.Add(this.PassCustomer);
            this.leftPanel.Controls.Add(this.EmailCustomer);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.Email);
            this.leftPanel.Controls.Add(this.Welcome);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 427);
            this.leftPanel.TabIndex = 1;
            // 
            // extCust
            // 
            this.extCust.BackColor = System.Drawing.Color.Khaki;
            this.extCust.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.extCust.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extCust.Location = new System.Drawing.Point(53, 387);
            this.extCust.Name = "extCust";
            this.extCust.Size = new System.Drawing.Size(75, 30);
            this.extCust.TabIndex = 8;
            this.extCust.Text = "EXIT";
            this.extCust.UseVisualStyleBackColor = false;
            this.extCust.Click += new System.EventHandler(this.extCust_Click);
            // 
            // bckCust
            // 
            this.bckCust.BackColor = System.Drawing.Color.Black;
            this.bckCust.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckCust.Location = new System.Drawing.Point(53, 351);
            this.bckCust.Name = "bckCust";
            this.bckCust.Size = new System.Drawing.Size(75, 30);
            this.bckCust.TabIndex = 7;
            this.bckCust.Text = "BACK";
            this.bckCust.UseVisualStyleBackColor = false;
            this.bckCust.Click += new System.EventHandler(this.bckCust_Click);
            // 
            // NxtCust
            // 
            this.NxtCust.BackColor = System.Drawing.Color.Khaki;
            this.NxtCust.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.NxtCust.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NxtCust.Location = new System.Drawing.Point(53, 314);
            this.NxtCust.Name = "NxtCust";
            this.NxtCust.Size = new System.Drawing.Size(75, 30);
            this.NxtCust.TabIndex = 6;
            this.NxtCust.Text = "NEXT";
            this.NxtCust.UseVisualStyleBackColor = false;
            this.NxtCust.Click += new System.EventHandler(this.NxtCust_Click);
            // 
            // PassCustomer
            // 
            this.PassCustomer.BackColor = System.Drawing.Color.Tan;
            this.PassCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassCustomer.Location = new System.Drawing.Point(7, 249);
            this.PassCustomer.Name = "PassCustomer";
            this.PassCustomer.PasswordChar = '*';
            this.PassCustomer.Size = new System.Drawing.Size(181, 20);
            this.PassCustomer.TabIndex = 5;
            // 
            // EmailCustomer
            // 
            this.EmailCustomer.BackColor = System.Drawing.Color.Tan;
            this.EmailCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailCustomer.Location = new System.Drawing.Point(7, 173);
            this.EmailCustomer.Name = "EmailCustomer";
            this.EmailCustomer.Size = new System.Drawing.Size(181, 20);
            this.EmailCustomer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(3, 147);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 23);
            this.Email.TabIndex = 2;
            this.Email.Text = "Enter Email ";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.Welcome.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcome.Location = new System.Drawing.Point(70, 8);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(124, 23);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "WELCOME";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            this.rightPanel.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightPanel.Controls.Add(this.LogIn);
            this.rightPanel.Controls.Add(this.CUSTOMER);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(748, 427);
            this.rightPanel.TabIndex = 2;
            // 
            // LogIn
            // 
            this.LogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogIn.BackColor = System.Drawing.Color.DimGray;
            this.LogIn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn.Location = new System.Drawing.Point(301, 83);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(215, 44);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "LOG IN PAGE";
            this.LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.BackColor = System.Drawing.Color.Transparent;
            this.CUSTOMER.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CUSTOMER.Location = new System.Drawing.Point(6, 8);
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.Size = new System.Drawing.Size(124, 23);
            this.CUSTOMER.TabIndex = 0;
            this.CUSTOMER.Text = "CUSTOMER";
            this.CUSTOMER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerLogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 427);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "CustomerLogIN";
            this.Text = "CustomerLogIN";
            this.Load += new System.EventHandler(this.CustomerLogIN_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button extCust;
        private System.Windows.Forms.Button bckCust;
        private System.Windows.Forms.Button NxtCust;
        private System.Windows.Forms.TextBox PassCustomer;
        private System.Windows.Forms.TextBox EmailCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label LogIn;
        private System.Windows.Forms.Label CUSTOMER;
    }
}