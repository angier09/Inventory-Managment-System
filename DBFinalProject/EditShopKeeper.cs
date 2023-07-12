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
    public partial class EditShopKeeper : Form
    {
        OracleConnection connect;
        public EditShopKeeper()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            adminShopkeeper aSObj = new adminShopkeeper();
            aSObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void EditShopKeeper_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            MessageBox.Show("Enter ID of Shopkeeper to update data"); 
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            OracleCommand nCmd = new OracleCommand();
            connect.Open();
            nCmd = new OracleCommand("UPDATE Shopkeeper SET shop_name = :shopName, shop_email = :shopEmail, shop_pass = :shopPass, cnic = :cnic, contact = :contact, salary = :salary, shop_loc = :shopLoc WHERE shop_id = :shopId", connect);
            nCmd.Parameters.Add("shopName", shopName.Text);
            nCmd.Parameters.Add("shopEmail", shopEmail.Text);
            nCmd.Parameters.Add("shopPass", shopPass.Text);
            nCmd.Parameters.Add("cnic", shopCnic.Text);
            nCmd.Parameters.Add("contact", shopContact.Text);
            nCmd.Parameters.Add("salary", shopSal.Text);
            nCmd.Parameters.Add("shopLoc", shop_Loc.Text);
            nCmd.Parameters.Add("shopId", shopID.Text);
            int rows = nCmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Data Updated Successfully");
                this.Hide();
                adminShopkeeper aSObj = new adminShopkeeper();
                aSObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data Cannot be Updated");  
            }

            connect.Close();
        }

    }
}
