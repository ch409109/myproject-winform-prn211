namespace WF_Project_PRN211
{
    partial class frmLogin
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
            btnCancel = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txtPassword = new TextBox();
            lbPassword = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            lbUsername = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 167);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(274, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(135, 125);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(lbPassword);
            panel3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(3, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 55);
            panel3.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 13);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 30);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "admin123";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(14, 16);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(110, 24);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lbUsername);
            panel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 55);
            panel2.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(132, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 30);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "admin1";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(14, 16);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(112, 24);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username:";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(410, 193);
            Controls.Add(panel1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += frmLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnLogin;
        private Panel panel3;
        private TextBox txtPassword;
        private Label lbPassword;
        private Panel panel2;
        private TextBox txtUsername;
        private Label lbUsername;
    }
}