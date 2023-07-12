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
    public partial class AdminLogInPg : Form
    {
        OracleConnection connect;
        public AdminLogInPg()
        {
            InitializeComponent();
        }

        private void extAdmin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bckAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RolePage rpObj = new RolePage();
            rpObj.ShowDialog();
        }

        private void NxtAdmin_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            if (AdminPassWord.Text == string.Empty || AdminEmail.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                connect.Open();

                cmd = new OracleCommand("SELECT admin_email,admin_pass FROM Admin WHERE admin_email=\'" + AdminEmail.Text.ToString() + "\' AND admin_pass=\'" + AdminPassWord.Text.ToString() + "\'", connect);
                SetValueForEmail = AdminEmail.Text;
                SetValueForPassWrd = AdminPassWord.Text;

                OracleDataReader r;
                r = cmd.ExecuteReader();
                string[] fields = new string[3];

                if (r.Read() && r.GetValue(0).ToString() == AdminEmail.Text && r.GetValue(1).ToString() == AdminPassWord.Text)
                {
                    this.Hide();
                    AdminCRUD aCObj = new AdminCRUD();
                    aCObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID! email/password");

                }
                connect.Close();
            }

        }

        public static string SetValueForEmail = "";
        public static string SetValueForPassWrd = "";

        private void AdminLogInPg_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
