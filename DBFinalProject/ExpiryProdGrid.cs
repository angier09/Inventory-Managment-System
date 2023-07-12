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
    public partial class ExpiryProdGrid : Form
    {
        OracleConnection con;

        public ExpiryProdGrid()
        {
            InitializeComponent();
        }

        private void ExpiryProdGrid_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);

            displayExpiry();
        }

        private void displayExpiry()
        {
            con.Open();
            OracleCommand getExpiry = new OracleCommand();
           
            getExpiry = new OracleCommand("SELECT * FROM Inventory_Shop WHERE expiry_date <= TO_DATE(TO_CHAR(sysdate, 'MM/DD/YYYY'), 'MM/DD/YYYY')", con);
            
            OracleDataReader r = getExpiry.ExecuteReader();

            DataTable prodTable = new DataTable();
            prodTable.Load(r);
            expiryGrid.DataSource = prodTable;
            con.Close();
        }
        private void expiryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts mObj = new ManageProducts();
            mObj.ShowDialog();
        }
    }
}
