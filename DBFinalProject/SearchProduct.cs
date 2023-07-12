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
    public partial class SearchProduct : Form
    {
        OracleConnection con;

        public SearchProduct()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            ShopCRUD sCObj = new ShopCRUD();
            sCObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            OracleCommand sCmd = new OracleCommand();
            if(txtID.Text==string.Empty || ProName.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in boxes");
            }
            else
            {
                con.Open();
                sCmd = new OracleCommand("SELECT product_id,product_name FROM Inventory_Shop WHERE product_id =: ID AND product_name=:Name", con);
                sCmd.Parameters.Add(new OracleParameter("ID", txtID.Text));
                sCmd.Parameters.Add(new OracleParameter("Name", ProName.Text));

                OracleDataReader r = sCmd.ExecuteReader();
                string[] feilds = new string[3];
                if (r.Read() && r.GetValue(0).ToString() == txtID.Text && r.GetValue(1).ToString() == ProName.Text)
                {
                    MessageBox.Show("Product Found");
                    this.Hide();
                    UpdateProduct upObj = new UpdateProduct();
                    upObj.ShowDialog();
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

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
