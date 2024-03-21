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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        #region Events
        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            txtCategoryID.Enabled = false;
            LoadCategoryList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int categoryId = int.Parse(dtgvCategory.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                using var context = new BookManagementContext();
                var category = context.Categories.Find(categoryId);
                txtCategoryID.Text = category.CategoryId.ToString();
                txtCategoryName.Text = category.CategoryName.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            context.Categories.Add(new Category
            {
                CategoryName = txtCategoryName.Text,
            });
            context.SaveChanges();
            LoadCategoryList();
            MessageBox.Show("Add category successfully!", "Notification", MessageBoxButtons.OK);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var category = context.Categories.Find(int.Parse(txtCategoryID.Text));
            if (category != null)
            {
                category.CategoryName = txtCategoryName.Text;
            }
            context.SaveChanges();
            LoadCategoryList();
            MessageBox.Show("Update category successfully!", "Notification", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this category?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using var context = new BookManagementContext();
                var category = context.Categories.Find(int.Parse(txtCategoryID.Text));
                context.Remove(category);
                context.SaveChanges();
                LoadCategoryList();
                MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK);
            }

        }
        #endregion

        #region Methods
        private void LoadCategoryList()
        {
            using var context = new BookManagementContext();
            var categories = context.Categories.Select(c => new
            {
                c.CategoryId,
                c.CategoryName
            }).ToList();
            dtgvCategory.DataSource = categories;
        }

        private void Clear()
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }
        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(UserSession.CurrentUser);
            f.Show();
        }
    }
}

