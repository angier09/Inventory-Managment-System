namespace DBFinalProject
{
    partial class RolePage
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
            this.BACK = new System.Windows.Forms.Button();
            this.CustomerRdio = new System.Windows.Forms.RadioButton();
            this.SupplierRadio = new System.Windows.Forms.RadioButton();
            this.ShopkeeperRdio = new System.Windows.Forms.RadioButton();
            this.ADMINradio = new System.Windows.Forms.RadioButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.leftPanel.Controls.Add(this.EXIT);
            this.leftPanel.Controls.Add(this.BACK);
            this.leftPanel.Controls.Add(this.CustomerRdio);
            this.leftPanel.Controls.Add(this.SupplierRadio);
            this.leftPanel.Controls.Add(this.ShopkeeperRdio);
            this.leftPanel.Controls.Add(this.ADMINradio);
            this.leftPanel.Controls.Add(this.Role);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 504);
            this.leftPanel.TabIndex = 0;
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.DarkKhaki;
            this.BACK.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.Location = new System.Drawing.Point(58, 331);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 30);
            this.BACK.TabIndex = 5;
            this.BACK.Text = "BACK";
            this.BACK.UseMnemonic = false;
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // CustomerRdio
            // 
            this.CustomerRdio.AutoSize = true;
            this.CustomerRdio.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerRdio.Location = new System.Drawing.Point(29, 280);
            this.CustomerRdio.Name = "CustomerRdio";
            this.CustomerRdio.Size = new System.Drawing.Size(127, 29);
            this.CustomerRdio.TabIndex = 4;
            this.CustomerRdio.Text = "CUSTOMER";
            this.CustomerRdio.UseVisualStyleBackColor = true;
            this.CustomerRdio.CheckedChanged += new System.EventHandler(this.CustomerRdio_CheckedChanged);
            // 
            // SupplierRadio
            // 
            this.SupplierRadio.AutoSize = true;
            this.SupplierRadio.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierRadio.Location = new System.Drawing.Point(29, 245);
            this.SupplierRadio.Name = "SupplierRadio";
            this.SupplierRadio.Size = new System.Drawing.Size(110, 29);
            this.SupplierRadio.TabIndex = 3;
            this.SupplierRadio.Text = "SUPPLIER";
            this.SupplierRadio.UseVisualStyleBackColor = true;
            this.SupplierRadio.CheckedChanged += new System.EventHandler(this.SupplierRadio_CheckedChanged);
            // 
            // ShopkeeperRdio
            // 
            this.ShopkeeperRdio.AutoSize = true;
            this.ShopkeeperRdio.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopkeeperRdio.Location = new System.Drawing.Point(29, 210);
            this.ShopkeeperRdio.Name = "ShopkeeperRdio";
            this.ShopkeeperRdio.Size = new System.Drawing.Size(146, 29);
            this.ShopkeeperRdio.TabIndex = 2;
            this.ShopkeeperRdio.Text = "SHOP KEEPER";
            this.ShopkeeperRdio.UseVisualStyleBackColor = true;
            this.ShopkeeperRdio.CheckedChanged += new System.EventHandler(this.ShopkeeperRdio_CheckedChanged);
            // 
            // ADMINradio
            // 
            this.ADMINradio.AutoSize = true;
            this.ADMINradio.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINradio.Location = new System.Drawing.Point(29, 175);
            this.ADMINradio.Name = "ADMINradio";
            this.ADMINradio.Size = new System.Drawing.Size(91, 29);
            this.ADMINradio.TabIndex = 1;
            this.ADMINradio.Text = "ADMIN";
            this.ADMINradio.UseVisualStyleBackColor = true;
            this.ADMINradio.CheckedChanged += new System.EventHandler(this.ADMINradio_CheckedChanged);
            // 
            // rightPanel
            // 
            this.rightPanel.BackgroundImage = global::DBFinalProject.Properties.Resources.Dark_Green_Modern_Hello_September_Instagram_Post;
            this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(687, 504);
            this.rightPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "TYMES GROCERY SHOP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(174, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.DarkRed;
            this.EXIT.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EXIT.Location = new System.Drawing.Point(58, 365);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 30);
            this.EXIT.TabIndex = 6;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseMnemonic = false;
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Role.Image = global::DBFinalProject.Properties.Resources.Dark_Green_Modern_Hello_September_Instagram_Post;
            this.Role.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Role.Location = new System.Drawing.Point(12, 107);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(163, 38);
            this.Role.TabIndex = 0;
            this.Role.Text = "SELECT ROLE";
            this.Role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RolePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 504);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "RolePage";
            this.Text = "RolePage";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ADMINradio;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.RadioButton SupplierRadio;
        private System.Windows.Forms.RadioButton ShopkeeperRdio;
        private System.Windows.Forms.RadioButton CustomerRdio;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button EXIT;
    }
}