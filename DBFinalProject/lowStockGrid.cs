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
    public partial class lowStockGrid : Form
    {
        OracleConnection con;
        public lowStockGrid()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lowStockGrid_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);
            lowStock();
        }

        private void lowStock()
        {
            con.Open();
            OracleCommand getExpiry = new OracleCommand();

            getExpiry = new OracleCommand("SELECT * FROM Inventory_Shop WHERE stock < 250", con);

            OracleDataReader r = getExpiry.ExecuteReader();

            DataTable prodTable = new DataTable();
            prodTable.Load(r);
            stockGrid.DataSource = prodTable;
            con.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts sObj = new ManageProducts();
            sObj.ShowDialog();
        }
    }
}
