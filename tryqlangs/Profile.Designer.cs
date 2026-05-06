namespace tryqlangs
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            btnLogOut = new Button();
            btnMyReservation = new Button();
            btnBookRoom = new Button();
            btnProfile = new Button();
            txtFullName = new TextBox();
            txtEmailAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEnterPassword = new TextBox();
            chbShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(12, 460);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 37);
            btnLogOut.TabIndex = 23;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnMyReservation
            // 
            btnMyReservation.BackColor = Color.Transparent;
            btnMyReservation.FlatAppearance.BorderSize = 0;
            btnMyReservation.FlatStyle = FlatStyle.Flat;
            btnMyReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyReservation.ForeColor = Color.White;
            btnMyReservation.Location = new Point(3, 299);
            btnMyReservation.Name = "btnMyReservation";
            btnMyReservation.Size = new Size(190, 37);
            btnMyReservation.TabIndex = 22;
            btnMyReservation.UseVisualStyleBackColor = false;
            btnMyReservation.Click += btnMyReservation_Click;
            // 
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.Transparent;
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(12, 250);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(190, 37);
            btnBookRoom.TabIndex = 20;
            btnBookRoom.UseVisualStyleBackColor = false;
            btnBookRoom.Click += btnBookRoom_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(12, 196);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(190, 37);
            btnProfile.TabIndex = 19;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(656, 226);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter Full Name";
            txtFullName.Size = new Size(290, 25);
            txtFullName.TabIndex = 26;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.None;
            txtEmailAddress.Font = new Font("Segoe UI", 11F);
            txtEmailAddress.Location = new Point(656, 267);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "Enter Email Address";
            txtEmailAddress.Size = new Size(290, 25);
            txtEmailAddress.TabIndex = 27;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 11F);
            txtPhoneNumber.Location = new Point(656, 306);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter Phone Number";
            txtPhoneNumber.Size = new Size(290, 25);
            txtPhoneNumber.TabIndex = 28;
            // 
            // txtEnterPassword
            // 
            txtEnterPassword.BorderStyle = BorderStyle.None;
            txtEnterPassword.Font = new Font("Segoe UI", 11F);
            txtEnterPassword.Location = new Point(656, 347);
            txtEnterPassword.Name = "txtEnterPassword";
            txtEnterPassword.PlaceholderText = "Enter Password";
            txtEnterPassword.Size = new Size(290, 25);
            txtEnterPassword.TabIndex = 29;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Transparent;
            chbShowPassword.Font = new Font("Segoe UI", 10F);
            chbShowPassword.ForeColor = Color.White;
            chbShowPassword.Location = new Point(641, 384);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(148, 27);
            chbShowPassword.TabIndex = 30;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(chbShowPassword);
            Controls.Add(txtEnterPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtFullName);
            Controls.Add(btnLogOut);
            Controls.Add(btnMyReservation);
            Controls.Add(btnBookRoom);
            Controls.Add(btnProfile);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnMyReservation;
        private Button btnBookRoom;
        private Button btnProfile;
        private TextBox txtFullName;
        private TextBox txtEmailAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtEnterPassword;
        private CheckBox chbShowPassword;
    }
}