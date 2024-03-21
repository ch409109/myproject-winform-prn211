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
    public partial class frmAuthor : Form
    {
        public frmAuthor()
        {
            InitializeComponent();
        }

        #region Events
        private void frmAuthor_Load(object sender, EventArgs e)
        {
            txtAuthorID.Enabled = false;
            LoadAuthorList();
            txtNameFilter.TextChanged += new EventHandler(AuthorFilter);
        }

        private void dtgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int authorID = int.Parse(dtgvAuthor.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                using var context = new BookManagementContext();
                var author = context.Authors.Find(authorID);
                txtAuthorID.Text = author.AuthorId.ToString();
                txtAuthorName.Text = author.AuthorName;
                txtNationality.Text = author.Nationality;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this author?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using var context = new BookManagementContext();
                var author = context.Authors.Find(int.Parse(txtAuthorID.Text));
                context.Remove(author);
                context.SaveChanges();
                LoadAuthorList();
                MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var author = context.Authors.Find(int.Parse(txtAuthorID.Text));
            if (author != null)
            {
                author.AuthorName = txtAuthorName.Text;
                author.Nationality = txtNationality.Text;
            }
            context.SaveChanges();
            LoadAuthorList();
            MessageBox.Show("Update author successfully!", "Notification", MessageBoxButtons.OK);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            context.Authors.Add(new Author
            {
                AuthorName = txtAuthorName.Text,
                Nationality = txtNationality.Text,
            });
            context.SaveChanges();
            LoadAuthorList();
            MessageBox.Show("Add author successfully!", "Notification", MessageBoxButtons.OK);
        }
        #endregion

        #region Methods
        private void LoadAuthorList()
        {
            using var context = new BookManagementContext();
            var authors = context.Authors.Select(a => new
            {
                a.AuthorId,
                a.AuthorName,
                a.Nationality
            }).ToList();
            dtgvAuthor.DataSource = authors;
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void Clear()
        {
            txtAuthorID.Text = string.Empty;
            txtAuthorName.Text = string.Empty;
            txtNationality.Text = string.Empty;
        }

        private void AuthorFilter(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var author = context.Authors.Where(a => a.AuthorName.ToLower().Contains(txtNameFilter.Text)).Select(a => new
            {
                a.AuthorId,
                a.AuthorName,
                a.Nationality
            }).ToList();
            dtgvAuthor.DataSource = author;

        }
        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(UserSession.CurrentUser);
            f.Show();
        }

    }
}
