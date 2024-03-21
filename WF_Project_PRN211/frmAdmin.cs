using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Project_PRN211.DataAccess;

namespace WF_Project_PRN211
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            txtAdminID.Enabled = false;
            LoadAdminList();
            txtFilterName.TextChanged += new EventHandler(FilterAdmin);
        }

        private void LoadAdminList()
        {
            using var context = new BookManagementContext();
            var admins = context.Admins.Select(a => new
            {
                ID = a.AdminId,
                Fullname = a.FullName,
                Email = a.Email,
                Username = a.Username
            }).ToList();
            dtgvAdmin.DataSource = admins;
        }

        private void dtgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int adminID = int.Parse(dtgvAdmin.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                using var context = new BookManagementContext();
                var admin = context.Admins.Find(adminID);
                txtAdminID.Text = admin.AdminId.ToString();
                txtFullName.Text = admin.FullName;
                txtEmail.Text = admin.Email;
                txtUsername.Text = admin.Username;
            }
        }

        private void Clear()
        {
            txtAdminID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this admin?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using var context = new BookManagementContext();
                var admin = context.Admins.Find(int.Parse(txtAdminID.Text));
                context.Remove(admin);
                context.SaveChanges();
                LoadAdminList();
                MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void FilterAdmin(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var admins = context.Admins.Where(a => a.FullName.ToLower().Contains(txtFilterName.Text)).Select(a => new
            {
                ID = a.AdminId,
                Fullname = a.FullName,
                Email = a.Email,
                Username = a.Username
            }).ToList();
            dtgvAdmin.DataSource = admins;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAdmin f = new frmAddAdmin();
            f.AdminAdded += F_AdminAdded;
            f.Show();
        }

        private void F_AdminAdded(object sender, EventArgs e)
        {
            LoadAdminList();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(UserSession.CurrentUser);
            f.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is frmAddAdmin addAdminForm)
            {
                addAdminForm.AdminAdded -= F_AdminAdded;
            }
        }
    }
}
