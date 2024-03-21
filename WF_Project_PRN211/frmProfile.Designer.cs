namespace WF_Project_PRN211
{
    partial class frmProfile
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
            txtNewFullName = new TextBox();
            txtNewEmail = new TextBox();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbConfirmPassword = new Label();
            lbPassword = new Label();
            lbUsername = new Label();
            lbEmail = new Label();
            txtNewConfirmPassword = new TextBox();
            txtID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFullName.Location = new Point(41, 87);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(87, 24);
            lbFullName.TabIndex = 0;
            lbFullName.Text = "Full Name";
            // 
            // txtNewFullName
            // 
            txtNewFullName.Location = new Point(183, 87);
            txtNewFullName.Name = "txtNewFullName";
            txtNewFullName.Size = new Size(270, 27);
            txtNewFullName.TabIndex = 4;
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(183, 139);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(270, 27);
            txtNewEmail.TabIndex = 5;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(183, 193);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.ReadOnly = true;
            txtNewUsername.Size = new Size(270, 27);
            txtNewUsername.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(183, 243);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(270, 27);
            txtNewPassword.TabIndex = 7;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(183, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(359, 352);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbConfirmPassword.Location = new Point(12, 299);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(152, 24);
            lbConfirmPassword.TabIndex = 10;
            lbConfirmPassword.Text = "Confirm password";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(42, 243);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 24);
            lbPassword.TabIndex = 11;
            lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.Location = new Point(41, 193);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(88, 24);
            lbUsername.TabIndex = 12;
            lbUsername.Text = "Username";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(51, 139);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(52, 24);
            lbEmail.TabIndex = 13;
            lbEmail.Text = "Email";
            // 
            // txtNewConfirmPassword
            // 
            txtNewConfirmPassword.Location = new Point(183, 299);
            txtNewConfirmPassword.Name = "txtNewConfirmPassword";
            txtNewConfirmPassword.Size = new Size(270, 27);
            txtNewConfirmPassword.TabIndex = 14;
            txtNewConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(183, 33);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(270, 27);
            txtID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 33);
            label1.Name = "label1";
            label1.Size = new Size(26, 24);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 393);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(txtNewConfirmPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(txtNewEmail);
            Controls.Add(txtNewFullName);
            Controls.Add(lbFullName);
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Profile Information";
            Load += frmProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFullName;
        private TextBox txtNewFullName;
        private TextBox txtNewEmail;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label lbConfirmPassword;
        private Label lbPassword;
        private Label lbUsername;
        private Label lbEmail;
        private TextBox txtNewConfirmPassword;
        private TextBox txtID;
        private Label label1;
    }
}