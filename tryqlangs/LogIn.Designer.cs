namespace tryqlangs
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            chbShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(536, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email (e.g., user@gmail.com)";
            txtEmail.Size = new Size(370, 32);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(538, 287);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(370, 32);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(615, 366);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(210, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignUp.Location = new Point(615, 424);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(210, 36);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(481, 204);
            label1.Name = "label1";
            label1.Size = new Size(49, 35);
            label1.TabIndex = 4;
            label1.Text = "👤";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(483, 287);
            label2.Name = "label2";
            label2.Size = new Size(49, 35);
            label2.TabIndex = 5;
            label2.Text = "🔐";
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Transparent;
            chbShowPassword.Font = new Font("Segoe UI", 11F);
            chbShowPassword.Location = new Point(494, 327);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(164, 29);
            chbShowPassword.TabIndex = 6;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(chbShowPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            ForeColor = SystemColors.ControlLightLight;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignUp;
        private Label label1;
        private Label label2;
        private CheckBox chbShowPassword;
    }
}
