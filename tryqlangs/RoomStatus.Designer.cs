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
            txtStatus = new TextBox();
            txtTotalAmount = new TextBox();
            txtMNumberOfGuest = new TextBox();
            txtSearch = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoomStatus).BeginInit();
            SuspendLayout();
            // 
            // dgvRoomStatus
            // 
            dgvRoomStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomStatus.Location = new Point(240, 168);
            dgvRoomStatus.Name = "dgvRoomStatus";
            dgvRoomStatus.RowHeadersWidth = 51;
            dgvRoomStatus.Size = new Size(414, 333);
            dgvRoomStatus.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(744, 429);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(174, 30);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(502, 126);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 34);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(502, 92);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(152, 34);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Segoe UI", 14F);
            dtpCheckOut.Location = new Point(710, 270);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(253, 27);
            dtpCheckOut.TabIndex = 28;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Segoe UI", 14F);
            dtpCheckIn.Location = new Point(709, 204);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(253, 27);
            dtpCheckIn.TabIndex = 27;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(710, 143);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(252, 30);
            txtStatus.TabIndex = 29;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(712, 389);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(253, 30);
            txtTotalAmount.TabIndex = 30;
            // 
            // txtMNumberOfGuest
            // 
            txtMNumberOfGuest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMNumberOfGuest.Location = new Point(709, 326);
            txtMNumberOfGuest.Name = "txtMNumberOfGuest";
            txtMNumberOfGuest.Size = new Size(253, 30);
            txtMNumberOfGuest.TabIndex = 30;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(240, 126);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(256, 30);
            txtSearch.TabIndex = 31;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(743, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 30);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // RoomStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(txtMNumberOfGuest);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtStatus);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(dgvRoomStatus);
            Name = "RoomStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomStatus";
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
        private TextBox txtStatus;
        private TextBox txtTotalAmount;
        private TextBox txtMNumberOfGuest;
        private TextBox txtSearch;
        private Button btnDelete;
    }
}