namespace DBFinalProject
{
    partial class SupplierAddProduct
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
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSuppId = new System.Windows.Forms.TextBox();
            this.suppId = new System.Windows.Forms.Label();
            this.proName = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtManu = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.manufacturer = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.NEXT = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.productPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtSuppId);
            this.panel1.Controls.Add(this.suppId);
            this.panel1.Controls.Add(this.proName);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtCat);
            this.panel1.Controls.Add(this.txtManu);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.manufacturer);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.NEXT);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 504);
            this.panel1.TabIndex = 1;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(283, 348);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(495, 20);
            this.productPrice.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // txtSuppId
            // 
            this.txtSuppId.Location = new System.Drawing.Point(283, 313);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(495, 20);
            this.txtSuppId.TabIndex = 20;
            // 
            // suppId
            // 
            this.suppId.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppId.Location = new System.Drawing.Point(130, 313);
            this.suppId.Name = "suppId";
            this.suppId.Size = new System.Drawing.Size(120, 23);
            this.suppId.TabIndex = 19;
            this.suppId.Text = "SUPPLIER ID";
            this.suppId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proName
            // 
            this.proName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proName.Location = new System.Drawing.Point(130, 138);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(120, 23);
            this.proName.TabIndex = 18;
            this.proName.Text = "PRODUCT NAME";
            this.proName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkKhaki;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(427, 401);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 30);
            this.exit.TabIndex = 17;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(283, 277);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(495, 20);
            this.txtStock.TabIndex = 15;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(283, 210);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(495, 20);
            this.txtCat.TabIndex = 13;
            // 
            // txtManu
            // 
            this.txtManu.Location = new System.Drawing.Point(283, 175);
            this.txtManu.Name = "txtManu";
            this.txtManu.Size = new System.Drawing.Size(495, 20);
            this.txtManu.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(283, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(495, 20);
            this.txtID.TabIndex = 11;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(283, 141);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(495, 20);
            this.textName.TabIndex = 10;
            // 
            // manufacturer
            // 
            this.manufacturer.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturer.Location = new System.Drawing.Point(130, 172);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(120, 23);
            this.manufacturer.TabIndex = 8;
            this.manufacturer.Text = "MANUFACTURER";
            this.manufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(130, 104);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 23);
            this.id.TabIndex = 7;
            this.id.Text = "PRODUCT ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(130, 274);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(120, 23);
            this.stock.TabIndex = 6;
            this.stock.Text = "STOCK";
            this.stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(130, 241);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(120, 23);
            this.date.TabIndex = 5;
            this.date.Text = "EXPIRY DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(130, 207);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(120, 23);
            this.category.TabIndex = 4;
            this.category.Text = "CATEGORY";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NEXT
            // 
            this.NEXT.BackColor = System.Drawing.Color.DarkKhaki;
            this.NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NEXT.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEXT.Location = new System.Drawing.Point(698, 401);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(80, 30);
            this.NEXT.TabIndex = 2;
            this.NEXT.Text = "ENTER";
            this.NEXT.UseVisualStyleBackColor = false;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkKhaki;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(160, 401);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 30);
            this.back.TabIndex = 1;
            this.back.Text = "DISCARD";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(366, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(325, 63);
            this.add.TabIndex = 0;
            this.add.Text = "------------------\r\n| ADD PRODUCT SUPPLIER |\r\n------------------";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 504);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierAddProduct";
            this.Text = "SupplierAddProduct";
            this.Load += new System.EventHandler(this.SupplierAddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSuppId;
        private System.Windows.Forms.Label suppId;
        private System.Windows.Forms.Label proName;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtManu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label add;
    }
}