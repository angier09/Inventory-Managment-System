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
    public partial class ProductGrid : Form
    {
        OracleConnection con;
        public ProductGrid()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ProductGrid_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);

            OracleCommand getProducts = new OracleCommand();
            con.Open();
            getProducts = new OracleCommand("SELECT * FROM INVENTORY_SHOP", con);
            OracleDataReader r = getProducts.ExecuteReader();
            DataTable prodTable = new DataTable();
            prodTable.Load(r);
            dataGridView1.DataSource = prodTable;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts mObj = new ManageProducts();
            mObj.ShowDialog();
        }
    }
}
