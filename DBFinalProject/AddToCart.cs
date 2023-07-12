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
    public partial class AddToCart : Form
    {
        public string passForCust; //sending pass of customer that has logged in to get customer_id to put in cart and receipt
        OracleConnection connect;
        public AddToCart()
        {
            InitializeComponent();
        }

        public AddToCart(string pass)
        {
            InitializeComponent();
            passForCust = pass;
        }

        private void AddToCart_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            updateGridForInventory();
        }
        private void updateGridForInventory()
        {
            OracleCommand getProducts = new OracleCommand();
            connect.Open();
            getProducts = new OracleCommand("SELECT * FROM INVENTORY_SHOP", connect);
            OracleDataReader r = getProducts.ExecuteReader();
            DataTable prodTable = new DataTable();
            prodTable.Load(r);
            Inventory.DataSource = prodTable;
            connect.Close();
        }

        private void newPro_Click(object sender, EventArgs e)
        {
            OracleCommand nCmd;
            OracleCommand cmd;
            if (ProductID.Text == string.Empty)
            {
                MessageBox.Show("Please! Enter ID to Add Product");
            }
            else
            {
                connect.Open();
                cmd = new OracleCommand("SELECT customer_id FROM Customers_Shop WHERE customer_pass='" + passForCust + "'", connect);

                OracleDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    string customerId = r.GetValue(0).ToString();
                    nCmd = new OracleCommand("INSERT INTO Cart (customer_id, product_id, product_name, quantity, cost) SELECT :customerId, product_id, product_name, :p_quantity, product_price FROM Inventory_Shop WHERE product_id = :productId", connect);
                    nCmd.Parameters.Add("customerId", customerId);
                    nCmd.Parameters.Add("p_quantity", quantityPro.Value);
                    nCmd.Parameters.Add("productId", ProductID.Text);

                    int rows = nCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Product has been added to cart");
                        //OracleCommand sCmd = new OracleCommand("UPDATE Inventory_Shop SET quantity=quantity - :p_quantity WHERE product_id=:productId");
                        //sCmd.Parameters.Add("p_quantity", quantityPro.Value);
                        //sCmd.Parameters.Add("productId", ProductID.Text);

                        //int rows1 = sCmd.ExecuteNonQuery();
                        //if (rows1 > 0)
                        //{
                        //    MessageBox.Show("Inventory has been updated");
                        //    updateGridForInventory();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Inventory couldn't be updated");
                        //    updateGridForInventory();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Product couldn't be added to cart");
                    }
                }
                else
                {
                    MessageBox.Show("Customer ID error");
                }
            }

            connect.Close();
        }


        private void cartPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartPage caObj = new CartPage();
            caObj.ShowDialog();
        }
    }
}
