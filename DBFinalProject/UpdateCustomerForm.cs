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
    public partial class UpdateCustomerForm : Form
    {
        OracleConnection connect;
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminCustomer aObj = new adminCustomer();
            aObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (custID.Text == string.Empty || custName.Text == string.Empty || custEmail.Text == string.Empty || custPass.Text == string.Empty || registerDate.Text == string.Empty || custCnic.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
            else
            {
                OracleCommand nCmd = new OracleCommand();
                connect.Open();
                nCmd = new OracleCommand("UPDATE Customers_Shop SET customer_name = :customerName, customer_email = :customerEmail, customer_pass = :customerPass, cnic = :customerCnic, register_date = :registerDate WHERE customer_id = :customerId", connect);
                nCmd.Parameters.Add("customerName", custName.Text);
                nCmd.Parameters.Add("customerEmail", custEmail.Text);
                nCmd.Parameters.Add("customerPass", custPass.Text);
                nCmd.Parameters.Add("customerCnic", custCnic.Text);
                nCmd.Parameters.Add("registerDate", registerDate.Value);
                nCmd.Parameters.Add("customerId", custID.Text);

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Customer has been inserted");
                    this.Hide();
                    adminCustomer aObj = new adminCustomer();
                    aObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }
                connect.Close();
            }
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
