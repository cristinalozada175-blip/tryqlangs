namespace tryqlangs
{
    partial class MyQrCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyQrCode));
            btnLogin = new Button();
            btnLogOut = new Button();
            btnMyReservation = new Button();
            btnMyQrCode = new Button();
            btnBookRoom = new Button();
            btnProfile = new Button();
            pnlBookingDetails = new Panel();
            pbxQrCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxQrCode).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(692, 441);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Download Qr Code";
            btnLogin.UseVisualStyleBackColor = false;
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
            btnLogOut.TabIndex = 28;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnMyReservation
            // 
            btnMyReservation.BackColor = Color.Transparent;
            btnMyReservation.FlatAppearance.BorderSize = 0;
            btnMyReservation.FlatStyle = FlatStyle.Flat;
            btnMyReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyReservation.ForeColor = Color.White;
            btnMyReservation.Location = new Point(12, 348);
            btnMyReservation.Name = "btnMyReservation";
            btnMyReservation.Size = new Size(190, 37);
            btnMyReservation.TabIndex = 27;
            btnMyReservation.UseVisualStyleBackColor = false;
            // 
            // btnMyQrCode
            // 
            btnMyQrCode.BackColor = Color.Transparent;
            btnMyQrCode.FlatAppearance.BorderSize = 0;
            btnMyQrCode.FlatStyle = FlatStyle.Flat;
            btnMyQrCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyQrCode.ForeColor = Color.White;
            btnMyQrCode.Location = new Point(12, 299);
            btnMyQrCode.Name = "btnMyQrCode";
            btnMyQrCode.Size = new Size(190, 37);
            btnMyQrCode.TabIndex = 26;
            btnMyQrCode.UseVisualStyleBackColor = false;
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
            btnBookRoom.TabIndex = 25;
            btnBookRoom.UseVisualStyleBackColor = false;
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
            btnProfile.TabIndex = 24;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // pnlBookingDetails
            // 
            pnlBookingDetails.BackColor = Color.Transparent;
            pnlBookingDetails.Location = new Point(260, 142);
            pnlBookingDetails.Name = "pnlBookingDetails";
            pnlBookingDetails.Size = new Size(312, 336);
            pnlBookingDetails.TabIndex = 29;
            // 
            // pbxQrCode
            // 
            pbxQrCode.Location = new Point(625, 142);
            pbxQrCode.Name = "pbxQrCode";
            pbxQrCode.Size = new Size(315, 227);
            pbxQrCode.TabIndex = 30;
            pbxQrCode.TabStop = false;
            // 
            // MyQrCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(pbxQrCode);
            Controls.Add(pnlBookingDetails);
            Controls.Add(btnLogOut);
            Controls.Add(btnMyReservation);
            Controls.Add(btnMyQrCode);
            Controls.Add(btnBookRoom);
            Controls.Add(btnProfile);
            Controls.Add(btnLogin);
            Name = "MyQrCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyQrCode";
            ((System.ComponentModel.ISupportInitialize)pbxQrCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnLogOut;
        private Button btnMyReservation;
        private Button btnMyQrCode;
        private Button btnBookRoom;
        private Button btnProfile;
        private Panel pnlBookingDetails;
        private PictureBox pbxQrCode;
    }
}