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
    public partial class adminCustomer : Form
    {
        public adminCustomer()
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

        private void CreateCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCustomerForm cObj = new CreateCustomerForm();
            cObj.ShowDialog();
        }

        private void ViewCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomerGrid vObj = new ViewCustomerGrid();
            vObj.ShowDialog();

        }

        private void deleteCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCustomerForm dObj = new DeleteCustomerForm();
            dObj.ShowDialog();
        }

        private void editCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCustomerForm uObj = new UpdateCustomerForm();
            uObj.ShowDialog();
        }
    }
}
