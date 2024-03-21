namespace WF_Project_PRN211
{
    partial class frmAddAdmin
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
            lbFullName = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnCancel = new Button();
            lbUsername = new Label();
            lbEmail = new Label();
            lbConfirmPassword = new Label();
            lbPassword = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFullName.Location = new Point(38, 47);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(87, 24);
            lbFullName.TabIndex = 0;
            lbFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(193, 47);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(210, 27);
            txtFullName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(193, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(193, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(193, 290);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(210, 27);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 41);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.Location = new Point(37, 163);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(88, 24);
            lbUsername.TabIndex = 12;
            lbUsername.Text = "Username";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(49, 109);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(52, 24);
            lbEmail.TabIndex = 13;
            lbEmail.Text = "Email";
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfirmPassword.Location = new Point(23, 293);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(153, 24);
            lbConfirmPassword.TabIndex = 14;
            lbConfirmPassword.Text = "Confirm Password";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(37, 225);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 24);
            lbPassword.TabIndex = 15;
            lbPassword.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(73, 358);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 41);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 443);
            Controls.Add(btnAdd);
            Controls.Add(lbPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Controls.Add(btnCancel);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(lbFullName);
            Name = "frmAddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Admin ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFullName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button button1;
        private Button btnCancel;
        private Label lbUsername;
        private Label lbEmail;
        private Label lbConfirmPassword;
        private Label lbPassword;
        private Button btnAdd;
    }
}