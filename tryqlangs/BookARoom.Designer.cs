namespace tryqlangs
{
    partial class BookARoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookARoom));
            btnCalculate = new Button();
            txtNumberOfGuest = new TextBox();
            txtTotalAmount = new TextBox();
            btnLogOut = new Button();
            btnBookRoom = new Button();
            btnProfile = new Button();
            dtpCheckInDate = new DateTimePicker();
            dtpCheckOutDate = new DateTimePicker();
            cmbRoomType = new ComboBox();
            btnBookNow = new Button();
            btnSendReceipt = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(260, 411);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(166, 36);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtNumberOfGuest
            // 
            txtNumberOfGuest.BorderStyle = BorderStyle.None;
            txtNumberOfGuest.Font = new Font("Segoe UI", 11F);
            txtNumberOfGuest.Location = new Point(260, 313);
            txtNumberOfGuest.Name = "txtNumberOfGuest";
            txtNumberOfGuest.Size = new Size(349, 25);
            txtNumberOfGuest.TabIndex = 8;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Font = new Font("Segoe UI", 11F);
            txtTotalAmount.Location = new Point(260, 374);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(349, 25);
            txtTotalAmount.TabIndex = 13;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(13, 458);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 37);
            btnLogOut.TabIndex = 18;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.Transparent;
            btnBookRoom.FlatAppearance.BorderSize = 0;
            btnBookRoom.FlatStyle = FlatStyle.Flat;
            btnBookRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookRoom.ForeColor = Color.White;
            btnBookRoom.Location = new Point(13, 246);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(190, 37);
            btnBookRoom.TabIndex = 15;
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
            btnProfile.Location = new Point(13, 194);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(190, 37);
            btnProfile.TabIndex = 14;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(260, 191);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(349, 27);
            dtpCheckInDate.TabIndex = 19;
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Location = new Point(260, 252);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(349, 27);
            dtpCheckOutDate.TabIndex = 20;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Standard Room", "Suite Room", "Deluxe Room" });
            cmbRoomType.Location = new Point(260, 132);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(349, 28);
            cmbRoomType.TabIndex = 21;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // btnBookNow
            // 
            btnBookNow.BackColor = Color.Transparent;
            btnBookNow.FlatAppearance.BorderSize = 0;
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookNow.ForeColor = Color.White;
            btnBookNow.Location = new Point(439, 411);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(166, 36);
            btnBookNow.TabIndex = 22;
            btnBookNow.Text = "Book Now";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click;
            // 
            // btnSendReceipt
            // 
            btnSendReceipt.BackColor = Color.Transparent;
            btnSendReceipt.FlatAppearance.BorderSize = 0;
            btnSendReceipt.FlatStyle = FlatStyle.Flat;
            btnSendReceipt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendReceipt.ForeColor = Color.White;
            btnSendReceipt.Location = new Point(349, 453);
            btnSendReceipt.Name = "btnSendReceipt";
            btnSendReceipt.Size = new Size(166, 36);
            btnSendReceipt.TabIndex = 23;
            btnSendReceipt.Text = "Send Receipt";
            btnSendReceipt.UseVisualStyleBackColor = false;
            btnSendReceipt.Click += btnReceipt_Click;
            // 
            // BookARoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(997, 540);
            Controls.Add(btnSendReceipt);
            Controls.Add(btnBookNow);
            Controls.Add(cmbRoomType);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(dtpCheckInDate);
            Controls.Add(btnLogOut);
            Controls.Add(btnBookRoom);
            Controls.Add(btnProfile);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtNumberOfGuest);
            Controls.Add(btnCalculate);
            Name = "BookARoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookARoom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtRoomType;
        private TextBox txtNumberOfGuest;
        private TextBox txtTotalAmount;
        private Button btnLogOut;
        private Button btnBookRoom;
        private Button btnProfile;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private ComboBox cmbRoomType;
        private Button btnBookNow;
        private Button btnSendReceipt;
    }
}