namespace DBFinalProject
{
    partial class CustomerOptionform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.bckAdmin = new System.Windows.Forms.Button();
            this.ShopHistory = new System.Windows.Forms.Button();
            this.CreateCart = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.Page;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.bckAdmin);
            this.panel1.Controls.Add(this.ShopHistory);
            this.panel1.Controls.Add(this.CreateCart);
            this.panel1.Controls.Add(this.option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 461);
            this.panel1.TabIndex = 1;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Lavender;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EXIT.Location = new System.Drawing.Point(501, 285);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 30);
            this.EXIT.TabIndex = 10;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            // 
            // bckAdmin
            // 
            this.bckAdmin.BackColor = System.Drawing.Color.Black;
            this.bckAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckAdmin.Location = new System.Drawing.Point(343, 285);
            this.bckAdmin.Name = "bckAdmin";
            this.bckAdmin.Size = new System.Drawing.Size(75, 30);
            this.bckAdmin.TabIndex = 9;
            this.bckAdmin.Text = "BACK";
            this.bckAdmin.UseVisualStyleBackColor = false;
            // 
            // ShopHistory
            // 
            this.ShopHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShopHistory.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopHistory.Location = new System.Drawing.Point(326, 208);
            this.ShopHistory.Name = "ShopHistory";
            this.ShopHistory.Size = new System.Drawing.Size(263, 43);
            this.ShopHistory.TabIndex = 2;
            this.ShopHistory.Text = "View Shopping History";
            this.ShopHistory.UseVisualStyleBackColor = true;
            this.ShopHistory.Click += new System.EventHandler(this.ShopHistory_Click);
            // 
            // CreateCart
            // 
            this.CreateCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCart.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCart.Location = new System.Drawing.Point(326, 125);
            this.CreateCart.Name = "CreateCart";
            this.CreateCart.Size = new System.Drawing.Size(263, 43);
            this.CreateCart.TabIndex = 1;
            this.CreateCart.Text = "Create Cart";
            this.CreateCart.UseVisualStyleBackColor = true;
            this.CreateCart.Click += new System.EventHandler(this.CreateCart_Click);
            // 
            // option
            // 
            this.option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.option.BackColor = System.Drawing.Color.Transparent;
            this.option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.Location = new System.Drawing.Point(343, 53);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(233, 35);
            this.option.TabIndex = 0;
            this.option.Text = "SELECT AN OPTION";
            this.option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerOptionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 461);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerOptionform";
            this.Text = "CustomerOptionform";
            this.Load += new System.EventHandler(this.CustomerOptionform_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button bckAdmin;
        private System.Windows.Forms.Button ShopHistory;
        private System.Windows.Forms.Button CreateCart;
        private System.Windows.Forms.Label option;
    }
}