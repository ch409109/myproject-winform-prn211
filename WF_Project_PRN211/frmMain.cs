using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Project_PRN211
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory f = new frmCategory();
            this.Hide();
            f.ShowDialog();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            frmAuthor f = new frmAuthor();
            this.Hide();
            f.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook f = new frmBook();
            this.Hide();
            f.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
        }
    }
}
