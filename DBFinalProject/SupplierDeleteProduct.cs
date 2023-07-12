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
    public partial class SupplierDeleteProduct : Form
    {
        OracleConnection connect;
        public SupplierDeleteProduct()
        {
            InitializeComponent();
        }

        private void SupplierDeleteProduct_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
        private void ENTER_Click(object sender, EventArgs e)
        {
            OracleCommand dCmd = new OracleCommand();
            if (productID.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in ID");
            }
            else
            {
                connect.Open();
                dCmd = new OracleCommand("DELETE FROM Products_Supplier WHERE product_ID=:ID", connect);
                dCmd.Parameters.Add(new OracleParameter("ID", productID.Text));

                int rows = dCmd.ExecuteNonQuery();
                if(rows>0)
                {
                    MessageBox.Show("Product Deleted");
                    this.Hide();
                    SupplierCRUD sCObj = new SupplierCRUD();
                    sCObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Product Couldn't be deleted");
                }
                connect.Close();
            }
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void DISCARD_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierCRUD sCObj = new SupplierCRUD();
            sCObj.ShowDialog();
        }
    }
}
