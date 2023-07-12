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
    public partial class adminShopkeeper : Form
    {
        public adminShopkeeper()
        {
            InitializeComponent();
        }

        private void bckAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCRUD acObj = new AdminCRUD();
            acObj.ShowDialog();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CreateSK_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateShopKeeper cSObj = new CreateShopKeeper();
            cSObj.ShowDialog();
        }

        private void editSK_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditShopKeeper eObj = new EditShopKeeper();
            eObj.ShowDialog();
        }

        private void deleteSk_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteShopKeeper dObj = new DeleteShopKeeper();
            dObj.ShowDialog();
        }

        private void ViewSK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewShopKeeper vObj = new ViewShopKeeper();
            vObj.ShowDialog();

        }
    }
}
