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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WF_Project_PRN211
{
    public partial class frmAddAdmin : Form
    {
        public event EventHandler AdminAdded;
        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            string fullname = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string username = txtUsername.Text;

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please fill in all the required information.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (password == confirmPassword)
                {
                    context.Admins.Add(new Admin
                    {
                        FullName = txtFullName.Text,
                        Email = txtEmail.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text
                    });
                    context.SaveChanges();
                    MessageBox.Show("Add admin successfully!", "Notification", MessageBoxButtons.OK);
                    AdminAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The password and confirmation password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
