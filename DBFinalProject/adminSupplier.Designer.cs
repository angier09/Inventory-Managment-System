﻿namespace DBFinalProject
{
    partial class adminSupplier
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
            this.viewSupp = new System.Windows.Forms.Button();
            this.deleteSupp = new System.Windows.Forms.Button();
            this.editSupp = new System.Windows.Forms.Button();
            this.CreateSupp = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.viewSupp);
            this.panel1.Controls.Add(this.deleteSupp);
            this.panel1.Controls.Add(this.editSupp);
            this.panel1.Controls.Add(this.CreateSupp);
            this.panel1.Controls.Add(this.option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 458);
            this.panel1.TabIndex = 1;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Lavender;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EXIT.Location = new System.Drawing.Point(531, 407);
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
            this.bckAdmin.Location = new System.Drawing.Point(331, 407);
            this.bckAdmin.Name = "bckAdmin";
            this.bckAdmin.Size = new System.Drawing.Size(75, 30);
            this.bckAdmin.TabIndex = 10;
            this.bckAdmin.Text = "BACK";
            this.bckAdmin.UseVisualStyleBackColor = false;
            this.bckAdmin.Click += new System.EventHandler(this.bckAdmin_Click);
            // 
            // viewSupp
            // 
            this.viewSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.viewSupp.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSupp.Location = new System.Drawing.Point(331, 318);
            this.viewSupp.Name = "viewSupp";
            this.viewSupp.Size = new System.Drawing.Size(268, 43);
            this.viewSupp.TabIndex = 5;
            this.viewSupp.Text = "View Supplier";
            this.viewSupp.UseVisualStyleBackColor = true;
            this.viewSupp.Click += new System.EventHandler(this.viewSupp_Click);
            // 
            // deleteSupp
            // 
            this.deleteSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteSupp.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSupp.Location = new System.Drawing.Point(330, 242);
            this.deleteSupp.Name = "deleteSupp";
            this.deleteSupp.Size = new System.Drawing.Size(268, 43);
            this.deleteSupp.TabIndex = 4;
            this.deleteSupp.Text = "Delete Supplier";
            this.deleteSupp.UseVisualStyleBackColor = true;
            this.deleteSupp.Click += new System.EventHandler(this.deleteSupp_Click);
            // 
            // editSupp
            // 
            this.editSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editSupp.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSupp.Location = new System.Drawing.Point(329, 166);
            this.editSupp.Name = "editSupp";
            this.editSupp.Size = new System.Drawing.Size(268, 43);
            this.editSupp.TabIndex = 3;
            this.editSupp.Text = "Edit Supplier";
            this.editSupp.UseVisualStyleBackColor = true;
            this.editSupp.Click += new System.EventHandler(this.editSupp_Click);
            // 
            // CreateSupp
            // 
            this.CreateSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateSupp.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSupp.Location = new System.Drawing.Point(328, 84);
            this.CreateSupp.Name = "CreateSupp";
            this.CreateSupp.Size = new System.Drawing.Size(268, 43);
            this.CreateSupp.TabIndex = 2;
            this.CreateSupp.Text = "Create Supplier";
            this.CreateSupp.UseVisualStyleBackColor = true;
            this.CreateSupp.Click += new System.EventHandler(this.CreateSupp_Click);
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
            this.option.Size = new System.Drawing.Size(238, 35);
            this.option.TabIndex = 1;
            this.option.Text = "SELECT AN OPTION";
            this.option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 458);
            this.Controls.Add(this.panel1);
            this.Name = "adminSupplier";
            this.Text = "adminSupplier";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button bckAdmin;
        private System.Windows.Forms.Button viewSupp;
        private System.Windows.Forms.Button deleteSupp;
        private System.Windows.Forms.Button editSupp;
        private System.Windows.Forms.Button CreateSupp;
        private System.Windows.Forms.Label option;
    }
}