namespace DBFinalProject
{
    partial class LogoPage
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
            this.WELCOME = new System.Windows.Forms.Label();
            this.extLogoPg = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.Inventory = new System.Windows.Forms.Label();
            this.NXTLogoPg = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftPanel.Controls.Add(this.extLogoPg);
            this.leftPanel.Controls.Add(this.NXTLogoPg);
            this.leftPanel.Controls.Add(this.WELCOME);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 506);
            this.leftPanel.TabIndex = 0;
            // 
            // WELCOME
            // 
            this.WELCOME.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WELCOME.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WELCOME.Location = new System.Drawing.Point(6, 0);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(194, 52);
            this.WELCOME.TabIndex = 0;
            this.WELCOME.Text = "WELCOME";
            this.WELCOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extLogoPg
            // 
            this.extLogoPg.BackColor = System.Drawing.Color.DarkKhaki;
            this.extLogoPg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.extLogoPg.Cursor = System.Windows.Forms.Cursors.Default;
            this.extLogoPg.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extLogoPg.ForeColor = System.Drawing.Color.Black;
            this.extLogoPg.Location = new System.Drawing.Point(31, 264);
            this.extLogoPg.Name = "extLogoPg";
            this.extLogoPg.Size = new System.Drawing.Size(143, 36);
            this.extLogoPg.TabIndex = 2;
            this.extLogoPg.Text = "EXIT";
            this.extLogoPg.UseVisualStyleBackColor = false;
            this.extLogoPg.Click += new System.EventHandler(this.extLogoPg_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackgroundImage = global::DBFinalProject.Properties.Resources.Green_and_Beige_Groceries_Business_Logo;
            this.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightPanel.Controls.Add(this.Inventory);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(200, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(723, 506);
            this.RightPanel.TabIndex = 1;
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.Transparent;
            this.Inventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Inventory.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inventory.Location = new System.Drawing.Point(3, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(720, 52);
            this.Inventory.TabIndex = 1;
            this.Inventory.Text = "Inventory Managment System";
            this.Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NXTLogoPg
            // 
            this.NXTLogoPg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NXTLogoPg.BackgroundImage = global::DBFinalProject.Properties.Resources.Green_and_Beige_Groceries_Business_Logo;
            this.NXTLogoPg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NXTLogoPg.Cursor = System.Windows.Forms.Cursors.Default;
            this.NXTLogoPg.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NXTLogoPg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NXTLogoPg.Location = new System.Drawing.Point(32, 200);
            this.NXTLogoPg.Name = "NXTLogoPg";
            this.NXTLogoPg.Size = new System.Drawing.Size(143, 36);
            this.NXTLogoPg.TabIndex = 1;
            this.NXTLogoPg.Text = "NEXT";
            this.NXTLogoPg.UseVisualStyleBackColor = false;
            this.NXTLogoPg.Click += new System.EventHandler(this.NXTLogoPg_Click);
            // 
            // LogoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 506);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.leftPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LogoPage";
            this.Text = "LogoPage";
            this.leftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Button NXTLogoPg;
        private System.Windows.Forms.Button extLogoPg;
    }
}

