namespace tryqlangs
{
    partial class CheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOut));
            btnUsers = new Button();
            btnRoomStatus = new Button();
            btnReservation = new Button();
            btnCheckInOut = new Button();
            button4 = new Button();
            btnVewDetails = new Button();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            txtGuestName = new TextBox();
            txtContactNumber = new TextBox();
            txtRoomNumber = new TextBox();
            txtEmail = new TextBox();
            txtRoomType = new TextBox();
            txtReservationId = new TextBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            dgvSummary = new DataGridView();
            txtNight = new TextBox();
            label1 = new Label();
            cmbPaymentStatus = new ComboBox();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(19, 205);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(190, 37);
            btnUsers.TabIndex = 7;
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnRoomStatus
            // 
            btnRoomStatus.BackColor = Color.Transparent;
            btnRoomStatus.FlatAppearance.BorderSize = 0;
            btnRoomStatus.FlatStyle = FlatStyle.Flat;
            btnRoomStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomStatus.ForeColor = Color.White;
            btnRoomStatus.Location = new Point(19, 251);
            btnRoomStatus.Name = "btnRoomStatus";
            btnRoomStatus.Size = new Size(190, 37);
            btnRoomStatus.TabIndex = 8;
            btnRoomStatus.UseVisualStyleBackColor = false;
            btnRoomStatus.Click += btnRoomStatus_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(19, 300);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(190, 37);
            btnReservation.TabIndex = 9;
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnCheckInOut
            // 
            btnCheckInOut.BackColor = Color.Transparent;
            btnCheckInOut.FlatAppearance.BorderSize = 0;
            btnCheckInOut.FlatStyle = FlatStyle.Flat;
            btnCheckInOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckInOut.ForeColor = Color.White;
            btnCheckInOut.Location = new Point(15, 351);
            btnCheckInOut.Name = "btnCheckInOut";
            btnCheckInOut.Size = new Size(190, 54);
            btnCheckInOut.TabIndex = 10;
            btnCheckInOut.UseVisualStyleBackColor = false;
            btnCheckInOut.Click += btnCheckInOut_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(19, 472);
            button4.Name = "button4";
            button4.Size = new Size(190, 37);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnVewDetails
            // 
            btnVewDetails.BackColor = Color.Transparent;
            btnVewDetails.FlatAppearance.BorderSize = 0;
            btnVewDetails.FlatStyle = FlatStyle.Flat;
            btnVewDetails.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnVewDetails.ForeColor = Color.White;
            btnVewDetails.Location = new Point(245, 177);
            btnVewDetails.Name = "btnVewDetails";
            btnVewDetails.Size = new Size(190, 30);
            btnVewDetails.TabIndex = 12;
            btnVewDetails.Text = "View Details";
            btnVewDetails.UseVisualStyleBackColor = false;
            btnVewDetails.Click += btnVewDetails_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.Transparent;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(509, 470);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(190, 30);
            btnCheckIn.TabIndex = 13;
            btnCheckIn.Text = "➜] Check-In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Transparent;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(768, 469);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(190, 30);
            btnCheckOut.TabIndex = 14;
            btnCheckOut.Text = "➜] Check-Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // txtGuestName
            // 
            txtGuestName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestName.Location = new Point(494, 137);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(217, 30);
            txtGuestName.TabIndex = 15;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.Location = new Point(494, 203);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(217, 30);
            txtContactNumber.TabIndex = 16;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(494, 336);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(217, 30);
            txtRoomNumber.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(494, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 30);
            txtEmail.TabIndex = 21;
            // 
            // txtRoomType
            // 
            txtRoomType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomType.Location = new Point(494, 400);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(217, 30);
            txtRoomType.TabIndex = 23;
            // 
            // txtReservationId
            // 
            txtReservationId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReservationId.Location = new Point(230, 137);
            txtReservationId.Name = "txtReservationId";
            txtReservationId.Size = new Size(223, 30);
            txtReservationId.TabIndex = 24;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Segoe UI", 14F);
            dtpCheckIn.Location = new Point(754, 138);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(217, 27);
            dtpCheckIn.TabIndex = 25;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Segoe UI", 14F);
            dtpCheckOut.Location = new Point(755, 204);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(217, 27);
            dtpCheckOut.TabIndex = 26;
            // 
            // dgvSummary
            // 
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(222, 239);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new Size(239, 270);
            dgvSummary.TabIndex = 27;
            dgvSummary.CellContentClick += dgvSummary_CellClick;
            // 
            // txtNight
            // 
            txtNight.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNight.Location = new Point(755, 270);
            txtNight.Name = "txtNight";
            txtNight.Size = new Size(217, 30);
            txtNight.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(755, 371);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 29;
            label1.Text = "Payment Status: ";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Paid", "Pending", "Failed" });
            cmbPaymentStatus.Location = new Point(754, 402);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(217, 31);
            cmbPaymentStatus.TabIndex = 30;
            cmbPaymentStatus.SelectedIndexChanged += cmbPaymentStatus_SelectedIndexChanged_1;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Checked-In", "Cancelled", "Checked-Out" });
            cmbStatus.Location = new Point(754, 335);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(217, 31);
            cmbStatus.TabIndex = 31;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // CheckInOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 540);
            Controls.Add(cmbStatus);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label1);
            Controls.Add(txtNight);
            Controls.Add(dgvSummary);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(txtReservationId);
            Controls.Add(txtRoomType);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNumber);
            Controls.Add(txtGuestName);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnVewDetails);
            Controls.Add(button4);
            Controls.Add(btnCheckInOut);
            Controls.Add(btnReservation);
            Controls.Add(btnRoomStatus);
            Controls.Add(btnUsers);
            Name = "CheckInOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckInOut";
            Load += CheckInOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsers;
        private Button btnRoomStatus;
        private Button btnReservation;
        private Button btnCheckInOut;
        private Button button4;
        private Button btnVewDetails;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private TextBox txtGuestName;
        private TextBox txtContactNumber;
        private TextBox txtRoomNumber;
        private TextBox txtEmail;
        private TextBox txtRoomType;
        private TextBox txtReservationId;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private DataGridView dgvSummary;
        private TextBox txtNight;
        private Label label1;
        private ComboBox cmbPaymentStatus;
        private ComboBox cmbStatus;
    }
}