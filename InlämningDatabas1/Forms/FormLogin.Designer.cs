namespace InlämningDatabas1
{
    partial class FormLogin
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            lblUserName = new Label();
            lblPassword = new Label();
            lblHidden = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(106, 85);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(435, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(435, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(106, 220);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(124, 37);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(417, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(106, 62);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(79, 20);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "User name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(106, 138);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblHidden
            // 
            lblHidden.Anchor = AnchorStyles.Top;
            lblHidden.AutoSize = true;
            lblHidden.ForeColor = Color.Red;
            lblHidden.Location = new Point(238, 191);
            lblHidden.Name = "lblHidden";
            lblHidden.Size = new Size(42, 20);
            lblHidden.TabIndex = 6;
            lblHidden.Text = "label";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 305);
            Controls.Add(lblHidden);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "FormLogin";
            Text = "Log in";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnLogin;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblHidden;
    }
}