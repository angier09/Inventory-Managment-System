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
    public partial class CreateSupplierForm : Form
    {
        OracleConnection connect;
        public CreateSupplierForm()
        {
            InitializeComponent();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void enter_Click(object sender, EventArgs e)
        {
            OracleCommand nCmd = new OracleCommand();
            if (suppID.Text == string.Empty || suppName.Text == string.Empty || suppEmail.Text == string.Empty || suppPass.Text == string.Empty || suppContact.Text == string.Empty || suppCnic.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
            else
            {
                nCmd = new OracleCommand("INSERT INTO Supplier (supplier_id, supplier_name, supplier_email, supplier_pass, supplier_contact, cnic) VALUES (:supplier_id, :supplier_name, :supplier_email, :supplier_pass, :contact, :cnic)", connect);

                nCmd.Parameters.Add(new OracleParameter("supplier_id", suppID.Text));
                nCmd.Parameters.Add(new OracleParameter("supplier_name", supplierName.Text));
                nCmd.Parameters.Add(new OracleParameter("supplier_email", supplierEmail.Text));
                nCmd.Parameters.Add(new OracleParameter("supplier_pass", supplierPass.Text));
                nCmd.Parameters.Add(new OracleParameter("contact", suppContact.Text));
                nCmd.Parameters.Add(new OracleParameter("cnic", suppCnic.Text));

                connect.Open();

                int rows = nCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Supplier has been created");
                    this.Hide();
                    adminSupplier aObj = new adminSupplier();
                    aObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Insertion Failed");

                }
                connect.Close();
            }           
            
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Discarded");
            this.Hide();
            adminSupplier aObj = new adminSupplier();
            aObj.ShowDialog();
        }

        private void CreateSupplierForm_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
        }
    }
}
