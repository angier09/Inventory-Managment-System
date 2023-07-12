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
    public partial class DeleteSupplierForm : Form
    {
        OracleConnection connect;
        public DeleteSupplierForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Information Discarded");
            this.Hide();
            adminSupplier aObj = new adminSupplier();
            aObj.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            if (suppID.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in at least ID");
            }
            else
            {
                connect.Open();
                cmd = new OracleCommand("DELETE FROM Supplier WHERE supplier_id = :suppID", connect);
                cmd.Parameters.Add(":suppID", suppID.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Supplier has been deleted");
                    this.Hide();
                    adminSupplier aObj = new adminSupplier();
                    aObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data couldn't be deleted");
                }
                connect.Close();
            }
            
            

        }

        private void DeleteSupplierForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
