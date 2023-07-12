namespace DBFinalProject
{
    partial class AdminLogInPg
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
            this.extAdmin = new System.Windows.Forms.Button();
            this.bckAdmin = new System.Windows.Forms.Button();
            this.NxtAdmin = new System.Windows.Forms.Button();
            this.AdminPassWord = new System.Windows.Forms.TextBox();
            this.AdminEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.LogIn = new System.Windows.Forms.Label();
            this.ADMIN = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.leftPanel.Controls.Add(this.extAdmin);
            this.leftPanel.Controls.Add(this.bckAdmin);
            this.leftPanel.Controls.Add(this.NxtAdmin);
            this.leftPanel.Controls.Add(this.AdminPassWord);
            this.leftPanel.Controls.Add(this.AdminEmail);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.Email);
            this.leftPanel.Controls.Add(this.Welcome);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 429);
            this.leftPanel.TabIndex = 1;
            // 
            // extAdmin
            // 
            this.extAdmin.BackColor = System.Drawing.Color.Khaki;
            this.extAdmin.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.extAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extAdmin.Location = new System.Drawing.Point(53, 387);
            this.extAdmin.Name = "extAdmin";
            this.extAdmin.Size = new System.Drawing.Size(75, 30);
            this.extAdmin.TabIndex = 8;
            this.extAdmin.Text = "EXIT";
            this.extAdmin.UseVisualStyleBackColor = false;
            this.extAdmin.Click += new System.EventHandler(this.extAdmin_Click);
            // 
            // bckAdmin
            // 
            this.bckAdmin.BackColor = System.Drawing.Color.Black;
            this.bckAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckAdmin.Location = new System.Drawing.Point(53, 351);
            this.bckAdmin.Name = "bckAdmin";
            this.bckAdmin.Size = new System.Drawing.Size(75, 30);
            this.bckAdmin.TabIndex = 7;
            this.bckAdmin.Text = "BACK";
            this.bckAdmin.UseVisualStyleBackColor = false;
            this.bckAdmin.Click += new System.EventHandler(this.bckAdmin_Click);
            // 
            // NxtAdmin
            // 
            this.NxtAdmin.BackColor = System.Drawing.Color.Khaki;
            this.NxtAdmin.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.NxtAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NxtAdmin.Location = new System.Drawing.Point(53, 314);
            this.NxtAdmin.Name = "NxtAdmin";
            this.NxtAdmin.Size = new System.Drawing.Size(75, 30);
            this.NxtAdmin.TabIndex = 6;
            this.NxtAdmin.Text = "NEXT";
            this.NxtAdmin.UseVisualStyleBackColor = false;
            this.NxtAdmin.Click += new System.EventHandler(this.NxtAdmin_Click);
            // 
            // AdminPassWord
            // 
            this.AdminPassWord.BackColor = System.Drawing.Color.Tan;
            this.AdminPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminPassWord.Location = new System.Drawing.Point(7, 249);
            this.AdminPassWord.Name = "AdminPassWord";
            this.AdminPassWord.PasswordChar = '*';
            this.AdminPassWord.Size = new System.Drawing.Size(181, 20);
            this.AdminPassWord.TabIndex = 5;
            // 
            // AdminEmail
            // 
            this.AdminEmail.BackColor = System.Drawing.Color.Tan;
            this.AdminEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminEmail.Location = new System.Drawing.Point(7, 173);
            this.AdminEmail.Name = "AdminEmail";
            this.AdminEmail.Size = new System.Drawing.Size(181, 20);
            this.AdminEmail.TabIndex = 4;
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
            this.rightPanel.Controls.Add(this.ADMIN);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(744, 429);
            this.rightPanel.TabIndex = 2;
            // 
            // LogIn
            // 
            this.LogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogIn.BackColor = System.Drawing.Color.DimGray;
            this.LogIn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn.Location = new System.Drawing.Point(292, 82);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(215, 44);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "LOG IN PAGE";
            this.LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ADMIN
            // 
            this.ADMIN.BackColor = System.Drawing.Color.Transparent;
            this.ADMIN.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ADMIN.Location = new System.Drawing.Point(6, 8);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(124, 23);
            this.ADMIN.TabIndex = 0;
            this.ADMIN.Text = "ADMIN";
            this.ADMIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminLogInPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 429);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "AdminLogInPg";
            this.Text = "AdminLogInPg";
            this.Load += new System.EventHandler(this.AdminLogInPg_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button extAdmin;
        private System.Windows.Forms.Button bckAdmin;
        private System.Windows.Forms.Button NxtAdmin;
        private System.Windows.Forms.TextBox AdminPassWord;
        private System.Windows.Forms.TextBox AdminEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label LogIn;
        private System.Windows.Forms.Label ADMIN;
    }
}