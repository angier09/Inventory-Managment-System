namespace DBFinalProject
{
    partial class adminShopkeeper
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
            this.ViewSK = new System.Windows.Forms.Button();
            this.deleteSk = new System.Windows.Forms.Button();
            this.editSK = new System.Windows.Forms.Button();
            this.CreateSK = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.ViewSK);
            this.panel1.Controls.Add(this.deleteSk);
            this.panel1.Controls.Add(this.editSK);
            this.panel1.Controls.Add(this.CreateSK);
            this.panel1.Controls.Add(this.option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 460);
            this.panel1.TabIndex = 0;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Lavender;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EXIT.Location = new System.Drawing.Point(537, 418);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 30);
            this.EXIT.TabIndex = 11;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // bckAdmin
            // 
            this.bckAdmin.BackColor = System.Drawing.Color.Black;
            this.bckAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckAdmin.Location = new System.Drawing.Point(331, 418);
            this.bckAdmin.Name = "bckAdmin";
            this.bckAdmin.Size = new System.Drawing.Size(75, 30);
            this.bckAdmin.TabIndex = 10;
            this.bckAdmin.Text = "BACK";
            this.bckAdmin.UseVisualStyleBackColor = false;
            this.bckAdmin.Click += new System.EventHandler(this.bckAdmin_Click);
            // 
            // ViewSK
            // 
            this.ViewSK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewSK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewSK.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSK.Location = new System.Drawing.Point(331, 318);
            this.ViewSK.Name = "ViewSK";
            this.ViewSK.Size = new System.Drawing.Size(262, 45);
            this.ViewSK.TabIndex = 5;
            this.ViewSK.Text = "View Shopkeeper";
            this.ViewSK.UseVisualStyleBackColor = true;
            this.ViewSK.Click += new System.EventHandler(this.ViewSK_Click);
            // 
            // deleteSk
            // 
            this.deleteSk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteSk.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSk.Location = new System.Drawing.Point(330, 242);
            this.deleteSk.Name = "deleteSk";
            this.deleteSk.Size = new System.Drawing.Size(262, 45);
            this.deleteSk.TabIndex = 4;
            this.deleteSk.Text = "Delete Shopkeeper";
            this.deleteSk.UseVisualStyleBackColor = true;
            this.deleteSk.Click += new System.EventHandler(this.deleteSk_Click);
            // 
            // editSK
            // 
            this.editSK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editSK.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSK.Location = new System.Drawing.Point(329, 166);
            this.editSK.Name = "editSK";
            this.editSK.Size = new System.Drawing.Size(262, 45);
            this.editSK.TabIndex = 3;
            this.editSK.Text = "Edit Shopkeeper";
            this.editSK.UseVisualStyleBackColor = true;
            this.editSK.Click += new System.EventHandler(this.editSK_Click);
            // 
            // CreateSK
            // 
            this.CreateSK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateSK.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSK.Location = new System.Drawing.Point(328, 84);
            this.CreateSK.Name = "CreateSK";
            this.CreateSK.Size = new System.Drawing.Size(262, 45);
            this.CreateSK.TabIndex = 2;
            this.CreateSK.Text = "Create Shopkeeper";
            this.CreateSK.UseVisualStyleBackColor = true;
            this.CreateSK.Click += new System.EventHandler(this.CreateSK_Click);
            // 
            // option
            // 
            this.option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.option.BackColor = System.Drawing.Color.Transparent;
            this.option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.Location = new System.Drawing.Point(343, 24);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(232, 37);
            this.option.TabIndex = 1;
            this.option.Text = "SELECT AN OPTION";
            this.option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminShopkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 460);
            this.Controls.Add(this.panel1);
            this.Name = "adminShopkeeper";
            this.Text = "adminShopkeeper";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label option;
        private System.Windows.Forms.Button ViewSK;
        private System.Windows.Forms.Button deleteSk;
        private System.Windows.Forms.Button editSK;
        private System.Windows.Forms.Button CreateSK;
        private System.Windows.Forms.Button bckAdmin;
        private System.Windows.Forms.Button EXIT;
    }
}