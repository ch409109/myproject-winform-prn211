namespace WF_Project_PRN211
{
    partial class frmAuthor
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
            grbAuthor = new GroupBox();
            txtNationality = new TextBox();
            lbNationality = new Label();
            txtAuthorName = new TextBox();
            lbAuthorName = new Label();
            lbAuthorID = new Label();
            txtAuthorID = new TextBox();
            dtgvAuthor = new DataGridView();
            menuStrip1 = new MenuStrip();
            backToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            editProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            txtNameFilter = new TextBox();
            panel1.SuspendLayout();
            grbAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAuthor).BeginInit();
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
            panel1.Location = new Point(45, 360);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 62);
            panel1.TabIndex = 14;
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
            // grbAuthor
            // 
            grbAuthor.Controls.Add(txtNationality);
            grbAuthor.Controls.Add(lbNationality);
            grbAuthor.Controls.Add(txtAuthorName);
            grbAuthor.Controls.Add(lbAuthorName);
            grbAuthor.Controls.Add(lbAuthorID);
            grbAuthor.Controls.Add(txtAuthorID);
            grbAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbAuthor.Location = new Point(45, 118);
            grbAuthor.Name = "grbAuthor";
            grbAuthor.Size = new Size(403, 209);
            grbAuthor.TabIndex = 13;
            grbAuthor.TabStop = false;
            grbAuthor.Text = "Author Information";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(182, 150);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(204, 34);
            txtNationality.TabIndex = 12;
            // 
            // lbNationality
            // 
            lbNationality.AutoSize = true;
            lbNationality.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNationality.Location = new Point(13, 157);
            lbNationality.Name = "lbNationality";
            lbNationality.Size = new Size(117, 24);
            lbNationality.TabIndex = 11;
            lbNationality.Text = "Nationality:";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(182, 102);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(204, 34);
            txtAuthorName.TabIndex = 10;
            // 
            // lbAuthorName
            // 
            lbAuthorName.AutoSize = true;
            lbAuthorName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAuthorName.Location = new Point(13, 109);
            lbAuthorName.Name = "lbAuthorName";
            lbAuthorName.Size = new Size(140, 24);
            lbAuthorName.TabIndex = 9;
            lbAuthorName.Text = "Author Name:";
            // 
            // lbAuthorID
            // 
            lbAuthorID.AutoSize = true;
            lbAuthorID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAuthorID.Location = new Point(13, 61);
            lbAuthorID.Name = "lbAuthorID";
            lbAuthorID.Size = new Size(106, 24);
            lbAuthorID.TabIndex = 8;
            lbAuthorID.Text = "Author ID:";
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(182, 54);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.ReadOnly = true;
            txtAuthorID.Size = new Size(204, 34);
            txtAuthorID.TabIndex = 7;
            // 
            // dtgvAuthor
            // 
            dtgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAuthor.Location = new Point(454, 57);
            dtgvAuthor.Name = "dtgvAuthor";
            dtgvAuthor.RowHeadersWidth = 51;
            dtgvAuthor.RowTemplate.Height = 29;
            dtgvAuthor.Size = new Size(422, 365);
            dtgvAuthor.TabIndex = 12;
            dtgvAuthor.CellClick += dtgvAuthor_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToMainMenuToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(890, 28);
            menuStrip1.TabIndex = 15;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNameFilter);
            groupBox1.Location = new Point(48, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 60);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // txtNameFilter
            // 
            txtNameFilter.Location = new Point(65, 22);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.PlaceholderText = "Enter name";
            txtNameFilter.Size = new Size(285, 27);
            txtNameFilter.TabIndex = 0;
            // 
            // frmAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(grbAuthor);
            Controls.Add(dtgvAuthor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author Management";
            Load += frmAuthor_Load;
            panel1.ResumeLayout(false);
            grbAuthor.ResumeLayout(false);
            grbAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAuthor).EndInit();
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
        private GroupBox grbAuthor;
        private TextBox txtNationality;
        private Label lbNationality;
        private TextBox txtAuthorName;
        private Label lbAuthorName;
        private Label lbAuthorID;
        private TextBox txtAuthorID;
        private DataGridView dtgvAuthor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txtNameFilter;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}