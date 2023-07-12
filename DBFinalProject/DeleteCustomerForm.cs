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
    public partial class DeleteCustomerForm : Form
    {
        OracleConnection connect;
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
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
            OracleCommand cmd = new OracleCommand();
            if (custID.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in at least ID");
            }
            else
            {
                connect.Open();
                cmd = new OracleCommand("DELETE FROM Customers_shop WHERE customer_id = :custID", connect);
                cmd.Parameters.Add(":custID", custID.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Customer has been deleted");
                    this.Hide();
                    adminCustomer aObj = new adminCustomer();
                    aObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data couldn't be deleted");
                }
                connect.Close();
            }
            
        }

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
