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
    public partial class ShopkeeperPg : Form
    {
        OracleConnection con;
        public ShopkeeperPg()
        {
            InitializeComponent();
        }

        private void ShopKeeperPg_load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219052;PASSWORD=abc";
            con = new OracleConnection(conStr);
            
        }

        private void extShop_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bckShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            RolePage rpObj = new RolePage();
            rpObj.ShowDialog();
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForEmail = "";
        public static string SetValueForPassWrd = "";

        private void NxtShop_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            
            if (ShopEmail.Text == string.Empty || ShopPassWord.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                con.Open();
                cmd = new OracleCommand("SELECT shop_email,shop_pass FROM Shopkeeper WHERE shop_email=:email AND shop_pass=:passWrd", con);
                cmd.Parameters.Add(new OracleParameter("email", ShopEmail.Text));
                cmd.Parameters.Add(new OracleParameter("passWrd", ShopPassWord.Text));

                // here am storing the value so can access it in form
                SetValueForEmail = ShopEmail.Text;
                SetValueForPassWrd = ShopPassWord.Text;

                OracleDataReader r;
                    r = cmd.ExecuteReader();
                string[] feilds = new string[3];

                if (r.Read() && r.GetValue(0).ToString() == ShopEmail.Text && r.GetValue(1).ToString() == ShopPassWord.Text)
                {
                    this.Hide();
                    ShopCRUD sCObj = new ShopCRUD();
                    sCObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID! email/password");

                }
                con.Close();
            }

        }

        private void ShopEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShopkeeperPg_Load_1(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            con = new OracleConnection(conStr);
          
        }
    }
}
