namespace DBFinalProject
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPro = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.DataGridView();
            this.cartPage = new System.Windows.Forms.Button();
            this.quantityPro = new System.Windows.Forms.NumericUpDown();
            this.Quantity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.quantityPro);
            this.panel1.Controls.Add(this.cartPage);
            this.panel1.Controls.Add(this.newPro);
            this.panel1.Controls.Add(this.ProductID);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.Inventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 463);
            this.panel1.TabIndex = 1;
            // 
            // newPro
            // 
            this.newPro.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPro.ForeColor = System.Drawing.Color.Black;
            this.newPro.Location = new System.Drawing.Point(228, 377);
            this.newPro.Name = "newPro";
            this.newPro.Size = new System.Drawing.Size(364, 34);
            this.newPro.TabIndex = 4;
            this.newPro.Text = "CLICK TO ADD PRODUCT";
            this.newPro.UseVisualStyleBackColor = true;
            this.newPro.Click += new System.EventHandler(this.newPro_Click);
            // 
            // ProductID
            // 
            this.ProductID.BackColor = System.Drawing.Color.Tan;
            this.ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductID.Location = new System.Drawing.Point(439, 310);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(153, 20);
            this.ProductID.TabIndex = 2;
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.Tan;
            this.addProduct.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(225, 310);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(208, 21);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = " Enter Product Id To Add Product";
            this.addProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Inventory
            // 
            this.Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory.Location = new System.Drawing.Point(35, 54);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(795, 250);
            this.Inventory.TabIndex = 0;
            // 
            // cartPage
            // 
            this.cartPage.BackColor = System.Drawing.Color.Gray;
            this.cartPage.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartPage.ForeColor = System.Drawing.Color.White;
            this.cartPage.Location = new System.Drawing.Point(673, 417);
            this.cartPage.Name = "cartPage";
            this.cartPage.Size = new System.Drawing.Size(176, 34);
            this.cartPage.TabIndex = 5;
            this.cartPage.Text = "Go To Cart";
            this.cartPage.UseVisualStyleBackColor = false;
            this.cartPage.Click += new System.EventHandler(this.cartPage_Click);
            // 
            // quantityPro
            // 
            this.quantityPro.BackColor = System.Drawing.Color.Tan;
            this.quantityPro.Location = new System.Drawing.Point(439, 344);
            this.quantityPro.Name = "quantityPro";
            this.quantityPro.Size = new System.Drawing.Size(153, 20);
            this.quantityPro.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.Tan;
            this.Quantity.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(225, 342);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(208, 21);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity Of Product";
            this.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 463);
            this.Controls.Add(this.panel1);
            this.Name = "AddToCart";
            this.Text = "AddToCart";
            this.Load += new System.EventHandler(this.AddToCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newPro;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label addProduct;
        private System.Windows.Forms.DataGridView Inventory;
        private System.Windows.Forms.Button cartPage;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.NumericUpDown quantityPro;
    }
}