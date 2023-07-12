namespace DBFinalProject
{
    partial class AdminCRUD
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
            this.NEXT = new System.Windows.Forms.Button();
            this.bckAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Button();
            this.Supplier = new System.Windows.Forms.Button();
            this.SHOPKEEPER = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.ADMINPAGE;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.NEXT);
            this.panel1.Controls.Add(this.bckAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Customer);
            this.panel1.Controls.Add(this.Supplier);
            this.panel1.Controls.Add(this.SHOPKEEPER);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 458);
            this.panel1.TabIndex = 0;
            // 
            // NEXT
            // 
            this.NEXT.BackColor = System.Drawing.Color.Lavender;
            this.NEXT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NEXT.Location = new System.Drawing.Point(533, 405);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(75, 30);
            this.NEXT.TabIndex = 9;
            this.NEXT.Text = "EXIT";
            this.NEXT.UseVisualStyleBackColor = false;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // bckAdmin
            // 
            this.bckAdmin.BackColor = System.Drawing.Color.Black;
            this.bckAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckAdmin.Location = new System.Drawing.Point(277, 405);
            this.bckAdmin.Name = "bckAdmin";
            this.bckAdmin.Size = new System.Drawing.Size(75, 30);
            this.bckAdmin.TabIndex = 8;
            this.bckAdmin.Text = "BACK";
            this.bckAdmin.UseVisualStyleBackColor = false;
            this.bckAdmin.Click += new System.EventHandler(this.bckAdmin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT OPTION TO PERFORM OPERATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer
            // 
            this.Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(379, 316);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(262, 45);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "CUSTOMER";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Supplier
            // 
            this.Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.Location = new System.Drawing.Point(377, 194);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(262, 45);
            this.Supplier.TabIndex = 1;
            this.Supplier.Text = "SUPPLIER";
            this.Supplier.UseVisualStyleBackColor = true;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // SHOPKEEPER
            // 
            this.SHOPKEEPER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHOPKEEPER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHOPKEEPER.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOPKEEPER.Location = new System.Drawing.Point(376, 82);
            this.SHOPKEEPER.Name = "SHOPKEEPER";
            this.SHOPKEEPER.Size = new System.Drawing.Size(262, 45);
            this.SHOPKEEPER.TabIndex = 0;
            this.SHOPKEEPER.Text = "SHOPKEEPER";
            this.SHOPKEEPER.UseVisualStyleBackColor = true;
            this.SHOPKEEPER.Click += new System.EventHandler(this.SHOPKEEPER_Click);
            // 
            // AdminCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 458);
            this.Controls.Add(this.panel1);
            this.Name = "AdminCRUD";
            this.Text = "AdminCRUD";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.Button SHOPKEEPER;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Button bckAdmin;
    }
}