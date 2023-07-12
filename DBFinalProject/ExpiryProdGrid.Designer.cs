namespace DBFinalProject
{
    partial class ExpiryProdGrid
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
            this.back = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.expiryGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expiryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.Page;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.expiryGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 449);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkKhaki;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(534, 369);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 30);
            this.back.TabIndex = 26;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.DarkKhaki;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(238, 369);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(90, 30);
            this.EXIT.TabIndex = 25;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // expiryGrid
            // 
            this.expiryGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.expiryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiryGrid.GridColor = System.Drawing.Color.LavenderBlush;
            this.expiryGrid.Location = new System.Drawing.Point(28, 44);
            this.expiryGrid.Name = "expiryGrid";
            this.expiryGrid.Size = new System.Drawing.Size(823, 319);
            this.expiryGrid.TabIndex = 0;
            this.expiryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expiryGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "EXPIRY PRODUCTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpiryProdGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 449);
            this.Controls.Add(this.panel1);
            this.Name = "ExpiryProdGrid";
            this.Text = "ExpiryProdGrid";
            this.Load += new System.EventHandler(this.ExpiryProdGrid_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expiryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.DataGridView expiryGrid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}