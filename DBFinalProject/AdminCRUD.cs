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
    public partial class AdminCRUD : Form
    {
        public AdminCRUD()
        {
            InitializeComponent();
        }

        private void bckAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogInPg aObj = new AdminLogInPg();
            aObj.ShowDialog();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminCustomer acObj = new adminCustomer();
            acObj.ShowDialog();
        }

        private void SHOPKEEPER_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminShopkeeper asObj = new adminShopkeeper();
            asObj.ShowDialog();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminSupplier aSObj = new adminSupplier();
            aSObj.ShowDialog();
        }
    }
}
