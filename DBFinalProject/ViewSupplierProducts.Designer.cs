namespace DBFinalProject
{
    partial class ViewSupplierProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.suppGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.Page;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.suppGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 469);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Supplier Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkKhaki;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(506, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 30);
            this.Back.TabIndex = 26;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.DarkKhaki;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(239, 369);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(90, 30);
            this.EXIT.TabIndex = 25;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // suppGrid
            // 
            this.suppGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.suppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppGrid.GridColor = System.Drawing.Color.LavenderBlush;
            this.suppGrid.Location = new System.Drawing.Point(28, 42);
            this.suppGrid.Name = "suppGrid";
            this.suppGrid.Size = new System.Drawing.Size(823, 321);
            this.suppGrid.TabIndex = 0;
            // 
            // ViewSupplierProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 469);
            this.Controls.Add(this.panel1);
            this.Name = "ViewSupplierProducts";
            this.Text = "ViewSupplierProducts";
            this.Load += new System.EventHandler(this.ViewSupplierProducts_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.DataGridView suppGrid;
    }
}