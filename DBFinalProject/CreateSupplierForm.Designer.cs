namespace DBFinalProject
{
    partial class CreateSupplierForm
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
            this.enter = new System.Windows.Forms.Button();
            this.suppEmail = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.suppCnic = new System.Windows.Forms.TextBox();
            this.suppContact = new System.Windows.Forms.TextBox();
            this.supplierPass = new System.Windows.Forms.TextBox();
            this.suppID = new System.Windows.Forms.TextBox();
            this.supplierEmail = new System.Windows.Forms.TextBox();
            this.suppName = new System.Windows.Forms.Label();
            this.suppPass = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.Discard = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.suppEmail);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.supplierName);
            this.panel1.Controls.Add(this.suppCnic);
            this.panel1.Controls.Add(this.suppContact);
            this.panel1.Controls.Add(this.supplierPass);
            this.panel1.Controls.Add(this.suppID);
            this.panel1.Controls.Add(this.supplierEmail);
            this.panel1.Controls.Add(this.suppName);
            this.panel1.Controls.Add(this.suppPass);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.cnic);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.Discard);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 464);
            this.panel1.TabIndex = 1;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.DarkKhaki;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(688, 300);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(90, 30);
            this.enter.TabIndex = 19;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // suppEmail
            // 
            this.suppEmail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppEmail.Location = new System.Drawing.Point(130, 138);
            this.suppEmail.Name = "suppEmail";
            this.suppEmail.Size = new System.Drawing.Size(135, 23);
            this.suppEmail.TabIndex = 18;
            this.suppEmail.Text = "SUPPLIER EMAIL";
            this.suppEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkKhaki;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(425, 300);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 30);
            this.exit.TabIndex = 17;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(283, 106);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(495, 20);
            this.supplierName.TabIndex = 16;
            // 
            // suppCnic
            // 
            this.suppCnic.Location = new System.Drawing.Point(283, 246);
            this.suppCnic.Name = "suppCnic";
            this.suppCnic.Size = new System.Drawing.Size(495, 20);
            this.suppCnic.TabIndex = 15;
            // 
            // suppContact
            // 
            this.suppContact.Location = new System.Drawing.Point(283, 210);
            this.suppContact.Name = "suppContact";
            this.suppContact.Size = new System.Drawing.Size(495, 20);
            this.suppContact.TabIndex = 13;
            // 
            // supplierPass
            // 
            this.supplierPass.Location = new System.Drawing.Point(283, 175);
            this.supplierPass.Name = "supplierPass";
            this.supplierPass.Size = new System.Drawing.Size(495, 20);
            this.supplierPass.TabIndex = 12;
            // 
            // suppID
            // 
            this.suppID.Location = new System.Drawing.Point(283, 73);
            this.suppID.Name = "suppID";
            this.suppID.Size = new System.Drawing.Size(495, 20);
            this.suppID.TabIndex = 11;
            // 
            // supplierEmail
            // 
            this.supplierEmail.Location = new System.Drawing.Point(283, 141);
            this.supplierEmail.Name = "supplierEmail";
            this.supplierEmail.Size = new System.Drawing.Size(495, 20);
            this.supplierEmail.TabIndex = 10;
            // 
            // suppName
            // 
            this.suppName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppName.Location = new System.Drawing.Point(130, 106);
            this.suppName.Name = "suppName";
            this.suppName.Size = new System.Drawing.Size(135, 23);
            this.suppName.TabIndex = 9;
            this.suppName.Text = "SUPPLIER NAME";
            this.suppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suppPass
            // 
            this.suppPass.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppPass.Location = new System.Drawing.Point(130, 172);
            this.suppPass.Name = "suppPass";
            this.suppPass.Size = new System.Drawing.Size(135, 23);
            this.suppPass.TabIndex = 8;
            this.suppPass.Text = "SUPPLIER PASSWORD";
            this.suppPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(130, 70);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(135, 23);
            this.id.TabIndex = 7;
            this.id.Text = "SUPPLIER ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnic
            // 
            this.cnic.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic.Location = new System.Drawing.Point(130, 246);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(135, 23);
            this.cnic.TabIndex = 6;
            this.cnic.Text = "CNIC";
            this.cnic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(130, 207);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(135, 23);
            this.category.TabIndex = 4;
            this.category.Text = "SUPPLIER CONTACT";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Discard
            // 
            this.Discard.BackColor = System.Drawing.Color.DarkKhaki;
            this.Discard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Discard.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discard.Location = new System.Drawing.Point(160, 300);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(90, 30);
            this.Discard.TabIndex = 1;
            this.Discard.Text = "DISCARD";
            this.Discard.UseVisualStyleBackColor = false;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(315, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(325, 63);
            this.add.TabIndex = 0;
            this.add.Text = "------------------\r\n| CREATE SUPPLIER |\r\n------------------";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 464);
            this.Controls.Add(this.panel1);
            this.Name = "CreateSupplierForm";
            this.Text = "CreateSupplierForm";
            this.Load += new System.EventHandler(this.CreateSupplierForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label suppEmail;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox suppCnic;
        private System.Windows.Forms.TextBox suppContact;
        private System.Windows.Forms.TextBox supplierPass;
        private System.Windows.Forms.TextBox suppID;
        private System.Windows.Forms.TextBox supplierEmail;
        private System.Windows.Forms.Label suppName;
        private System.Windows.Forms.Label suppPass;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label cnic;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Button enter;
    }
}