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
    public partial class CreateShopKeeper : Form
    {
        OracleConnection connect;
        public CreateShopKeeper()
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

        private void CreateShopKeeper_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            OracleCommand nCmd = new OracleCommand();
            if (shopID.Text == string.Empty || shopName.Text == string.Empty || shopEmail.Text == string.Empty || shopPass.Text == string.Empty || shopSal.Text == string.Empty || shopContact.Text == string.Empty || shopCnic.Text == string.Empty || shop_Loc.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                nCmd = new OracleCommand("INSERT INTO Shopkeeper (shop_id, shop_name, shop_email, shop_pass, salary, contact, cnic, shop_loc) VALUES(:shop_id, :shop_name, :shop_email, :shop_pass, :salary, :contact, :cnic, :shop_loc)", connect);

                nCmd.Parameters.Add(new OracleParameter("shop_id", shopID.Text));
                nCmd.Parameters.Add(new OracleParameter("shop_name", shopName.Text));
                nCmd.Parameters.Add(new OracleParameter("shop_email", shopEmail.Text));
                nCmd.Parameters.Add(new OracleParameter("shop_pass", shopPass.Text));
                nCmd.Parameters.Add(new OracleParameter("salary", shopSal.Text));
                nCmd.Parameters.Add(new OracleParameter("contact", shopContact.Text));
                nCmd.Parameters.Add(new OracleParameter("cnic", shopCnic.Text));
                nCmd.Parameters.Add(new OracleParameter("shop_loc", shop_Loc.Text));

                connect.Open();

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                    this.Hide();
                    adminShopkeeper aSObj = new adminShopkeeper();
                    aSObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Insertion Failed");

                }
                connect.Close();
            }
        }
    }

}
