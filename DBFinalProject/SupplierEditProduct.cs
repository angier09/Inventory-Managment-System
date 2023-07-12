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
    public partial class SupplierEditProduct : Form
    {
        OracleConnection connect;
        public SupplierEditProduct()
        {
            InitializeComponent();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            OracleCommand nCmd = new OracleCommand();
            if (txtSuppId.Text == string.Empty || textName.Text == string.Empty || txtID.Text == string.Empty || txtManu.Text == string.Empty || txtCat.Text == string.Empty || txtStock.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                connect.Open();
                nCmd = new OracleCommand("UPDATE Products_Supplier SET product_id=:product_id, product_name=:product_name, product_manufacturer=:product_manufacturer, product_category=:product_category, product_price=:product_price, expiry_date=:expiry_date, stock=:stock, supplier_ID=:supplierid WHERE product_id=:product_id", connect);

                nCmd.Parameters.Add(new OracleParameter("product_id", txtID.Text));                
                nCmd.Parameters.Add(new OracleParameter("product_name", textName.Text));
                nCmd.Parameters.Add(new OracleParameter("product_manufacturer", txtManu.Text));
                nCmd.Parameters.Add(new OracleParameter("product_category", txtCat.Text));
                nCmd.Parameters.Add(new OracleParameter("product_price", productPrice.Text));
                nCmd.Parameters.Add(new OracleParameter("expiry_date", dateTimePicker1.Value));
                nCmd.Parameters.Add(new OracleParameter("stock", txtStock.Text));
                nCmd.Parameters.Add(new OracleParameter("supplierId", txtSuppId.Text));

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    this.Hide();
                    SupplierCRUD sCObj = new SupplierCRUD();
                    sCObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data Cannot be Updated");
                }

                connect.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierCRUD sCObj = new SupplierCRUD();
            sCObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SupplierEditProduct_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
