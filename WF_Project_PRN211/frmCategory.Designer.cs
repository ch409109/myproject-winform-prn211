namespace WF_Project_PRN211
{
    partial class frmCategory
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
            dtgvCategory = new DataGridView();
            grbCategory = new GroupBox();
            txtCategoryName = new TextBox();
            label1 = new Label();
            lbCategoryID = new Label();
            txtCategoryID = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            menuStrip1 = new MenuStrip();
            backToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            pToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            btnRefresh = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            grbCategory.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(421, 34);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.RowTemplate.Height = 29;
            dtgvCategory.Size = new Size(301, 318);
            dtgvCategory.TabIndex = 0;
            dtgvCategory.CellClick += dtgvCategory_CellClick;
            // 
            // grbCategory
            // 
            grbCategory.Controls.Add(txtCategoryName);
            grbCategory.Controls.Add(label1);
            grbCategory.Controls.Add(lbCategoryID);
            grbCategory.Controls.Add(txtCategoryID);
            grbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbCategory.Location = new Point(12, 50);
            grbCategory.Name = "grbCategory";
            grbCategory.Size = new Size(403, 209);
            grbCategory.TabIndex = 1;
            grbCategory.TabStop = false;
            grbCategory.Text = "Category Information";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(182, 125);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(204, 34);
            txtCategoryName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 128);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 9;
            label1.Text = "Category Name:";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategoryID.Location = new Point(13, 61);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(128, 24);
            lbCategoryID.TabIndex = 8;
            lbCategoryID.Text = "Category ID:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(182, 61);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(204, 34);
            txtCategoryID.TabIndex = 7;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToMainMenuToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(735, 28);
            menuStrip1.TabIndex = 7;
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
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pToolStripMenuItem, logoutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // pToolStripMenuItem
            // 
            pToolStripMenuItem.Name = "pToolStripMenuItem";
            pToolStripMenuItem.Size = new Size(224, 26);
            pToolStripMenuItem.Text = "Edit profile";
            pToolStripMenuItem.Click += pToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
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
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Location = new Point(12, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 62);
            panel1.TabIndex = 11;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 401);
            Controls.Add(panel1);
            Controls.Add(grbCategory);
            Controls.Add(dtgvCategory);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += frmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            grbCategory.ResumeLayout(false);
            grbCategory.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCategory;
        private GroupBox grbCategory;
        private Button btnDelete;
        private TextBox txtCategoryName;
        private Label label1;
        private Label lbCategoryID;
        private TextBox txtCategoryID;
        private Button btnAdd;
        private Button btnEdit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private Button btnRefresh;
        private Panel panel1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem pToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}