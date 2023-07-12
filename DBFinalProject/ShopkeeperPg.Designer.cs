namespace DBFinalProject
{
    partial class ShopkeeperPg
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
            this.extShop = new System.Windows.Forms.Button();
            this.bckShop = new System.Windows.Forms.Button();
            this.NxtShop = new System.Windows.Forms.Button();
            this.ShopPassWord = new System.Windows.Forms.TextBox();
            this.ShopEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.LogIn = new System.Windows.Forms.Label();
            this.Shopkeeper = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.leftPanel.Controls.Add(this.extShop);
            this.leftPanel.Controls.Add(this.bckShop);
            this.leftPanel.Controls.Add(this.NxtShop);
            this.leftPanel.Controls.Add(this.ShopPassWord);
            this.leftPanel.Controls.Add(this.ShopEmail);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.Email);
            this.leftPanel.Controls.Add(this.Welcome);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 506);
            this.leftPanel.TabIndex = 0;
            // 
            // extShop
            // 
            this.extShop.BackColor = System.Drawing.Color.Khaki;
            this.extShop.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.extShop.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extShop.Location = new System.Drawing.Point(53, 387);
            this.extShop.Name = "extShop";
            this.extShop.Size = new System.Drawing.Size(75, 30);
            this.extShop.TabIndex = 8;
            this.extShop.Text = "EXIT";
            this.extShop.UseVisualStyleBackColor = false;
            this.extShop.Click += new System.EventHandler(this.extShop_Click);
            // 
            // bckShop
            // 
            this.bckShop.BackColor = System.Drawing.Color.Black;
            this.bckShop.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckShop.Location = new System.Drawing.Point(53, 351);
            this.bckShop.Name = "bckShop";
            this.bckShop.Size = new System.Drawing.Size(75, 30);
            this.bckShop.TabIndex = 7;
            this.bckShop.Text = "BACK";
            this.bckShop.UseVisualStyleBackColor = false;
            this.bckShop.Click += new System.EventHandler(this.bckShop_Click);
            // 
            // NxtShop
            // 
            this.NxtShop.BackColor = System.Drawing.Color.Khaki;
            this.NxtShop.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.NxtShop.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NxtShop.Location = new System.Drawing.Point(53, 314);
            this.NxtShop.Name = "NxtShop";
            this.NxtShop.Size = new System.Drawing.Size(75, 30);
            this.NxtShop.TabIndex = 6;
            this.NxtShop.Text = "NEXT";
            this.NxtShop.UseVisualStyleBackColor = false;
            this.NxtShop.Click += new System.EventHandler(this.NxtShop_Click);
            // 
            // ShopPassWord
            // 
            this.ShopPassWord.BackColor = System.Drawing.Color.Tan;
            this.ShopPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShopPassWord.Location = new System.Drawing.Point(7, 249);
            this.ShopPassWord.Name = "ShopPassWord";
            this.ShopPassWord.PasswordChar = '*';
            this.ShopPassWord.Size = new System.Drawing.Size(181, 20);
            this.ShopPassWord.TabIndex = 5;
            // 
            // ShopEmail
            // 
            this.ShopEmail.BackColor = System.Drawing.Color.Tan;
            this.ShopEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShopEmail.Location = new System.Drawing.Point(7, 173);
            this.ShopEmail.Name = "ShopEmail";
            this.ShopEmail.Size = new System.Drawing.Size(181, 20);
            this.ShopEmail.TabIndex = 4;
            this.ShopEmail.TextChanged += new System.EventHandler(this.ShopEmail_TextChanged);
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
            this.rightPanel.Controls.Add(this.Shopkeeper);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(695, 506);
            this.rightPanel.TabIndex = 1;
            // 
            // LogIn
            // 
            this.LogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogIn.BackColor = System.Drawing.Color.DimGray;
            this.LogIn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn.Location = new System.Drawing.Point(271, 116);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(215, 44);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "LOG IN PAGE";
            this.LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shopkeeper
            // 
            this.Shopkeeper.BackColor = System.Drawing.Color.Transparent;
            this.Shopkeeper.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shopkeeper.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Shopkeeper.Location = new System.Drawing.Point(6, 8);
            this.Shopkeeper.Name = "Shopkeeper";
            this.Shopkeeper.Size = new System.Drawing.Size(124, 23);
            this.Shopkeeper.TabIndex = 0;
            this.Shopkeeper.Text = "SHOPKEEPER";
            this.Shopkeeper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShopkeeperPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 506);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "ShopkeeperPg";
            this.Text = "ShopkeeperPg";
            this.Load += new System.EventHandler(this.ShopkeeperPg_Load_1);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TextBox ShopPassWord;
        private System.Windows.Forms.TextBox ShopEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label LogIn;
        private System.Windows.Forms.Label Shopkeeper;
        private System.Windows.Forms.Button extShop;
        private System.Windows.Forms.Button bckShop;
        private System.Windows.Forms.Button NxtShop;
    }
}