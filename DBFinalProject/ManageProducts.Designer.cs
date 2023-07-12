namespace DBFinalProject
{
    partial class ManageProducts
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
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.chkStock = new System.Windows.Forms.Label();
            this.expiryPro = new System.Windows.Forms.Label();
            this.suppId = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin__5_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.chkStock);
            this.panel1.Controls.Add(this.expiryPro);
            this.panel1.Controls.Add(this.suppId);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 428);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkKhaki;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(241, 282);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 30);
            this.back.TabIndex = 23;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // chkStock
            // 
            this.chkStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkStock.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkStock.Location = new System.Drawing.Point(389, 217);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(167, 36);
            this.chkStock.TabIndex = 22;
            this.chkStock.Text = "CHECK STOCK";
            this.chkStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStock.Click += new System.EventHandler(this.chkStock_Click);
            // 
            // expiryPro
            // 
            this.expiryPro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.expiryPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expiryPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expiryPro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expiryPro.Location = new System.Drawing.Point(388, 152);
            this.expiryPro.Name = "expiryPro";
            this.expiryPro.Size = new System.Drawing.Size(168, 44);
            this.expiryPro.TabIndex = 21;
            this.expiryPro.Text = "CHECK EXPIRY PRODUCTS";
            this.expiryPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expiryPro.Click += new System.EventHandler(this.expiryPro_Click);
            // 
            // suppId
            // 
            this.suppId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.suppId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suppId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.suppId.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suppId.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.suppId.Location = new System.Drawing.Point(388, 99);
            this.suppId.Name = "suppId";
            this.suppId.Size = new System.Drawing.Size(168, 39);
            this.suppId.TabIndex = 20;
            this.suppId.Text = "SHOW INVENTORY";
            this.suppId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.suppId.Click += new System.EventHandler(this.suppId_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(369, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(211, 76);
            this.delete.TabIndex = 1;
            this.delete.Text = "---------------------\r\n| MANAGE PRODUCT |\r\n---------------------";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 428);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chkStock;
        private System.Windows.Forms.Label expiryPro;
        private System.Windows.Forms.Label suppId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
    }
}