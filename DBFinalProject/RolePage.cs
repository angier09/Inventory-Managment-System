using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFinalProject
{
    public partial class RolePage : Form
    {
        public RolePage()
        {
            InitializeComponent();
        }

        private void ShopkeeperRdio_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            ShopkeeperPg sObj = new ShopkeeperPg();
            sObj.ShowDialog();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogoPage lpObj = new LogoPage();
            lpObj.ShowDialog();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ADMINradio_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogInPg aObj = new AdminLogInPg();
            aObj.ShowDialog();
        }

        private void CustomerRdio_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogIN cObj = new CustomerLogIN();
            cObj.ShowDialog();
        }

        private void SupplierRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            SupplierLogIn sObj = new SupplierLogIn();
            sObj.ShowDialog();
        }
    }
}
