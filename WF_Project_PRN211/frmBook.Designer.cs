namespace WF_Project_PRN211
{
    partial class frmBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            grbBook = new GroupBox();
            cboCategories = new ComboBox();
            txtPrice = new TextBox();
            txtPublicationYear = new TextBox();
            lbPublicationYear = new Label();
            lbPrice = new Label();
            lbCategory = new Label();
            txtAuthor = new TextBox();
            lbAuthor = new Label();
            txtTitle = new TextBox();
            lbTitle = new Label();
            lbBookID = new Label();
            txtBookID = new TextBox();
            dtgvBook = new DataGridView();
            menuStrip1 = new MenuStrip();
            backToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            lbCategoryFilter = new Label();
            cboCategoryFilter = new ComboBox();
            txtTitleFilter = new TextBox();
            lbTitleFilter = new Label();
            panel1.SuspendLayout();
            grbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBook).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Location = new Point(6, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 62);
            panel1.TabIndex = 17;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(297, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(92, 57);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 57);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(199, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 57);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(101, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 57);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // grbBook
            // 
            grbBook.Controls.Add(panel1);
            grbBook.Controls.Add(cboCategories);
            grbBook.Controls.Add(txtPrice);
            grbBook.Controls.Add(txtPublicationYear);
            grbBook.Controls.Add(lbPublicationYear);
            grbBook.Controls.Add(lbPrice);
            grbBook.Controls.Add(lbCategory);
            grbBook.Controls.Add(txtAuthor);
            grbBook.Controls.Add(lbAuthor);
            grbBook.Controls.Add(txtTitle);
            grbBook.Controls.Add(lbTitle);
            grbBook.Controls.Add(lbBookID);
            grbBook.Controls.Add(txtBookID);
            grbBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbBook.Location = new Point(700, 90);
            grbBook.Name = "grbBook";
            grbBook.Size = new Size(409, 419);
            grbBook.TabIndex = 16;
            grbBook.TabStop = false;
            grbBook.Text = "Book Information";
            // 
            // cboCategories
            // 
            cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(182, 198);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(204, 36);
            cboCategories.TabIndex = 19;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(182, 292);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 34);
            txtPrice.TabIndex = 18;
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Location = new Point(182, 244);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(204, 34);
            txtPublicationYear.TabIndex = 17;
            // 
            // lbPublicationYear
            // 
            lbPublicationYear.AutoSize = true;
            lbPublicationYear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPublicationYear.Location = new Point(6, 251);
            lbPublicationYear.Name = "lbPublicationYear";
            lbPublicationYear.Size = new Size(170, 24);
            lbPublicationYear.TabIndex = 16;
            lbPublicationYear.Text = "Publication Year:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.Location = new Point(6, 299);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(65, 24);
            lbPrice.TabIndex = 15;
            lbPrice.Text = "Price:";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategory.Location = new Point(6, 205);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(103, 24);
            lbCategory.TabIndex = 13;
            lbCategory.Text = "Category:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(182, 150);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(204, 34);
            txtAuthor.TabIndex = 12;
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAuthor.Location = new Point(6, 157);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(81, 24);
            lbAuthor.TabIndex = 11;
            lbAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(182, 102);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(204, 34);
            txtTitle.TabIndex = 10;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(6, 109);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(58, 24);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Title:";
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbBookID.Location = new Point(6, 61);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(91, 24);
            lbBookID.TabIndex = 8;
            lbBookID.Text = "Book ID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(182, 54);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(204, 34);
            txtBookID.TabIndex = 7;
            // 
            // dtgvBook
            // 
            dtgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBook.Location = new Point(12, 90);
            dtgvBook.Name = "dtgvBook";
            dtgvBook.RowHeadersWidth = 51;
            dtgvBook.RowTemplate.Height = 29;
            dtgvBook.Size = new Size(682, 290);
            dtgvBook.TabIndex = 15;
            dtgvBook.CellClick += dtgvBook_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToMainMenuToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1121, 28);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            backToMainMenuToolStripMenuItem.Size = new Size(150, 24);
            backToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            backToMainMenuToolStripMenuItem.Click += backToMainMenuToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editProfileToolStripMenuItem, logoutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // editProfileToolStripMenuItem
            // 
            editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            editProfileToolStripMenuItem.Size = new Size(224, 26);
            editProfileToolStripMenuItem.Text = "Edit Profile";
            editProfileToolStripMenuItem.Click += editProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCategoryFilter);
            groupBox1.Controls.Add(cboCategoryFilter);
            groupBox1.Controls.Add(txtTitleFilter);
            groupBox1.Controls.Add(lbTitleFilter);
            groupBox1.Location = new Point(12, 390);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(682, 108);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // lbCategoryFilter
            // 
            lbCategoryFilter.AutoSize = true;
            lbCategoryFilter.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategoryFilter.Location = new Point(337, 45);
            lbCategoryFilter.Name = "lbCategoryFilter";
            lbCategoryFilter.Size = new Size(80, 24);
            lbCategoryFilter.TabIndex = 3;
            lbCategoryFilter.Text = "Category";
            // 
            // cboCategoryFilter
            // 
            cboCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoryFilter.FormattingEnabled = true;
            cboCategoryFilter.Location = new Point(423, 45);
            cboCategoryFilter.Name = "cboCategoryFilter";
            cboCategoryFilter.Size = new Size(228, 28);
            cboCategoryFilter.TabIndex = 2;
            // 
            // txtTitleFilter
            // 
            txtTitleFilter.Location = new Point(71, 45);
            txtTitleFilter.Name = "txtTitleFilter";
            txtTitleFilter.Size = new Size(228, 27);
            txtTitleFilter.TabIndex = 1;
            // 
            // lbTitleFilter
            // 
            lbTitleFilter.AutoSize = true;
            lbTitleFilter.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleFilter.Location = new Point(23, 45);
            lbTitleFilter.Name = "lbTitleFilter";
            lbTitleFilter.Size = new Size(42, 24);
            lbTitleFilter.TabIndex = 0;
            lbTitleFilter.Text = "Title";
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 527);
            Controls.Add(groupBox1);
            Controls.Add(grbBook);
            Controls.Add(dtgvBook);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Management";
            Load += frmBook_Load;
            panel1.ResumeLayout(false);
            grbBook.ResumeLayout(false);
            grbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBook).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private GroupBox grbBook;
        private TextBox txtAuthor;
        private Label lbAuthor;
        private TextBox txtTitle;
        private Label lbTitle;
        private Label lbBookID;
        private TextBox txtBookID;
        private DataGridView dtgvBook;
        private Label lbCategory;
        private TextBox txtPrice;
        private TextBox txtPublicationYear;
        private Label lbPublicationYear;
        private Label lbPrice;
        private ComboBox cboCategories;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private GroupBox groupBox1;
        private Label lbCategoryFilter;
        private ComboBox cboCategoryFilter;
        private TextBox txtTitleFilter;
        private Label lbTitleFilter;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}