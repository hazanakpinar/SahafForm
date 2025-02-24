namespace BooksellerApp
{
    partial class EmployeeSignUp
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmployeeName = new Label();
            txtEmployeeName = new TextBox();
            lblEmployeeSurname = new Label();
            txtEmployeeSurname = new TextBox();
            btnBack = new Button();
            btnSignUp = new Button();
            picboxSignUp = new PictureBox();
            picboxSignUpLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxSignUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxSignUpLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(310, 193);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 19);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(495, 189);
            txtUserName.Margin = new Padding(2, 1, 2, 1);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter UserName";
            txtUserName.Size = new Size(254, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(310, 249);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 19);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(495, 245);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(254, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Anchor = AnchorStyles.None;
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Location = new Point(310, 301);
            lblEmployeeName.Margin = new Padding(2, 0, 2, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(134, 19);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Anchor = AnchorStyles.None;
            txtEmployeeName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtEmployeeName.ForeColor = Color.Black;
            txtEmployeeName.Location = new Point(495, 297);
            txtEmployeeName.Margin = new Padding(2, 1, 2, 1);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.PlaceholderText = "Enter Name";
            txtEmployeeName.Size = new Size(254, 27);
            txtEmployeeName.TabIndex = 3;
            // 
            // lblEmployeeSurname
            // 
            lblEmployeeSurname.Anchor = AnchorStyles.None;
            lblEmployeeSurname.AutoSize = true;
            lblEmployeeSurname.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblEmployeeSurname.ForeColor = Color.White;
            lblEmployeeSurname.Location = new Point(310, 354);
            lblEmployeeSurname.Margin = new Padding(2, 0, 2, 0);
            lblEmployeeSurname.Name = "lblEmployeeSurname";
            lblEmployeeSurname.Size = new Size(160, 19);
            lblEmployeeSurname.TabIndex = 0;
            lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeSurname
            // 
            txtEmployeeSurname.Anchor = AnchorStyles.None;
            txtEmployeeSurname.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtEmployeeSurname.ForeColor = Color.Black;
            txtEmployeeSurname.Location = new Point(495, 350);
            txtEmployeeSurname.Margin = new Padding(2, 1, 2, 1);
            txtEmployeeSurname.Name = "txtEmployeeSurname";
            txtEmployeeSurname.PlaceholderText = "Enter Surname";
            txtEmployeeSurname.Size = new Size(254, 27);
            txtEmployeeSurname.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(181, 126, 220);
            btnBack.BackgroundImage = Properties.Resources.backButton;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 578);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 60);
            btnBack.TabIndex = 5;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.BackColor = Color.FromArgb(181, 126, 220);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(495, 436);
            btnSignUp.Margin = new Padding(2, 1, 2, 1);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(178, 41);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnLogin_Click;
            // 
            // picboxSignUp
            // 
            picboxSignUp.BackColor = Color.FromArgb(181, 126, 220);
            picboxSignUp.Location = new Point(12, 12);
            picboxSignUp.Name = "picboxSignUp";
            picboxSignUp.Size = new Size(250, 626);
            picboxSignUp.TabIndex = 7;
            picboxSignUp.TabStop = false;
            // 
            // picboxSignUpLogo
            // 
            picboxSignUpLogo.Anchor = AnchorStyles.None;
            picboxSignUpLogo.BackColor = Color.FromArgb(181, 126, 220);
            picboxSignUpLogo.Image = Properties.Resources.signUp;
            picboxSignUpLogo.Location = new Point(36, 160);
            picboxSignUpLogo.Name = "picboxSignUpLogo";
            picboxSignUpLogo.Size = new Size(200, 250);
            picboxSignUpLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxSignUpLogo.TabIndex = 8;
            picboxSignUpLogo.TabStop = false;
            // 
            // EmployeeSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 650);
            Controls.Add(picboxSignUpLogo);
            Controls.Add(btnBack);
            Controls.Add(picboxSignUp);
            Controls.Add(btnSignUp);
            Controls.Add(txtEmployeeSurname);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblEmployeeSurname);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "EmployeeSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeSignUp";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)picboxSignUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxSignUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmployeeName;
        private TextBox txtEmployeeName;
        private Label lblEmployeeSurname;
        private TextBox txtEmployeeSurname;
        private Button btnBack;
        private Button btnSignUp;
        private PictureBox picboxSignUp;
        private PictureBox picboxSignUpLogo;
    }
}