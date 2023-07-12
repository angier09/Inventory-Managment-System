namespace DBFinalProject
{
    partial class SupplierLogIn
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
            this.bckSupp = new System.Windows.Forms.Button();
            this.PassSupp = new System.Windows.Forms.TextBox();
            this.EmailSupp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.LogIn = new System.Windows.Forms.Label();
            this.SUPPLIER = new System.Windows.Forms.Label();
            this.extSupp = new System.Windows.Forms.Button();
            this.NxtSupp = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.leftPanel.Controls.Add(this.extSupp);
            this.leftPanel.Controls.Add(this.bckSupp);
            this.leftPanel.Controls.Add(this.NxtSupp);
            this.leftPanel.Controls.Add(this.PassSupp);
            this.leftPanel.Controls.Add(this.EmailSupp);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.Email);
            this.leftPanel.Controls.Add(this.Welcome);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 430);
            this.leftPanel.TabIndex = 1;
            // 
            // bckSupp
            // 
            this.bckSupp.BackColor = System.Drawing.Color.Black;
            this.bckSupp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckSupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckSupp.Location = new System.Drawing.Point(53, 351);
            this.bckSupp.Name = "bckSupp";
            this.bckSupp.Size = new System.Drawing.Size(75, 30);
            this.bckSupp.TabIndex = 7;
            this.bckSupp.Text = "BACK";
            this.bckSupp.UseVisualStyleBackColor = false;
            this.bckSupp.Click += new System.EventHandler(this.bckSupp_Click);
            // 
            // PassSupp
            // 
            this.PassSupp.BackColor = System.Drawing.Color.Tan;
            this.PassSupp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassSupp.Location = new System.Drawing.Point(7, 249);
            this.PassSupp.Name = "PassSupp";
            this.PassSupp.PasswordChar = '*';
            this.PassSupp.Size = new System.Drawing.Size(181, 20);
            this.PassSupp.TabIndex = 5;
            // 
            // EmailSupp
            // 
            this.EmailSupp.BackColor = System.Drawing.Color.Tan;
            this.EmailSupp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailSupp.Location = new System.Drawing.Point(7, 173);
            this.EmailSupp.Name = "EmailSupp";
            this.EmailSupp.Size = new System.Drawing.Size(181, 20);
            this.EmailSupp.TabIndex = 4;
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
            this.rightPanel.Controls.Add(this.SUPPLIER);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(739, 430);
            this.rightPanel.TabIndex = 2;
            // 
            // LogIn
            // 
            this.LogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogIn.BackColor = System.Drawing.Color.DimGray;
            this.LogIn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn.Location = new System.Drawing.Point(291, 94);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(215, 44);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "LOG IN PAGE";
            this.LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.BackColor = System.Drawing.Color.Transparent;
            this.SUPPLIER.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPLIER.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SUPPLIER.Location = new System.Drawing.Point(6, 8);
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.Size = new System.Drawing.Size(124, 23);
            this.SUPPLIER.TabIndex = 0;
            this.SUPPLIER.Text = "SUPPLIER";
            this.SUPPLIER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // extSupp
            // 
            this.extSupp.BackColor = System.Drawing.Color.Khaki;
            this.extSupp.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.extSupp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extSupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extSupp.Location = new System.Drawing.Point(53, 387);
            this.extSupp.Name = "extSupp";
            this.extSupp.Size = new System.Drawing.Size(75, 30);
            this.extSupp.TabIndex = 8;
            this.extSupp.Text = "EXIT";
            this.extSupp.UseVisualStyleBackColor = false;
            this.extSupp.Click += new System.EventHandler(this.extSupp_Click);
            // 
            // NxtSupp
            // 
            this.NxtSupp.BackColor = System.Drawing.Color.Khaki;
            this.NxtSupp.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.NxtSupp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtSupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NxtSupp.Location = new System.Drawing.Point(53, 314);
            this.NxtSupp.Name = "NxtSupp";
            this.NxtSupp.Size = new System.Drawing.Size(75, 30);
            this.NxtSupp.TabIndex = 6;
            this.NxtSupp.Text = "NEXT";
            this.NxtSupp.UseVisualStyleBackColor = false;
            this.NxtSupp.Click += new System.EventHandler(this.NxtSupp_Click);
            // 
            // SupplierLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 430);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "SupplierLogIn";
            this.Text = "SupplierLogIn";
            this.Load += new System.EventHandler(this.SupplierLogIn_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button extSupp;
        private System.Windows.Forms.Button bckSupp;
        private System.Windows.Forms.Button NxtSupp;
        private System.Windows.Forms.TextBox PassSupp;
        private System.Windows.Forms.TextBox EmailSupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label LogIn;
        private System.Windows.Forms.Label SUPPLIER;
    }
}