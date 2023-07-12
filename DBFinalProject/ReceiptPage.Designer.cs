namespace DBFinalProject
{
    partial class ReceiptPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cost = new System.Windows.Forms.Label();
            this.equalTo = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.DataGridView();
            this.bckCust = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Receipt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.bckCust);
            this.panel1.Controls.Add(this.cost);
            this.panel1.Controls.Add(this.equalTo);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.Receipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 450);
            this.panel1.TabIndex = 2;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(699, 341);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(103, 27);
            this.cost.TabIndex = 8;
            this.cost.Text = "0";
            this.cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalTo
            // 
            this.equalTo.BackColor = System.Drawing.Color.Tan;
            this.equalTo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalTo.Location = new System.Drawing.Point(695, 299);
            this.equalTo.Name = "equalTo";
            this.equalTo.Size = new System.Drawing.Size(107, 27);
            this.equalTo.TabIndex = 7;
            this.equalTo.Text = "Total Cost";
            this.equalTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Gray;
            this.Home.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(654, 404);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(176, 34);
            this.Home.TabIndex = 4;
            this.Home.Text = "HOME";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Receipt
            // 
            this.Receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Receipt.Location = new System.Drawing.Point(35, 25);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(795, 250);
            this.Receipt.TabIndex = 0;
            // 
            // bckCust
            // 
            this.bckCust.BackColor = System.Drawing.Color.Black;
            this.bckCust.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bckCust.Location = new System.Drawing.Point(35, 404);
            this.bckCust.Name = "bckCust";
            this.bckCust.Size = new System.Drawing.Size(75, 30);
            this.bckCust.TabIndex = 11;
            this.bckCust.Text = "BACK";
            this.bckCust.UseVisualStyleBackColor = false;
            this.bckCust.Click += new System.EventHandler(this.bckCust_Click);
            // 
            // ReceiptPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ReceiptPage";
            this.Text = "ReceiptPage";
            this.Load += new System.EventHandler(this.ReceiptPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Receipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.DataGridView Receipt;
        private System.Windows.Forms.Label equalTo;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Button bckCust;
    }
}