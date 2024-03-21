namespace WF_Project_PRN211
{
    partial class frmAdmin
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
            dtgvAdmin = new DataGridView();
            pnlAdmin = new Panel();
            lbUsername = new Label();
            lbEmail = new Label();
            lbFullName = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtAdminID = new TextBox();
            lbID = new Label();
            panel2 = new Panel();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            grbFilter = new GroupBox();
            txtFilterName = new TextBox();
            lbFilterName = new Label();
            menuStrip1 = new MenuStrip();
            backToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgvAdmin).BeginInit();
            pnlAdmin.SuspendLayout();
            panel2.SuspendLayout();
            grbFilter.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvAdmin
            // 
            dtgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAdmin.Location = new Point(12, 72);
            dtgvAdmin.Name = "dtgvAdmin";
            dtgvAdmin.RowHeadersWidth = 51;
            dtgvAdmin.RowTemplate.Height = 29;
            dtgvAdmin.Size = new Size(433, 258);
            dtgvAdmin.TabIndex = 0;
            dtgvAdmin.CellClick += dtgvAdmin_CellClick;
            // 
            // pnlAdmin
            // 
            pnlAdmin.Controls.Add(lbUsername);
            pnlAdmin.Controls.Add(lbEmail);
            pnlAdmin.Controls.Add(lbFullName);
            pnlAdmin.Controls.Add(txtFullName);
            pnlAdmin.Controls.Add(txtEmail);
            pnlAdmin.Controls.Add(txtUsername);
            pnlAdmin.Controls.Add(txtAdminID);
            pnlAdmin.Controls.Add(lbID);
            pnlAdmin.Location = new Point(451, 72);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(337, 258);
            pnlAdmin.TabIndex = 1;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.Location = new Point(17, 83);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(70, 20);
            lbUsername.TabIndex = 10;
            lbUsername.Text = "Username";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(17, 141);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(43, 20);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "Email";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbFullName.Location = new Point(17, 202);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(70, 20);
            lbFullName.TabIndex = 8;
            lbFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(108, 199);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(216, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(108, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtAdminID
            // 
            txtAdminID.Location = new Point(108, 24);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(216, 27);
            txtAdminID.TabIndex = 4;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbID.Location = new Point(17, 27);
            lbID.Name = "lbID";
            lbID.Size = new Size(65, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Admin ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(451, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 102);
            panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(47, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(173, 53);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 43);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(47, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add a new admin";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grbFilter
            // 
            grbFilter.Controls.Add(txtFilterName);
            grbFilter.Controls.Add(lbFilterName);
            grbFilter.Location = new Point(12, 329);
            grbFilter.Name = "grbFilter";
            grbFilter.Size = new Size(433, 102);
            grbFilter.TabIndex = 3;
            grbFilter.TabStop = false;
            grbFilter.Text = "Filter";
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(146, 43);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(238, 27);
            txtFilterName.TabIndex = 1;
            // 
            // lbFilterName
            // 
            lbFilterName.AutoSize = true;
            lbFilterName.Location = new Point(47, 46);
            lbFilterName.Name = "lbFilterName";
            lbFilterName.Size = new Size(72, 20);
            lbFilterName.TabIndex = 0;
            lbFilterName.Text = "FullName";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToMainMenuToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            backToMainMenuToolStripMenuItem.Size = new Size(150, 24);
            backToMainMenuToolStripMenuItem.Text = "Back to Main menu";
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
            editProfileToolStripMenuItem.Text = "Edit profile";
            editProfileToolStripMenuItem.Click += editProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbFilter);
            Controls.Add(panel2);
            Controls.Add(pnlAdmin);
            Controls.Add(dtgvAdmin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvAdmin).EndInit();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            panel2.ResumeLayout(false);
            grbFilter.ResumeLayout(false);
            grbFilter.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvAdmin;
        private Panel pnlAdmin;
        private Label label4;
        private Label label3;
        private Label lbID;
        private Panel panel2;
        private GroupBox grbFilter;
        private Label lbUsername;
        private Label lbEmail;
        private Label lbFullName;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtAdminID;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtFilterName;
        private Label lbFilterName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}