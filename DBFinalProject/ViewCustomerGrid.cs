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
    public partial class ViewCustomerGrid : Form
    {
        OracleConnection connect;
        public ViewCustomerGrid()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminCustomer aObj = new adminCustomer();
            aObj.ShowDialog();
        }

        private void ViewCustomerGrid_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            updateGridForCustomers();
        }
        private void updateGridForCustomers()
        {
            connect.Open();
            OracleCommand getEmps = connect.CreateCommand();
            getEmps.CommandText = "SELECT * FROM Customers_Shop ORDER BY customer_id ASC";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            custDetails.DataSource = empDT;

            connect.Close();
        }
    }
}
