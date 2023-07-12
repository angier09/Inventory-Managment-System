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
    public partial class ManageProducts : Form
    {
        OracleConnection con;
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopCRUD sObj = new ShopCRUD();
            sObj.ShowDialog();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219052;PASSWORD=abc";
            con = new OracleConnection(conStr);
        }

        private void suppId_Click(object sender, EventArgs e)
        {
            Grid();
        }
        private void Grid()
        {
            this.Hide();
            ProductGrid pObj = new ProductGrid();
            pObj.ShowDialog();
        }

        private void expiryPro_Click(object sender, EventArgs e)
        {
            ExpiryGrid();
        }

        private void ExpiryGrid()
        {
            this.Hide();
            ExpiryProdGrid eObj = new ExpiryProdGrid();
            eObj.ShowDialog();
        }

        private void chkStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            lowStockGrid lObj = new lowStockGrid();
            lObj.ShowDialog();
        }
    }
}
