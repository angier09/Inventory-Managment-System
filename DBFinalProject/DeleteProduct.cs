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
    public partial class DeleteProduct : Form
    {
        OracleConnection con;

        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void DISCARD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            ShopCRUD sCObj = new ShopCRUD();
            sCObj.ShowDialog();
        }
        public static string SetValueForID = "";
        public static string SetValueForNAME = "";
        public static string SetValueForCategory = "";
        private void ENTER_Click(object sender, EventArgs e)
        {
             
            OracleCommand dCmd = new OracleCommand();
            if (productID.Text == string.Empty || NamePro.Text == string.Empty || ProCatog.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in boxes");
            }
            else
            {
                con.Open();
                dCmd = new OracleCommand("SELECT product_id,product_name,product_category FROM Inventory_Shop WHERE product_id =: ID AND product_name=:Name AND product_category=: Category", con);
                dCmd.Parameters.Add(new OracleParameter("ID", productID.Text));
                dCmd.Parameters.Add(new OracleParameter("Name", NamePro.Text));
                dCmd.Parameters.Add(new OracleParameter("Category", ProCatog.Text));

                OracleDataReader r = dCmd.ExecuteReader();
                string[] feilds = new string[3];
                if (r.Read() && r.GetValue(0).ToString() == productID.Text && r.GetValue(1).ToString() == NamePro.Text && r.GetValue(2).ToString() == ProCatog.Text)
                {

                    MessageBox.Show("Product Found");
                    SetValueForID = productID.Text;
                    SetValueForNAME = NamePro.Text;
                    SetValueForCategory = ProCatog.Text;
                    deleteShop(SetValueForID, SetValueForNAME, SetValueForCategory); //function called to delete from database
                    this.Hide();
                    ShopCRUD sCObj = new ShopCRUD();
                    sCObj.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Product Not Found");
                    this.Hide();
                    ShopCRUD sCObj = new ShopCRUD();
                    sCObj.ShowDialog();
                }
                con.Close();
            }
        }

        private void deleteShop(string productID, string NamePro,string ProCatog)
        {
            OracleCommand cmd = new OracleCommand();
            cmd = new OracleCommand("DELETE FROM Inventory_SHOP WHERE product_id=:product_id", con);
            cmd.Parameters.Add(new OracleParameter("product_id", productID));
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Data Deleted Successfully");

            }
            else
            {
                MessageBox.Show("Deletion Fail");

            }

        }
        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);
        }
    }
}
