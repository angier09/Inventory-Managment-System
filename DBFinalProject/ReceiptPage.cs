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
using Oracle.ManagedDataAccess.Types;

namespace DBFinalProject
{
    public partial class ReceiptPage : Form
    {
        OracleConnection connect;
        public int flag = 0;    //if we are checking history or showing what's in the cart
        public string passForCust = null; //sending pass of customer that has logged in to get customer_id to put in cart and receipt
        public ReceiptPage()
        {
            InitializeComponent();
        }

        public ReceiptPage(int f, string pass)
        {
            InitializeComponent();
            flag = f;
            passForCust = pass;
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
            Receipt.DataSource = empDT;

            OracleCommand nCmd = new OracleCommand();
            nCmd = new OracleCommand("DECLARE total_cost NUMBER(30); BEGIN total_cost := 0; FOR product_rec IN (SELECT product_id, quantity, cost FROM Cart) LOOP total_cost := total_cost + (product_rec.quantity * product_rec.cost); END LOOP; :totalCostOut := total_cost; END;", connect);
            nCmd.Parameters.Add("totalCostOut", OracleDbType.Decimal, ParameterDirection.Output);

            nCmd.ExecuteNonQuery();

            OracleDecimal totalCostOracle = (OracleDecimal)nCmd.Parameters["totalCostOut"].Value;
            decimal totalCost = totalCostOracle.IsNull ? 0 : totalCostOracle.Value;
            cost.Text = "Rs: " + totalCost.ToString("N2"); // format the decimal as currency with 2 decimal places and display in label


            connect.Close();


        }

        private void updateReceipt()
        {
            connect.Open();

            OracleCommand selectCmd = new OracleCommand("SELECT * FROM Cart", connect);

            OracleDataReader reader = selectCmd.ExecuteReader();

            OracleCommand insertCmd = new OracleCommand("INSERT INTO Receipt (unique_key, receipt_id, customer_id, product_id, product_name, quantity, cost) VALUES (:uniqueKey, :receiptId, :customerId, :productId, :productName, :quantity, :cost)", connect);

            while (reader.Read())
            {
                insertCmd.Parameters.Clear();
                insertCmd.Parameters.Add("uniqueKey", OracleDbType.Int32).Value = getUniqueKey();
                insertCmd.Parameters.Add("receiptId", OracleDbType.Int32).Value = getReceiptId();
                insertCmd.Parameters.Add("customerId", OracleDbType.Int32).Value = reader.GetInt32(reader.GetOrdinal("customer_id"));
                insertCmd.Parameters.Add("productId", OracleDbType.Int32).Value = reader.GetInt32(reader.GetOrdinal("product_id"));
                insertCmd.Parameters.Add("productName", OracleDbType.Varchar2, 200).Value = reader.GetString(reader.GetOrdinal("product_name"));
                insertCmd.Parameters.Add("quantity", OracleDbType.Int32).Value = reader.GetInt32(reader.GetOrdinal("quantity"));
                insertCmd.Parameters.Add("cost", OracleDbType.Decimal).Value = reader.GetDecimal(reader.GetOrdinal("cost"));

                insertCmd.ExecuteNonQuery();
            }

            reader.Close();

            MessageBox.Show("Your receipt has been generated and is stored");

            OracleCommand delShop = new OracleCommand("DELETE FROM CART", connect);
            delShop.ExecuteNonQuery();

            connect.Close();
        }

        //Method to generate unique key
        private int getUniqueKey()
        {
            //Generate a random number
            Random rnd = new Random();
            return rnd.Next(100000, 999999);
        }

        //Method to generate receipt id
        private int getReceiptId()
        {
            //Generate a random number
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }
        private void updateGridForReceipt()
        {
            connect.Open();
            OracleCommand getEmps = connect.CreateCommand();
            getEmps.CommandText = "SELECT * FROM ReceiptView WHERE customer_id IN(Select customer_id FROM Customers_Shop WHERE customer_pass=\'" + passForCust + "\')"; //calling a View so as to not show Unique key of Receipt Table
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            Receipt.DataSource = empDT;

            connect.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if (flag == 0)  //if cart is there
            {
                updateReceipt();
            }
            this.Hide();
            LogoPage loObj = new LogoPage();
            loObj.ShowDialog();
        }

        private void ReceiptPage_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            if (flag == 0)  //if cart is there
            {
                updateGridForCart();
            }
            else
            {
                updateGridForReceipt();
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

