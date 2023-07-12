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
    public partial class ShopCRUD : Form
    {
        public ShopCRUD()
        {
            InitializeComponent();
        }

        private void option_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopkeeperPg spObj = new ShopkeeperPg();
            spObj.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            addProduct aObj = new addProduct();
            aObj.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProduct dObj = new DeleteProduct();
            dObj.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchProduct uObj = new SearchProduct();
            uObj.ShowDialog();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts mObj = new ManageProducts();
            mObj.ShowDialog();
        }
    }
}
