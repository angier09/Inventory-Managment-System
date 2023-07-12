namespace DBFinalProject
{
    partial class SupplierCRUD
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
            this.view = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DBFinalProject.Properties.Resources.ShopLogin__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.view);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 530);
            this.panel1.TabIndex = 1;
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(353, 373);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(245, 52);
            this.view.TabIndex = 6;
            this.view.Text = "VIEW PRODUCT";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.BurlyWood;
            this.back.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(421, 473);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 27);
            this.back.TabIndex = 5;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(353, 284);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(245, 52);
            this.delete.TabIndex = 4;
            this.delete.Text = "DELETE PRODUCT";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(353, 190);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(245, 52);
            this.edit.TabIndex = 2;
            this.edit.Text = "EDIT PRODUCT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(353, 91);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(245, 52);
            this.add.TabIndex = 1;
            this.add.Text = "ADD PRODUCT";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // option
            // 
            this.option.BackColor = System.Drawing.Color.Transparent;
            this.option.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.ForeColor = System.Drawing.Color.White;
            this.option.Location = new System.Drawing.Point(262, 9);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(432, 42);
            this.option.TabIndex = 0;
            this.option.Text = "CHOOSE OPTION";
            this.option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 530);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierCRUD";
            this.Text = "SupplierCRUD";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label option;
        private System.Windows.Forms.Button view;
    }
}