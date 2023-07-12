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
    public partial class SupplierLogIn : Form
    {
        OracleConnection connect;
        public SupplierLogIn()
        {
            InitializeComponent();
        }

        private void bckSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RolePage rpObj = new RolePage();
            rpObj.ShowDialog();
        }
        public static string SetValueForEmail = "";
        public static string SetValueForPassWrd = "";

        private void extSupp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SupplierLogIn_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }

        private void NxtSupp_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            if (EmailSupp.Text == string.Empty || PassSupp.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                connect.Open();
                cmd = new OracleCommand("SELECT supplier_email,supplier_pass FROM Supplier WHERE supplier_email=:email AND supplier_pass=:passWrd", connect);
                cmd.Parameters.Add(new OracleParameter("email", EmailSupp.Text));
                cmd.Parameters.Add(new OracleParameter("passWrd", PassSupp.Text));

                // here am storing the value so can access it in form
                SetValueForEmail = EmailSupp.Text;
                SetValueForPassWrd = PassSupp.Text;

                OracleDataReader r;
                r = cmd.ExecuteReader();
                string[] feilds = new string[3];

                if (r.Read() && r.GetValue(0).ToString() == EmailSupp.Text && r.GetValue(1).ToString() == PassSupp.Text)
                {
                    this.Hide();
                    SupplierCRUD sCObj = new SupplierCRUD();
                    sCObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID! email/password");

                }
                connect.Close();
            }
        }
    }
}
