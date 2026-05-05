namespace tryqlangs
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            btnProfile = new Button();
            btnBookRoom = new Button();
            btnMyQrCode = new Button();
            btnMyReservation = new Button();
            btnLogOut = new Button();
            btnVewDetails = new Button();
            dgvRecentReserve = new DataGridView();
            btnViewQrCode = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecentReserve).BeginInit();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(12, 195);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(190, 37);
            btnProfile.TabIndex = 5;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.Transparent;
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(12, 249);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(190, 37);
            btnBookRoom.TabIndex = 6;
            btnBookRoom.UseVisualStyleBackColor = false;
            // 
            // btnMyQrCode
            // 
            btnMyQrCode.BackColor = Color.Transparent;
            btnMyQrCode.FlatAppearance.BorderSize = 0;
            btnMyQrCode.FlatStyle = FlatStyle.Flat;
            btnMyQrCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyQrCode.ForeColor = Color.White;
            btnMyQrCode.Location = new Point(12, 298);
            btnMyQrCode.Name = "btnMyQrCode";
            btnMyQrCode.Size = new Size(190, 37);
            btnMyQrCode.TabIndex = 7;
            btnMyQrCode.UseVisualStyleBackColor = false;
            btnMyQrCode.Click += btnMyQrCode_Click;
            // 
            // btnMyReservation
            // 
            btnMyReservation.BackColor = Color.Transparent;
            btnMyReservation.FlatAppearance.BorderSize = 0;
            btnMyReservation.FlatStyle = FlatStyle.Flat;
            btnMyReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyReservation.ForeColor = Color.White;
            btnMyReservation.Location = new Point(12, 347);
            btnMyReservation.Name = "btnMyReservation";
            btnMyReservation.Size = new Size(190, 37);
            btnMyReservation.TabIndex = 8;
            btnMyReservation.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(12, 459);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 37);
            btnLogOut.TabIndex = 9;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnVewDetails
            // 
            btnVewDetails.BackColor = Color.Transparent;
            btnVewDetails.FlatAppearance.BorderSize = 0;
            btnVewDetails.FlatStyle = FlatStyle.Flat;
            btnVewDetails.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnVewDetails.ForeColor = Color.White;
            btnVewDetails.Location = new Point(604, 471);
            btnVewDetails.Name = "btnVewDetails";
            btnVewDetails.Size = new Size(190, 30);
            btnVewDetails.TabIndex = 10;
            btnVewDetails.Text = "View Details";
            btnVewDetails.UseVisualStyleBackColor = false;
            btnVewDetails.Click += btnViewQrCode_Click;
            // 
            // dgvRecentReserve
            // 
            dgvRecentReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentReserve.Location = new Point(262, 138);
            dgvRecentReserve.Name = "dgvRecentReserve";
            dgvRecentReserve.RowHeadersWidth = 51;
            dgvRecentReserve.Size = new Size(667, 307);
            dgvRecentReserve.TabIndex = 11;
            // 
            // btnViewQrCode
            // 
            btnViewQrCode.BackColor = Color.Transparent;
            btnViewQrCode.FlatAppearance.BorderSize = 0;
            btnViewQrCode.FlatStyle = FlatStyle.Flat;
            btnViewQrCode.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnViewQrCode.ForeColor = Color.White;
            btnViewQrCode.Location = new Point(400, 470);
            btnViewQrCode.Name = "btnViewQrCode";
            btnViewQrCode.Size = new Size(190, 30);
            btnViewQrCode.TabIndex = 12;
            btnViewQrCode.Text = "View Qr Code";
            btnViewQrCode.UseVisualStyleBackColor = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(btnViewQrCode);
            Controls.Add(dgvRecentReserve);
            Controls.Add(btnVewDetails);
            Controls.Add(btnLogOut);
            Controls.Add(btnMyReservation);
            Controls.Add(btnMyQrCode);
            Controls.Add(btnBookRoom);
            Controls.Add(btnProfile);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecentReserve).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfile;
        private Button btnBookRoom;
        private Button btnMyQrCode;
        private Button btnMyReservation;
        private Button btnLogOut;
        private Button btnVewDetails;
        private DataGridView dgvRecentReserve;
        private Button btnViewQrCode;
    }
}