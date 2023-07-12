using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DBFinalProject
{
    public partial class CustomerOptionform : Form
    {
        public string passForCust;  //sending pass of customer that has logged in to get customer_id to put in cart and receipt
        OracleConnection connect;
        public CustomerOptionform()
        {
            InitializeComponent();
        }
        public CustomerOptionform(string pass)
        {
            InitializeComponent();
            passForCust = pass;
        }

        private void CreateCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartPage caObj = new CartPage(passForCust);
            caObj.ShowDialog();
        }

        private void ShopHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptPage rcObj = new ReceiptPage(1, passForCust);
            rcObj.ShowDialog();
        }

        private void CustomerOptionform_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);

        }
    }
}
