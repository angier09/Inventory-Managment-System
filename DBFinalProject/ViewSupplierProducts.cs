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
    public partial class ViewSupplierProducts : Form
    {
        OracleConnection connect;
        public ViewSupplierProducts()
        {
            InitializeComponent();
        }

        private void updateGridForPSupp()
        {
            OracleCommand getProducts = new OracleCommand();
            connect.Open();
            getProducts = new OracleCommand("SELECT * FROM Products_Supplier", connect);
            OracleDataReader r = getProducts.ExecuteReader();
            DataTable prodTable = new DataTable();
            prodTable.Load(r);
            suppGrid.DataSource = prodTable;
            connect.Close();
        }

        private void ViewSupplierProducts_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            updateGridForPSupp();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierCRUD sCObj = new SupplierCRUD();
            sCObj.ShowDialog();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
