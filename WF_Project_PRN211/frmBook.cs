using Microsoft.EntityFrameworkCore;
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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        #region Events
        private void frmBook_Load(object sender, EventArgs e)
        {
            txtBookID.Enabled = false;
            LoadBookList();
            using var context = new BookManagementContext();
            var categoriesFilter = context.Categories.Select(c => c.CategoryName).Distinct().ToList();
            var categories = context.Categories.Select(c => c.CategoryName).Distinct().ToList();
            categoriesFilter.Insert(0, "All categories");
            cboCategoryFilter.DataSource = categoriesFilter;
            cboCategories.DataSource = categories;
            txtTitleFilter.TextChanged += new EventHandler(BookFilter);
            cboCategoryFilter.SelectedIndexChanged += new EventHandler(BookFilter);
        }

        private void dtgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int bookID = int.Parse(dtgvBook.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                using var context = new BookManagementContext();
                var book = context.Books.Find(bookID);
                txtBookID.Text = book.BookId.ToString();
                txtTitle.Text = book.Title;

                int selct = dtgvBook.SelectedCells[0].RowIndex;
                DataGridViewRow seelct = dtgvBook.Rows[selct];

                txtAuthor.Text = seelct.Cells[2].Value.ToString();
                cboCategories.SelectedItem = seelct.Cells[3].Value.ToString();

                txtPublicationYear.Text = book.PublicationYear.ToString();
                txtPrice.Text = book.Price.ToString();
            }
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this book?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using var context = new BookManagementContext();
                var book = context.Books.Find(int.Parse(txtBookID.Text));
                context.Remove(book);
                context.SaveChanges();
                LoadBookList();
                MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var book = context.Books.Find(int.Parse(txtBookID.Text));

            string authorName = txtAuthor.Text;
            bool isAuthorExist = false;
            foreach (var item in context.Authors)
            {
                if (authorName == item.AuthorName)
                {
                    isAuthorExist = true;
                    break;
                }
            }
            if (!isAuthorExist)
            {
                context.Authors.Add(new Author
                {
                    AuthorName = authorName
                });
                context.SaveChanges();
            }

            if (book != null)
            {
                book.Title = txtTitle.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.PublicationYear = Convert.ToInt32(txtPublicationYear.Text);
                book.AuthorId = context.Authors.FirstOrDefault(a => a.AuthorName == authorName).AuthorId;
                book.CategoryId = context.Categories.FirstOrDefault(c => c.CategoryName == cboCategories.SelectedItem.ToString()).CategoryId;
            }
            context.SaveChanges();
            LoadBookList();
            MessageBox.Show("Update book successfully!", "Notification", MessageBoxButtons.OK);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            string authorName = txtAuthor.Text;
            bool isAuthorExist = false;
            foreach (var item in context.Authors)
            {
                if (authorName == item.AuthorName)
                {
                    isAuthorExist = true;
                    break;
                }
            }

            if (!isAuthorExist)
            {
                context.Authors.Add(new Author
                {
                    AuthorName = authorName
                });
                context.SaveChanges();
            }

            context.Books.Add(new Book
            {
                Title = txtTitle.Text,
                AuthorId = context.Authors.FirstOrDefault(a => a.AuthorName == authorName).AuthorId,
                Price = decimal.Parse(txtPrice.Text),
                PublicationYear = int.Parse(txtPublicationYear.Text),
                CategoryId = context.Categories.FirstOrDefault(c => c.CategoryName == cboCategories.SelectedItem.ToString()).CategoryId
            });

            context.SaveChanges();
            LoadBookList();
            MessageBox.Show("Add book successfully!", "Notification", MessageBoxButtons.OK);

        }

        private void BookFilter(object sender, EventArgs e)
        {
            using var context = new BookManagementContext();
            var selectedIndex = cboCategoryFilter.SelectedIndex;
            //var category = cboCategoryFilter.SelectedIndex.ToString();
            var books = context.Books.Where(b => b.Title.ToLower().Contains(txtTitleFilter.Text)
            && (cboCategoryFilter.SelectedIndex == 0 || b.Category.CategoryName == cboCategoryFilter.SelectedItem.ToString())).Select(b => new
            {
                ID = b.BookId,
                b.Title,
                Author = b.Author.AuthorName,
                Category = b.Category.CategoryName,
                b.PublicationYear,
                b.Price
            }).ToList();
            dtgvBook.DataSource = books;
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(UserSession.CurrentUser);
            f.Show();
        }
        #endregion

        #region Methods
        private void LoadCategories()
        {
            using var context = new BookManagementContext();
            var categories = context.Categories.ToList();
            categories.Insert(0, new Category { CategoryId = 0, CategoryName = "All categories" });
            cboCategoryFilter.DataSource = categories;
            cboCategoryFilter.DisplayMember = "CategoryName";
            cboCategoryFilter.ValueMember = "CategoryId";
        }
        private void LoadBookList()
        {
            using var context = new BookManagementContext();
            var books = context.Books.Select(b => new
            {
                ID = b.BookId,
                b.Title,
                Author = b.Author.AuthorName,
                Category = b.Category.CategoryName,
                b.PublicationYear,
                b.Price
            }).ToList();
            dtgvBook.DataSource = books;
        }

        private void Clear()
        {
            txtBookID.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtPublicationYear.Text = string.Empty;
            cboCategories.SelectedIndex = -1;
        }
        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
