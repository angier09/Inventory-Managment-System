namespace DBFinalProject
{
    partial class CartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkout = new System.Windows.Forms.Button();
            this.newPro = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.deleteProduct = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.DataGridView();
            this.bckCust = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.bckCust);
            this.panel1.Controls.Add(this.checkout);
            this.panel1.Controls.Add(this.newPro);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.ProductID);
            this.panel1.Controls.Add(this.deleteProduct);
            this.panel1.Controls.Add(this.Cart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 459);
            this.panel1.TabIndex = 0;
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.Teal;
            this.checkout.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.ForeColor = System.Drawing.Color.Black;
            this.checkout.Location = new System.Drawing.Point(178, 392);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(445, 34);
            this.checkout.TabIndex = 5;
            this.checkout.Text = "PROCEED TO CHECKOUT";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // newPro
            // 
            this.newPro.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPro.ForeColor = System.Drawing.Color.Black;
            this.newPro.Location = new System.Drawing.Point(178, 344);
            this.newPro.Name = "newPro";
            this.newPro.Size = new System.Drawing.Size(445, 34);
            this.newPro.TabIndex = 4;
            this.newPro.Text = "CLICK TO ADD NEW PRODUCT";
            this.newPro.UseVisualStyleBackColor = true;
            this.newPro.Click += new System.EventHandler(this.newPro_Click);
            // 
            // remove
            // 
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.Black;
            this.remove.Location = new System.Drawing.Point(548, 306);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 21);
            this.remove.TabIndex = 3;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // ProductID
            // 
            this.ProductID.BackColor = System.Drawing.Color.Tan;
            this.ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductID.Location = new System.Drawing.Point(389, 306);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(153, 20);
            this.ProductID.TabIndex = 2;
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.Tan;
            this.deleteProduct.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.Location = new System.Drawing.Point(175, 306);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(208, 21);
            this.deleteProduct.TabIndex = 1;
            this.deleteProduct.Text = "Enter Product Id to Remove Product ";
            this.deleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cart
            // 
            this.Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cart.Location = new System.Drawing.Point(35, 25);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(795, 250);
            this.Cart.TabIndex = 0;
            // 
            // bckCust
            // 
            this.bckCust.BackColor = System.Drawing.Color.Black;
            this.bckCust.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckCust.Location = new System.Drawing.Point(12, 392);
            this.bckCust.Name = "bckCust";
            this.bckCust.Size = new System.Drawing.Size(75, 30);
            this.bckCust.TabIndex = 10;
            this.bckCust.Text = "BACK";
            this.bckCust.UseVisualStyleBackColor = false;
            this.bckCust.Click += new System.EventHandler(this.bckCust_Click);
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 459);
            this.Controls.Add(this.panel1);
            this.Name = "CartPage";
            this.Text = "CartPage";
            this.Load += new System.EventHandler(this.CartPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button newPro;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label deleteProduct;
        private System.Windows.Forms.DataGridView Cart;
        private System.Windows.Forms.Button bckCust;
    }
}