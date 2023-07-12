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
    public partial class SupplierAddProduct : Form
    {
        OracleConnection connect;
        public SupplierAddProduct()
        {
            InitializeComponent();
        }

        private void SupplierAddProduct_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
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
                nCmd = new OracleCommand("INSERT INTO Products_Supplier VALUES(:product_id, :product_name, :product_manufacturer, :product_category, :product_price, :expiry_date, :stock, :supplierId)", connect);

                nCmd.Parameters.Add(new OracleParameter("product_id", txtID.Text));
                nCmd.Parameters.Add(new OracleParameter("product_name", textName.Text));
                nCmd.Parameters.Add(new OracleParameter("product_manufacturer", txtManu.Text));
                nCmd.Parameters.Add(new OracleParameter("product_category", txtCat.Text));
                nCmd.Parameters.Add(new OracleParameter("product_price", productPrice.Text));
                nCmd.Parameters.Add(new OracleParameter("expiry_date", dateTimePicker1.Value));
                nCmd.Parameters.Add(new OracleParameter("stock", txtStock.Text));
                nCmd.Parameters.Add(new OracleParameter("supplierId", txtSuppId.Text));

                connect.Open();

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                    this.Hide();
                    SupplierCRUD sCObj = new SupplierCRUD();
                    sCObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Insertion Failed");

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
    }
}
