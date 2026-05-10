namespace tryqlangs
{
    partial class UserDashboards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboards));
            dgvReservations = new DataGridView();
            btnMyReservation = new Button();
            btnLogOut = new Button();
            btnBookRoom = new Button();
            btnProfile = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(253, 125);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(694, 377);
            dgvReservations.TabIndex = 25;
            dgvReservations.CellContentClick += dgvReservations_CellContentClick;
            // 
            // btnMyReservation
            // 
            btnMyReservation.BackColor = Color.Transparent;
            btnMyReservation.FlatAppearance.BorderSize = 0;
            btnMyReservation.FlatStyle = FlatStyle.Flat;
            btnMyReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyReservation.ForeColor = Color.White;
            btnMyReservation.Location = new Point(12, 300);
            btnMyReservation.Name = "btnMyReservation";
            btnMyReservation.Size = new Size(190, 37);
            btnMyReservation.TabIndex = 29;
            btnMyReservation.UseVisualStyleBackColor = false;
            btnMyReservation.Click += btnMyReservation_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(12, 457);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 37);
            btnLogOut.TabIndex = 28;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.Transparent;
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(12, 245);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(190, 37);
            btnBookRoom.TabIndex = 27;
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
            btnProfile.Location = new Point(12, 193);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(190, 37);
            btnProfile.TabIndex = 26;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(776, 82);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(168, 37);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UserDashboards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(btnRefresh);
            Controls.Add(btnMyReservation);
            Controls.Add(btnLogOut);
            Controls.Add(btnBookRoom);
            Controls.Add(btnProfile);
            Controls.Add(dgvReservations);
            Name = "UserDashboards";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboards";
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReservations;
        private Button btnMyReservation;
        private Button btnLogOut;
        private Button btnBookRoom;
        private Button btnProfile;
        private Button btnRefresh;
    }
}