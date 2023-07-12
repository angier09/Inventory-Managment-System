namespace DBFinalProject
{
    partial class ViewShopKeeper
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
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.shopGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkKhaki;
            this.back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(87, 380);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 30);
            this.back.TabIndex = 15;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkKhaki;
            this.exit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(664, 380);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 30);
            this.exit.TabIndex = 23;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // shopGrid
            // 
            this.shopGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.shopGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopGrid.GridColor = System.Drawing.Color.LavenderBlush;
            this.shopGrid.Location = new System.Drawing.Point(32, 52);
            this.shopGrid.Name = "shopGrid";
            this.shopGrid.Size = new System.Drawing.Size(823, 322);
            this.shopGrid.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(340, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Shopkeepers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewShopKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBFinalProject.Properties.Resources.Page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(885, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shopGrid);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Name = "ViewShopKeeper";
            this.Text = "ViewShopKeeper";
            this.Load += new System.EventHandler(this.ViewShopKeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView shopGrid;
        private System.Windows.Forms.Label label1;
    }
}