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
    public partial class CustomerLogIN : Form
    {
        OracleConnection connect;
        public CustomerLogIN()
        {
            InitializeComponent();
        }

        private void extCust_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bckCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            RolePage rObj = new RolePage();
            rObj.ShowDialog();
        }

        private void NxtCust_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            if (PassCustomer.Text == string.Empty || EmailCustomer.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                connect.Open();

                cmd = new OracleCommand("SELECT customer_email,customer_pass FROM Customers_Shop WHERE customer_email=\'" + EmailCustomer.Text.ToString() + "\' AND customer_pass=\'" + PassCustomer.Text.ToString() + "\'", connect);

                OracleDataReader r;
                r = cmd.ExecuteReader();
                string[] fields = new string[3];

                if (r.Read() && r.GetValue(0).ToString() == EmailCustomer.Text && r.GetValue(1).ToString() == PassCustomer.Text)
                {
                    this.Hide();
                    CustomerOptionform cOObj = new CustomerOptionform(PassCustomer.Text.ToString()); //sending pass of customer that has logged in to get customer_id to put in cart and receipt
                    cOObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID! email/password");

                }
                connect.Close();
            }

        }

        private void CustomerLogIN_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
