namespace BooksellerApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnklblNewEmployeeSignUp = new LinkLabel();
            btnExit = new Button();
            picboxLogin = new PictureBox();
            picboxLoginLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxLoginLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(380, 191);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 19);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(490, 187);
            txtUserName.Margin = new Padding(2, 1, 2, 1);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter Username";
            txtUserName.Size = new Size(207, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(380, 258);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 19);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(490, 254);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(207, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(172, 23, 65);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(490, 335);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnklblNewEmployeeSignUp
            // 
            lnklblNewEmployeeSignUp.Anchor = AnchorStyles.None;
            lnklblNewEmployeeSignUp.AutoSize = true;
            lnklblNewEmployeeSignUp.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lnklblNewEmployeeSignUp.ForeColor = Color.White;
            lnklblNewEmployeeSignUp.LinkBehavior = LinkBehavior.HoverUnderline;
            lnklblNewEmployeeSignUp.LinkColor = Color.White;
            lnklblNewEmployeeSignUp.Location = new Point(484, 419);
            lnklblNewEmployeeSignUp.Margin = new Padding(2, 0, 2, 0);
            lnklblNewEmployeeSignUp.Name = "lnklblNewEmployeeSignUp";
            lnklblNewEmployeeSignUp.Size = new Size(191, 19);
            lnklblNewEmployeeSignUp.TabIndex = 4;
            lnklblNewEmployeeSignUp.TabStop = true;
            lnklblNewEmployeeSignUp.Text = "New Employee Sign Up";
            lnklblNewEmployeeSignUp.LinkClicked += lblNewEmployeeSignUp_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Black;
            btnExit.BackgroundImage = Properties.Resources.exitButton;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(738, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // picboxLogin
            // 
            picboxLogin.Anchor = AnchorStyles.None;
            picboxLogin.BackColor = Color.FromArgb(172, 23, 65);
            picboxLogin.Location = new Point(12, 12);
            picboxLogin.Name = "picboxLogin";
            picboxLogin.Size = new Size(250, 626);
            picboxLogin.TabIndex = 6;
            picboxLogin.TabStop = false;
            // 
            // picboxLoginLogo
            // 
            picboxLoginLogo.Anchor = AnchorStyles.None;
            picboxLoginLogo.BackColor = Color.FromArgb(172, 23, 65);
            picboxLoginLogo.Image = Properties.Resources.login;
            picboxLoginLogo.Location = new Point(36, 160);
            picboxLoginLogo.Name = "picboxLoginLogo";
            picboxLoginLogo.Size = new Size(200, 250);
            picboxLoginLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLoginLogo.TabIndex = 7;
            picboxLoginLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 650);
            Controls.Add(picboxLoginLogo);
            Controls.Add(picboxLogin);
            Controls.Add(btnExit);
            Controls.Add(lnklblNewEmployeeSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)picboxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxLoginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lnklblNewEmployeeSignUp;
        private Button btnExit;
        private PictureBox picboxLogin;
        private PictureBox picboxLoginLogo;
    }
}
