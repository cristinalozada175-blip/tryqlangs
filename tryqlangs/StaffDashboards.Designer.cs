namespace tryqlangs
{
    partial class StaffDashboards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboards));
            btnLogOut = new Button();
            btnMyQrCode = new Button();
            btnBookRoom = new Button();
            btnReservation = new Button();
            btnProfile = new Button();
            btnViewQrCode = new Button();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(12, 463);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 37);
            btnLogOut.TabIndex = 14;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnMyQrCode
            // 
            btnMyQrCode.BackColor = Color.Transparent;
            btnMyQrCode.FlatAppearance.BorderSize = 0;
            btnMyQrCode.FlatStyle = FlatStyle.Flat;
            btnMyQrCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyQrCode.ForeColor = Color.White;
            btnMyQrCode.Location = new Point(12, 351);
            btnMyQrCode.Name = "btnMyQrCode";
            btnMyQrCode.Size = new Size(190, 37);
            btnMyQrCode.TabIndex = 13;
            btnMyQrCode.UseVisualStyleBackColor = false;
            // 
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.Transparent;
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(12, 302);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(190, 37);
            btnBookRoom.TabIndex = 12;
            btnBookRoom.UseVisualStyleBackColor = false;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(12, 253);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(190, 37);
            btnReservation.TabIndex = 11;
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(12, 199);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(190, 37);
            btnProfile.TabIndex = 10;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnViewQrCode
            // 
            btnViewQrCode.BackColor = Color.Transparent;
            btnViewQrCode.FlatAppearance.BorderSize = 0;
            btnViewQrCode.FlatStyle = FlatStyle.Flat;
            btnViewQrCode.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnViewQrCode.ForeColor = Color.White;
            btnViewQrCode.Location = new Point(502, 474);
            btnViewQrCode.Name = "btnViewQrCode";
            btnViewQrCode.Size = new Size(190, 30);
            btnViewQrCode.TabIndex = 23;
            btnViewQrCode.Text = "View Details";
            btnViewQrCode.UseVisualStyleBackColor = false;
            // 
            // StaffDashboards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(btnViewQrCode);
            Controls.Add(btnLogOut);
            Controls.Add(btnMyQrCode);
            Controls.Add(btnBookRoom);
            Controls.Add(btnReservation);
            Controls.Add(btnProfile);
            Name = "StaffDashboards";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboards";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogOut;
        private Button btnMyQrCode;
        private Button btnBookRoom;
        private Button btnReservation;
        private Button btnProfile;
        private Button btnViewQrCode;
    }
}