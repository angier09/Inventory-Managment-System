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
    public partial class UpdateSupplierForm : Form
    {
        OracleConnection connect;
        public UpdateSupplierForm()
        {
            InitializeComponent();
        }

        private void Discard_Click(object sender, EventArgs e)
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

        private void enter_Click(object sender, EventArgs e)
        {
            if (suppID.Text == string.Empty || suppName.Text == string.Empty || suppEmail.Text == string.Empty || suppPass.Text == string.Empty || suppContact.Text == string.Empty || suppCnic.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
            else
            {
                OracleCommand nCmd = new OracleCommand();
                connect.Open();
                nCmd = new OracleCommand("UPDATE Supplier SET supplier_name = :supplierName, supplier_email = :supplierEmail, supplier_pass = :supplierPass, cnic = :cnic, supplier_contact = :contact  WHERE supplier_id = :supplierId", connect);
                nCmd.Parameters.Add("supplierName", suppName.Text);
                nCmd.Parameters.Add("supplierEmail", suppEmail.Text);
                nCmd.Parameters.Add("supplierPass", suppPass.Text);
                nCmd.Parameters.Add("cnic", suppCnic.Text);
                nCmd.Parameters.Add("contact", suppContact.Text);
                nCmd.Parameters.Add("supplierId", suppID.Text);

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data of Supplier Updated Successfully");
                    this.Hide();
                    adminSupplier aSObj = new adminSupplier();
                    aSObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data Cannot be Updated");
                }

                connect.Close();
            }

        }

        private void UpdateSupplierForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
