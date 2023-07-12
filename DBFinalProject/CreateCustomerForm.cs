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
    public partial class CreateCustomerForm : Form
    {
        OracleConnection connect;
        public CreateCustomerForm()
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
                OracleCommand nCmd;
                nCmd = new OracleCommand("INSERT INTO Customers_Shop VALUES (:customerId, :customerName, :customerPass, :customerEmail, :customerCnic, :registerDate)", connect);
                nCmd.Parameters.Add(new OracleParameter("customerId", custID.Text));
                nCmd.Parameters.Add(new OracleParameter("customerName", custName.Text));
                nCmd.Parameters.Add(new OracleParameter("customerPass", custPass.Text));
                nCmd.Parameters.Add(new OracleParameter("customerEmail", custEmail.Text));
                nCmd.Parameters.Add(new OracleParameter("customerCnic", custCnic.Text));
                nCmd.Parameters.Add(new OracleParameter("registerDate", registerDate.Value));
                

                connect.Open();

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Customer Created");
                    this.Hide();
                    adminCustomer aObj = new adminCustomer();
                    aObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Customer couldn't be created");
                }
                connect.Close();
            }
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
