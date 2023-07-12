namespace DBFinalProject
{
    partial class CreateCustomerForm
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
            this.registerDate = new System.Windows.Forms.DateTimePicker();
            this.enter = new System.Windows.Forms.Button();
            this.suppEmail = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.custName = new System.Windows.Forms.TextBox();
            this.custPass = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custCnic = new System.Windows.Forms.TextBox();
            this.custID = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.Label();
            this.cusCnic = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.PASS = new System.Windows.Forms.Label();
            this.cusEmail = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.registerDate);
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.suppEmail);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.custName);
            this.panel1.Controls.Add(this.custPass);
            this.panel1.Controls.Add(this.custEmail);
            this.panel1.Controls.Add(this.custCnic);
            this.panel1.Controls.Add(this.custID);
            this.panel1.Controls.Add(this.CName);
            this.panel1.Controls.Add(this.cusCnic);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.PASS);
            this.panel1.Controls.Add(this.cusEmail);
            this.panel1.Controls.Add(this.Discard);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 455);
            this.panel1.TabIndex = 3;
            // 
            // registerDate
            // 
            this.registerDate.CustomFormat = "MM/dd/yyyy";
            this.registerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.registerDate.Location = new System.Drawing.Point(283, 138);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(200, 20);
            this.registerDate.TabIndex = 20;
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
            this.suppEmail.Text = "REGISTRATION DATE";
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
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(283, 106);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(495, 20);
            this.custName.TabIndex = 16;
            // 
            // custPass
            // 
            this.custPass.Location = new System.Drawing.Point(283, 246);
            this.custPass.Name = "custPass";
            this.custPass.Size = new System.Drawing.Size(495, 20);
            this.custPass.TabIndex = 15;
            // 
            // custEmail
            // 
            this.custEmail.Location = new System.Drawing.Point(283, 210);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(495, 20);
            this.custEmail.TabIndex = 13;
            // 
            // custCnic
            // 
            this.custCnic.Location = new System.Drawing.Point(283, 175);
            this.custCnic.Name = "custCnic";
            this.custCnic.Size = new System.Drawing.Size(495, 20);
            this.custCnic.TabIndex = 12;
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(283, 73);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(495, 20);
            this.custID.TabIndex = 11;
            // 
            // CName
            // 
            this.CName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.Location = new System.Drawing.Point(130, 106);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(135, 23);
            this.CName.TabIndex = 9;
            this.CName.Text = "CUSTOMER NAME";
            this.CName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusCnic
            // 
            this.cusCnic.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCnic.Location = new System.Drawing.Point(130, 172);
            this.cusCnic.Name = "cusCnic";
            this.cusCnic.Size = new System.Drawing.Size(135, 23);
            this.cusCnic.TabIndex = 8;
            this.cusCnic.Text = "CNIC";
            this.cusCnic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(130, 70);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(135, 23);
            this.id.TabIndex = 7;
            this.id.Text = "CUSTOMER ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PASS
            // 
            this.PASS.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASS.Location = new System.Drawing.Point(130, 246);
            this.PASS.Name = "PASS";
            this.PASS.Size = new System.Drawing.Size(135, 23);
            this.PASS.TabIndex = 6;
            this.PASS.Text = "PASSWORD";
            this.PASS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusEmail
            // 
            this.cusEmail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusEmail.Location = new System.Drawing.Point(130, 207);
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Size = new System.Drawing.Size(135, 23);
            this.cusEmail.TabIndex = 4;
            this.cusEmail.Text = "CUSTOMER EMAIL";
            this.cusEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Discard.Text = "BACK";
            this.Discard.UseVisualStyleBackColor = false;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(304, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(325, 63);
            this.add.TabIndex = 0;
            this.add.Text = "------------------\r\n| CREATE CUSTOMER  |\r\n------------------";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 455);
            this.Controls.Add(this.panel1);
            this.Name = "CreateCustomerForm";
            this.Text = "CreateCustomerForm";
            this.Load += new System.EventHandler(this.CreateCustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker registerDate;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label suppEmail;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox custPass;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.TextBox custCnic;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label cusCnic;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label PASS;
        private System.Windows.Forms.Label cusEmail;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.Label add;
    }
}