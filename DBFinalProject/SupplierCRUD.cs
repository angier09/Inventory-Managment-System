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
    public partial class SupplierCRUD : Form
    {
        public SupplierCRUD()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierAddProduct sAObj = new SupplierAddProduct();
            sAObj.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierEditProduct sEObj = new SupplierEditProduct();
            sEObj.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierDeleteProduct sdObj = new SupplierDeleteProduct();
            sdObj.ShowDialog();
        }

        private void view_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSupplierProducts sdObj = new ViewSupplierProducts();
            sdObj.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierLogIn sLObj = new SupplierLogIn();
            sLObj.ShowDialog();
        }
    }
}
