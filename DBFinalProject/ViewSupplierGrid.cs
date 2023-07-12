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
    public partial class ViewSupplierGrid : Form
    {
        OracleConnection connect;
        public ViewSupplierGrid()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminSupplier aObj = new adminSupplier();
            aObj.ShowDialog();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }


        private void updateGridForSupp()
        {
            connect.Open();
            OracleCommand getEmps = connect.CreateCommand();
            getEmps.CommandText = "SELECT * FROM Supplier";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            suppGrid.DataSource = empDT;

            connect.Close();
        }

        private void ViewSupplierGrid_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            updateGridForSupp();
        }
    }
}
