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
    public partial class DeleteShopKeeper : Form
    {
        OracleConnection connect;
        public DeleteShopKeeper()
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

        private void DeleteShopKeeper_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }

        private void Enter_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            if (shopID.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in at least ID");
            }
            else
            {
                connect.Open();
                cmd = new OracleCommand("DELETE FROM Shopkeeper WHERE shop_id = :shopId", connect);
                cmd.Parameters.Add(":shopId", shopID.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Shopkeeper has been deleted");
                    this.Hide();
                    adminShopkeeper aSObj = new adminShopkeeper();
                    aSObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data couldn't be deleted");
                }
                connect.Close();
            }
        }
    }
}
