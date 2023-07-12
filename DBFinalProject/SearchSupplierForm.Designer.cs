namespace DBFinalProject
{
    partial class SearchSupplierForm
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
            this.SuppName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin__4_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.SuppName);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 450);
            this.panel1.TabIndex = 2;
            // 
            // SuppName
            // 
            this.SuppName.Location = new System.Drawing.Point(272, 178);
            this.SuppName.Name = "SuppName";
            this.SuppName.Size = new System.Drawing.Size(495, 20);
            this.SuppName.TabIndex = 25;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(126, 178);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 23);
            this.name.TabIndex = 24;
            this.name.Text = "SUPPLIER NAME";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DarkKhaki;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(609, 258);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 30);
            this.Search.TabIndex = 23;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkKhaki;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(442, 258);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 30);
            this.exit.TabIndex = 22;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(272, 139);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(495, 20);
            this.txtID.TabIndex = 16;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkKhaki;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(272, 258);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 30);
            this.back.TabIndex = 14;
            this.back.Text = "DISCARD";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(126, 136);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 23);
            this.id.TabIndex = 8;
            this.id.Text = "SUPPLIER ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update.Location = new System.Drawing.Point(315, 0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(272, 72);
            this.update.TabIndex = 0;
            this.update.Text = "----------------------\r\n| SEARCH SUPPLIER  |\r\n----------------------\r\n";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SearchSupplierForm";
            this.Text = "SearchSupplierForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SuppName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label update;
    }
}