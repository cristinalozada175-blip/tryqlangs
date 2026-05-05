namespace tryqlangs
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btnLogin = new Button();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtMobileNumber = new TextBox();
            txtPassword = new TextBox();
            txtEmailID = new TextBox();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(732, 389);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(502, 389);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(190, 37);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(627, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "👤Username";
            txtUsername.Size = new Size(295, 25);
            txtUsername.TabIndex = 5;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.BorderStyle = BorderStyle.None;
            txtMobileNumber.Font = new Font("Segoe UI", 11F);
            txtMobileNumber.Location = new Point(627, 220);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.PlaceholderText = "✆ Mobile Number";
            txtMobileNumber.Size = new Size(295, 25);
            txtMobileNumber.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(627, 297);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "🔒 Password";
            txtPassword.Size = new Size(295, 25);
            txtPassword.TabIndex = 8;
            // 
            // txtEmailID
            // 
            txtEmailID.BorderStyle = BorderStyle.None;
            txtEmailID.Font = new Font("Segoe UI", 11F);
            txtEmailID.Location = new Point(627, 257);
            txtEmailID.Name = "txtEmailID";
            txtEmailID.PlaceholderText = "✉ Email ID";
            txtEmailID.Size = new Size(295, 25);
            txtEmailID.TabIndex = 7;
            // 
            // cmbRole
            // 
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "customer", "staff", "admin" });
            cmbRole.Location = new Point(627, 335);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(295, 28);
            cmbRole.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailID);
            Controls.Add(txtMobileNumber);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtUsername;
        private TextBox txtMobileNumber;
        private TextBox txtPassword;
        private TextBox txtEmailID;
        private ComboBox cmbRole;
    }
}