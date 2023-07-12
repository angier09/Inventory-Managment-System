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
    public partial class LogoPage : Form
    {
        public LogoPage()
        {
            InitializeComponent();
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void extLogoPg_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NXTLogoPg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RolePage rPObj = new RolePage();
            rPObj.ShowDialog();
        }
    }
}
