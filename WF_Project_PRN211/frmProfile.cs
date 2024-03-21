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
    public partial class frmProfile : Form
    {
        private Admin currentUser;
        public frmProfile(Admin user)
        {
            InitializeComponent();
            currentUser = UserSession.CurrentUser;
            LoadUserData();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtNewUsername.Enabled = false;
        }

        private void LoadUserData()
        {
            if (currentUser != null)
            {
                txtID.Text = currentUser.AdminId.ToString();
                txtNewUsername.Text = currentUser.Username;
                txtNewFullName.Text = currentUser.FullName;
                txtNewEmail.Text = currentUser.Email;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var admin = context.Admins.Find(Convert.ToInt32(txtID.Text));
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtNewConfirmPassword.Text;
            string fullname = txtNewFullName.Text;
            string email = txtNewEmail.Text;
            if (newPassword == null || confirmPassword == null || newPassword.Equals("") || confirmPassword.Equals("")
                || email == null || email.Equals("") || fullname == null || fullname.Equals(""))
            {
                MessageBox.Show("Please fill in all the required information.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (newPassword == confirmPassword)
                {
                    if (admin != null)
                    {
                        admin.FullName = txtNewFullName.Text;
                        admin.Email = txtNewEmail.Text;
                        admin.Password = txtNewPassword.Text;
                    }
                    context.SaveChanges();
                    MessageBox.Show("Update profile successfully!", "Notification", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The new password and confirmation password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/*
 private bool ValidateFields()
{
    if (string.IsNullOrWhiteSpace(txtUsername.Text))
    {
        MessageBox.Show("Please enter a username.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }

    if (string.IsNullOrWhiteSpace(txtFullName.Text))
    {
        MessageBox.Show("Please enter your full name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }

    if (string.IsNullOrWhiteSpace(txtEmail.Text))
    {
        MessageBox.Show("Please enter your email address.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }

    if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
    {
        MessageBox.Show("Please enter a new password.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }

    return true;
}
 */

/*
 private void btnSave_Click(object sender, EventArgs e)
{
    if (!ValidateFields())
        return;

    // Xử lý dữ liệu từ form ở đây
    // ...
}
 */