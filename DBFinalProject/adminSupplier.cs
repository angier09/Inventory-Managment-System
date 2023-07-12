using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFinalProject
{
    public partial class adminSupplier : Form
    {
        public adminSupplier()
        {
            InitializeComponent();
        }

        private void bckAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCRUD acObj = new AdminCRUD();
            acObj.ShowDialog();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CreateSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateSupplierForm cObj = new CreateSupplierForm();
            cObj.ShowDialog();
        }

        private void editSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateSupplierForm sObj = new UpdateSupplierForm();
            sObj.ShowDialog();
        }

        private void deleteSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteSupplierForm dObj = new DeleteSupplierForm();
            dObj.ShowDialog();
        }

        private void viewSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSupplierGrid vObj = new ViewSupplierGrid();
            vObj.ShowDialog();
        }
    }
}
