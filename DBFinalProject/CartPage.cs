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
    public partial class CartPage : Form
    {
        public string passForCust;  //sending pass of customer that has logged in to get customer_id to put in cart and receipt
        OracleConnection connect;
        public CartPage()
        {
            InitializeComponent();
        }

        public CartPage(string pass)
        {
            InitializeComponent();
            passForCust = pass;
        }

        private void CartPage_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            updateGridForCart();
        }
        private void updateGridForCart()
        {
            connect.Open();
            OracleCommand getEmps = connect.CreateCommand();
            getEmps.CommandText = "SELECT * FROM Cart";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Cart.DataSource = empDT;

            connect.Close();
        }

        private void newPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddToCart aDObj = new AddToCart(passForCust);
            aDObj.ShowDialog();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptPage rDObj = new ReceiptPage();
            rDObj.ShowDialog();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            OracleCommand nCmd;
            if (ProductID.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in ID");
            }
            else
            {
                connect.Open();
                nCmd = new OracleCommand("DELETE FROM Cart WHERE product_id=:productID", connect);
                nCmd.Parameters.Add(new OracleParameter("productID", ProductID.Text));

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Product has been deleted");
                    connect.Close();
                    updateGridForCart();
                }
                else
                {
                    MessageBox.Show("Product couldn't be deleted");
                }
                connect.Close();
            }
        }

        private void bckCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOptionform cO = new CustomerOptionform(passForCust);
            cO.ShowDialog();
        }
    }
}
