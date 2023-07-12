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
    public partial class UpdateProduct : Form
    {
        OracleConnection con;

        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            ShopCRUD sCObj = new ShopCRUD();
            sCObj.ShowDialog();

        }

        private void NEXT_Click(object sender, EventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            ShopCRUD sCObj = new ShopCRUD();
            sCObj.ShowDialog();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void NEXT_Click_1(object sender, EventArgs e)
        {
            OracleCommand nCmd = new OracleCommand();
            if (txtSuppId.Text == string.Empty || textName.Text == string.Empty || txtID.Text == string.Empty || txtManu.Text == string.Empty || txtCat.Text == string.Empty || txtStock.Text == string.Empty || txtShopID.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                con.Open();
                nCmd = new OracleCommand("UPDATE Inventory_Shop SET product_id=:product_id, shop_id=:shop_id, product_name=:product_name, product_manufacturer=:product_manufacturer, product_category=:product_category, product_price=:product_price, expiry_date=:expiry_date, stock=:stock, supplierid=:supplierid WHERE product_id=:product_id", con);

                nCmd.Parameters.Add(new OracleParameter("product_id", txtID.Text));
                nCmd.Parameters.Add(new OracleParameter("shop_id", txtShopID.Text));
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
                   ShopCRUD sCObj = new ShopCRUD();
                   sCObj.ShowDialog();
                }
                else
                {
                   MessageBox.Show("Data Cannot be Update");
                   this.Hide();
                   ShopCRUD sCObj = new ShopCRUD();
                   sCObj.ShowDialog();
                }

                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
