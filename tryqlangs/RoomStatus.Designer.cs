namespace tryqlangs
{
    partial class RoomStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomStatus));
            dgvRoomStatus = new DataGridView();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnRefresh = new Button();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            txtRoomType = new TextBox();
            txtTotalAmount = new TextBox();
            txtNumberOfGuest = new TextBox();
            txtSearch = new TextBox();
            btnDelete = new Button();
            txtRoomStatus = new Button();
            btnReservation = new Button();
            btnCheckInOut = new Button();
            btnLogOut = new Button();
            cmbStatus = new ComboBox();
            txtRoomNumber = new TextBox();
            btnUpdateRoomNumber = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoomStatus).BeginInit();
            SuspendLayout();
            // 
            // dgvRoomStatus
            // 
            dgvRoomStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomStatus.Location = new Point(235, 168);
            dgvRoomStatus.Name = "dgvRoomStatus";
            dgvRoomStatus.RowHeadersWidth = 51;
            dgvRoomStatus.Size = new Size(351, 333);
            dgvRoomStatus.TabIndex = 0;
            dgvRoomStatus.CellClick += dgvRoomStatus_CellClick;
            dgvRoomStatus.CellContentClick += dgvRoomStatus_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(806, 470);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 30);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(460, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 34);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(460, 89);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 34);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Segoe UI", 14F);
            dtpCheckOut.Location = new Point(638, 256);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(326, 27);
            dtpCheckOut.TabIndex = 28;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Segoe UI", 14F);
            dtpCheckIn.Location = new Point(637, 198);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(326, 27);
            dtpCheckIn.TabIndex = 27;
            // 
            // txtRoomType
            // 
            txtRoomType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomType.Location = new Point(638, 140);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(325, 30);
            txtRoomType.TabIndex = 29;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(640, 368);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(326, 30);
            txtTotalAmount.TabIndex = 30;
            // 
            // txtNumberOfGuest
            // 
            txtNumberOfGuest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfGuest.Location = new Point(637, 310);
            txtNumberOfGuest.Name = "txtNumberOfGuest";
            txtNumberOfGuest.Size = new Size(326, 30);
            txtNumberOfGuest.TabIndex = 30;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(235, 124);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(219, 30);
            txtSearch.TabIndex = 31;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(653, 471);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 30);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtRoomStatus
            // 
            txtRoomStatus.BackColor = Color.Transparent;
            txtRoomStatus.BackgroundImageLayout = ImageLayout.Center;
            txtRoomStatus.FlatAppearance.BorderSize = 0;
            txtRoomStatus.FlatStyle = FlatStyle.Flat;
            txtRoomStatus.Location = new Point(3, 226);
            txtRoomStatus.Name = "txtRoomStatus";
            txtRoomStatus.Size = new Size(204, 33);
            txtRoomStatus.TabIndex = 33;
            txtRoomStatus.UseVisualStyleBackColor = false;
            txtRoomStatus.Click += txtRoomStatus_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.BackgroundImageLayout = ImageLayout.Center;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Location = new Point(3, 274);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(204, 33);
            btnReservation.TabIndex = 34;
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnCheckInOut
            // 
            btnCheckInOut.BackColor = Color.Transparent;
            btnCheckInOut.BackgroundImageLayout = ImageLayout.Center;
            btnCheckInOut.FlatAppearance.BorderSize = 0;
            btnCheckInOut.FlatStyle = FlatStyle.Flat;
            btnCheckInOut.Location = new Point(3, 323);
            btnCheckInOut.Name = "btnCheckInOut";
            btnCheckInOut.Size = new Size(204, 53);
            btnCheckInOut.TabIndex = 35;
            btnCheckInOut.UseVisualStyleBackColor = false;
            btnCheckInOut.Click += btnCheckInOut_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImageLayout = ImageLayout.Center;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(3, 443);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(204, 42);
            btnLogOut.TabIndex = 36;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Checked-In", "Cancelled", "Checked-Out" });
            cmbStatus.Location = new Point(640, 424);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(161, 31);
            cmbStatus.TabIndex = 37;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(806, 424);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(94, 30);
            txtRoomNumber.TabIndex = 38;
            // 
            // btnUpdateRoomNumber
            // 
            btnUpdateRoomNumber.BackColor = Color.CadetBlue;
            btnUpdateRoomNumber.FlatAppearance.BorderSize = 0;
            btnUpdateRoomNumber.FlatStyle = FlatStyle.Flat;
            btnUpdateRoomNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateRoomNumber.ForeColor = Color.White;
            btnUpdateRoomNumber.Location = new Point(900, 424);
            btnUpdateRoomNumber.Name = "btnUpdateRoomNumber";
            btnUpdateRoomNumber.Size = new Size(75, 30);
            btnUpdateRoomNumber.TabIndex = 39;
            btnUpdateRoomNumber.Text = "Update";
            btnUpdateRoomNumber.UseVisualStyleBackColor = false;
            btnUpdateRoomNumber.Click += btnUpdateRoomNumber_Click;
            // 
            // RoomStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(btnUpdateRoomNumber);
            Controls.Add(txtRoomNumber);
            Controls.Add(cmbStatus);
            Controls.Add(btnLogOut);
            Controls.Add(btnCheckInOut);
            Controls.Add(btnReservation);
            Controls.Add(txtRoomStatus);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(txtNumberOfGuest);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtRoomType);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(dgvRoomStatus);
            Name = "RoomStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomStatus";
            Load += RoomStatus_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoomStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRoomStatus;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnRefresh;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private TextBox txtRoomType;
        private TextBox txtTotalAmount;
        private TextBox txtNumberOfGuest;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button txtRoomStatus;
        private Button btnReservation;
        private Button btnCheckInOut;
        private Button btnLogOut;
        private ComboBox cmbStatus;
        private TextBox txtRoomNumber;
        private Button btnUpdateRoomNumber;
    }
}