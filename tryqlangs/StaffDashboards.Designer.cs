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
            btnRoomStatus = new Button();
            btnUsers = new Button();
            btnCheckInCheckOut = new Button();
            btnViewQrCode = new Button();
            dgvRecentReservation = new DataGridView();
            btnReservation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecentReservation).BeginInit();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(10, 352);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(166, 28);
            btnLogOut.TabIndex = 14;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnRoomStatus
            // 
            btnRoomStatus.BackColor = Color.Transparent;
            btnRoomStatus.FlatAppearance.BorderSize = 0;
            btnRoomStatus.FlatStyle = FlatStyle.Flat;
            btnRoomStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomStatus.ForeColor = Color.White;
            btnRoomStatus.Location = new Point(10, 190);
            btnRoomStatus.Margin = new Padding(3, 2, 3, 2);
            btnRoomStatus.Name = "btnRoomStatus";
            btnRoomStatus.Size = new Size(166, 28);
            btnRoomStatus.TabIndex = 13;
            btnRoomStatus.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(10, 154);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(166, 28);
            btnUsers.TabIndex = 11;
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnCheckInCheckOut
            // 
            btnCheckInCheckOut.BackColor = Color.Transparent;
            btnCheckInCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckInCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckInCheckOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckInCheckOut.ForeColor = Color.White;
            btnCheckInCheckOut.Location = new Point(10, 265);
            btnCheckInCheckOut.Margin = new Padding(3, 2, 3, 2);
            btnCheckInCheckOut.Name = "btnCheckInCheckOut";
            btnCheckInCheckOut.Size = new Size(166, 38);
            btnCheckInCheckOut.TabIndex = 10;
            btnCheckInCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnViewQrCode
            // 
            btnViewQrCode.BackColor = Color.Transparent;
            btnViewQrCode.FlatAppearance.BorderSize = 0;
            btnViewQrCode.FlatStyle = FlatStyle.Flat;
            btnViewQrCode.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnViewQrCode.ForeColor = Color.White;
            btnViewQrCode.Location = new Point(439, 356);
            btnViewQrCode.Margin = new Padding(3, 2, 3, 2);
            btnViewQrCode.Name = "btnViewQrCode";
            btnViewQrCode.Size = new Size(166, 22);
            btnViewQrCode.TabIndex = 23;
            btnViewQrCode.Text = "View Details";
            btnViewQrCode.UseVisualStyleBackColor = false;
            // 
            // dgvRecentReservation
            // 
            dgvRecentReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentReservation.Location = new Point(217, 182);
            dgvRecentReservation.Margin = new Padding(3, 2, 3, 2);
            dgvRecentReservation.Name = "dgvRecentReservation";
            dgvRecentReservation.RowHeadersWidth = 51;
            dgvRecentReservation.Size = new Size(608, 169);
            dgvRecentReservation.TabIndex = 24;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(7, 224);
            btnReservation.Margin = new Padding(3, 2, 3, 2);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(166, 28);
            btnReservation.TabIndex = 25;
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // StaffDashboards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 405);
            Controls.Add(btnReservation);
            Controls.Add(dgvRecentReservation);
            Controls.Add(btnViewQrCode);
            Controls.Add(btnLogOut);
            Controls.Add(btnRoomStatus);
            Controls.Add(btnUsers);
            Controls.Add(btnCheckInCheckOut);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffDashboards";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboards";
            Load += StaffDashboards_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecentReservation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogOut;
        private Button btnRoomStatus;
        private Button btnUsers;
        private Button btnCheckInCheckOut;
        private Button btnViewQrCode;
        private DataGridView dgvRecentReservation;
        private Button btnReservation;
    }
}