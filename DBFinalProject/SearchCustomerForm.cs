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
    public partial class SearchCustomerForm : Form
    {
        public SearchCustomerForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            adminCustomer aObj = new adminCustomer();
            aObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Found");
            this.Hide();
            UpdateCustomerForm uObj = new UpdateCustomerForm();
            uObj.ShowDialog();
        }
    }
}
