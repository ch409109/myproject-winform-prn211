namespace WF_Project_PRN211
{
    partial class frmMain
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
            btnCategory = new Button();
            btnLogout = new Button();
            btnAuthor = new Button();
            btnBook = new Button();
            btnAdmin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAuthor);
            panel1.Controls.Add(btnBook);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 492);
            panel1.TabIndex = 0;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategory.Location = new Point(77, 132);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(113, 50);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(77, 398);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(113, 50);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAuthor
            // 
            btnAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuthor.Location = new Point(77, 221);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(113, 50);
            btnAuthor.TabIndex = 1;
            btnAuthor.Text = "Author";
            btnAuthor.UseVisualStyleBackColor = true;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.Location = new Point(77, 43);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(113, 50);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Location = new Point(77, 309);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(113, 50);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 516);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCategory;
        private Button btnLogout;
        private Button btnAuthor;
        private Button btnBook;
        private Button btnAdmin;
    }
}