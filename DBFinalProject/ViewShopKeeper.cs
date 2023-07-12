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
    public partial class ViewShopKeeper : Form
    {
        OracleConnection connect;
        public ViewShopKeeper()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminShopkeeper aSObj = new adminShopkeeper();
            aSObj.ShowDialog();
        }

        private void updateGrid()
        {
            connect.Open();
            OracleCommand getEmps = connect.CreateCommand();
            getEmps.CommandText = "SELECT * FROM Shopkeeper";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            shopGrid.DataSource = empDT;

            connect.Close();
        }


        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ViewShopKeeper_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=F219105;PASSWORD=123";
            connect = new OracleConnection(conStr);
            updateGrid();
        }
    }
}
