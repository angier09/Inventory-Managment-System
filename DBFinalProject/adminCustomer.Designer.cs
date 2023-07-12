namespace DBFinalProject
{
    partial class adminCustomer
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
            this.ViewCust = new System.Windows.Forms.Button();
            this.deleteCus = new System.Windows.Forms.Button();
            this.editCus = new System.Windows.Forms.Button();
            this.CreateCus = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.ViewCust);
            this.panel1.Controls.Add(this.deleteCus);
            this.panel1.Controls.Add(this.editCus);
            this.panel1.Controls.Add(this.CreateCus);
            this.panel1.Controls.Add(this.option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 463);
            this.panel1.TabIndex = 0;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Lavender;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EXIT.Location = new System.Drawing.Point(572, 421);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 30);
            this.EXIT.TabIndex = 10;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // bckAdmin
            // 
            this.bckAdmin.BackColor = System.Drawing.Color.Black;
            this.bckAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckAdmin.Location = new System.Drawing.Point(329, 421);
            this.bckAdmin.Name = "bckAdmin";
            this.bckAdmin.Size = new System.Drawing.Size(75, 30);
            this.bckAdmin.TabIndex = 9;
            this.bckAdmin.Text = "BACK";
            this.bckAdmin.UseVisualStyleBackColor = false;
            this.bckAdmin.Click += new System.EventHandler(this.bckAdmin_Click);
            // 
            // ViewCust
            // 
            this.ViewCust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewCust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewCust.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCust.Location = new System.Drawing.Point(344, 314);
            this.ViewCust.Name = "ViewCust";
            this.ViewCust.Size = new System.Drawing.Size(262, 45);
            this.ViewCust.TabIndex = 4;
            this.ViewCust.Text = "View Customer";
            this.ViewCust.UseVisualStyleBackColor = true;
            this.ViewCust.Click += new System.EventHandler(this.ViewCust_Click);
            // 
            // deleteCus
            // 
            this.deleteCus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteCus.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCus.Location = new System.Drawing.Point(344, 242);
            this.deleteCus.Name = "deleteCus";
            this.deleteCus.Size = new System.Drawing.Size(262, 45);
            this.deleteCus.TabIndex = 3;
            this.deleteCus.Text = "Delete Customer";
            this.deleteCus.UseVisualStyleBackColor = true;
            this.deleteCus.Click += new System.EventHandler(this.deleteCus_Click);
            // 
            // editCus
            // 
            this.editCus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editCus.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCus.Location = new System.Drawing.Point(343, 166);
            this.editCus.Name = "editCus";
            this.editCus.Size = new System.Drawing.Size(262, 45);
            this.editCus.TabIndex = 2;
            this.editCus.Text = "Edit Customer";
            this.editCus.UseVisualStyleBackColor = true;
            this.editCus.Click += new System.EventHandler(this.editCus_Click);
            // 
            // CreateCus
            // 
            this.CreateCus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCus.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCus.Location = new System.Drawing.Point(343, 89);
            this.CreateCus.Name = "CreateCus";
            this.CreateCus.Size = new System.Drawing.Size(262, 45);
            this.CreateCus.TabIndex = 1;
            this.CreateCus.Text = "Create Customer";
            this.CreateCus.UseVisualStyleBackColor = true;
            this.CreateCus.Click += new System.EventHandler(this.CreateCus_Click);
            // 
            // option
            // 
            this.option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.option.BackColor = System.Drawing.Color.Transparent;
            this.option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.Location = new System.Drawing.Point(356, 26);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(232, 37);
            this.option.TabIndex = 0;
            this.option.Text = "SELECT AN OPTION";
            this.option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 463);
            this.Controls.Add(this.panel1);
            this.Name = "adminCustomer";
            this.Text = "adminCustomer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label option;
        private System.Windows.Forms.Button ViewCust;
        private System.Windows.Forms.Button deleteCus;
        private System.Windows.Forms.Button editCus;
        private System.Windows.Forms.Button CreateCus;
        private System.Windows.Forms.Button bckAdmin;
        private System.Windows.Forms.Button EXIT;
    }
}