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
    public partial class SearchSupplierForm : Form
    {
        public SearchSupplierForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            adminSupplier aObj = new adminSupplier();
            aObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //write code here
        private void Search_Click(object sender, EventArgs e)
        {
            //if search the
            this.Hide();
            UpdateSupplierForm uObj = new UpdateSupplierForm();
            uObj.ShowDialog();
        }
    }
}
