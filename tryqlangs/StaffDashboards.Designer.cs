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
            dgvRecentReservation = new DataGridView();
            btnReservation = new Button();
            btnRefresh = new Button();
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
            btnLogOut.Location = new Point(11, 469);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 37);
            btnLogOut.TabIndex = 14;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRoomStatus
            // 
            btnRoomStatus.BackColor = Color.Transparent;
            btnRoomStatus.FlatAppearance.BorderSize = 0;
            btnRoomStatus.FlatStyle = FlatStyle.Flat;
            btnRoomStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomStatus.ForeColor = Color.White;
            btnRoomStatus.Location = new Point(11, 253);
            btnRoomStatus.Name = "btnRoomStatus";
            btnRoomStatus.Size = new Size(190, 37);
            btnRoomStatus.TabIndex = 13;
            btnRoomStatus.UseVisualStyleBackColor = false;
            btnRoomStatus.Click += btnRoomStatus_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(11, 205);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(190, 37);
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
            btnCheckInCheckOut.Location = new Point(11, 353);
            btnCheckInCheckOut.Name = "btnCheckInCheckOut";
            btnCheckInCheckOut.Size = new Size(190, 51);
            btnCheckInCheckOut.TabIndex = 10;
            btnCheckInCheckOut.UseVisualStyleBackColor = false;
            btnCheckInCheckOut.Click += btnCheckInCheckOut_Click;
            // 
            // dgvRecentReservation
            // 
            dgvRecentReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentReservation.Location = new Point(248, 121);
            dgvRecentReservation.Name = "dgvRecentReservation";
            dgvRecentReservation.RowHeadersWidth = 51;
            dgvRecentReservation.Size = new Size(704, 385);
            dgvRecentReservation.TabIndex = 24;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(8, 299);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(190, 37);
            btnReservation.TabIndex = 25;
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LimeGreen;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(817, 79);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(134, 38);
            btnRefresh.TabIndex = 26;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // StaffDashboards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(btnRefresh);
            Controls.Add(btnReservation);
            Controls.Add(dgvRecentReservation);
            Controls.Add(btnLogOut);
            Controls.Add(btnRoomStatus);
            Controls.Add(btnUsers);
            Controls.Add(btnCheckInCheckOut);
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
        private DataGridView dgvRecentReservation;
        private Button btnReservation;
        private Button btnRefresh;
    }
}