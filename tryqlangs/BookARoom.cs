using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tryqlangs
{
    public partial class BookARoom : Form
    {
        bool isCalculated = false;
        decimal calculatedTotal = 0;
        public BookARoom()
        {
            InitializeComponent();
        }



        // ================= PRICE CALCULATION =================
        private void CalculateTotalPrice()
        {
            if (cmbRoomType.Text == "" ||
        dtpCheckOutDate.Value.Date <= dtpCheckInDate.Value.Date)
            {
                txtTotalAmount.Text = "";
                calculatedTotal = 0;
                isCalculated = false; // ✅ VERY IMPORTANT
                return;
            }

            decimal pricePerNight = 0;

            if (cmbRoomType.Text == "Standard Room")
                pricePerNight = 3500;
            else if (cmbRoomType.Text == "Suite Room")
                pricePerNight = 5000;
            else if (cmbRoomType.Text == "Deluxe Room")
                pricePerNight = 10000;

            int nights = (dtpCheckOutDate.Value.Date - dtpCheckInDate.Value.Date).Days;
            calculatedTotal = pricePerNight * nights;

            txtTotalAmount.Text = calculatedTotal.ToString("F2");
        }

        // ✅ GET room_id FROM DATABASE (NO HARDCODE)
        private int GetRoomIdFromDatabase(string roomType)
        {
            int roomId = 0;

            DbConnect.DBConnect db = new DbConnect.DBConnect();
            MySqlConnection con = db.Connection;

            string query = "SELECT room_id FROM roomstbl WHERE room_type = @type LIMIT 1";

            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@type", roomType);

                db.Open();
                object result = cmd.ExecuteScalar();
                db.Close();

                if (result != null)
                    roomId = Convert.ToInt32(result);
            }

            return roomId;
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCalculated = false; // ❗ reset

            if (cmbRoomType.Text == "Standard Room")
                txtNumberOfGuest.Text = "2";
            else if (cmbRoomType.Text == "Suite Room")
                txtNumberOfGuest.Text = "4";
            else if (cmbRoomType.Text == "Deluxe Room")
                txtNumberOfGuest.Text = "6";
            else
                txtNumberOfGuest.Text = "";

            CalculateTotalPrice(); // optional (UI update only)
        }


        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            isCalculated = false; // ❗ reset
            CalculateTotalPrice();
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            isCalculated = false; // ❗ reset
            CalculateTotalPrice();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            // VALIDATION
            if (cmbRoomType.Text == "" || txtNumberOfGuest.Text == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (dtpCheckInDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Check-in cannot be in the past.");
                return;
            }

            if (dtpCheckOutDate.Value.Date <= dtpCheckInDate.Value.Date)
            {
                MessageBox.Show("Check-out must be after check-in.");
                return;
            }

            // GUEST LIMIT
            int guestLimit = 0;

            if (cmbRoomType.Text == "Standard Room") guestLimit = 2;
            else if (cmbRoomType.Text == "Suite Room") guestLimit = 4;
            else if (cmbRoomType.Text == "Deluxe Room") guestLimit = 6;

            int guestCount = Convert.ToInt32(txtNumberOfGuest.Text);

            if (guestCount > guestLimit)
            {
                MessageBox.Show($"This room allows only {guestLimit} guests.");
                return;
            }

            if (!isCalculated)
            {
                MessageBox.Show("Please click CALCULATE first before booking.");
                return;
            }

            // CALCULATE PRICE


            decimal totalPrice = calculatedTotal;

            if (totalPrice <= 0)
            {
                MessageBox.Show("Invalid total price.");
                return;
            }

            // ✅ GET room_id dynamically
            int roomId = GetRoomIdFromDatabase(cmbRoomType.Text);

            if (roomId == 0)
            {
                MessageBox.Show("Room not found in database.");
                return;
            }

            // ⚠️ TEMP USER (replace later with logged-in user)
            int userId = 1;

            // ================= SAVE TO DATABASE =================
            try
            {
                DbConnect.DBConnect db = new DbConnect.DBConnect();
                MySqlConnection con = db.Connection;

                string query = @"INSERT INTO reservationstbl 
                    (check_in, check_out, status, room_id, user_id, total_amount)
                    VALUES
                    (@checkin, @checkout, @status, @roomid, @userid, @total)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@checkin", dtpCheckInDate.Value.Date);
                    cmd.Parameters.AddWithValue("@checkout", dtpCheckOutDate.Value.Date);
                    cmd.Parameters.AddWithValue("@status", "upcoming");
                    cmd.Parameters.AddWithValue("@roomid", roomId);
                    cmd.Parameters.AddWithValue("@userid", userId);
                    cmd.Parameters.AddWithValue("@total", totalPrice);


                    db.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    db.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            $"Booked Successfully!\nTotal Price: ₱{totalPrice}",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        cmbRoomType.SelectedIndex = -1;
                        txtNumberOfGuest.Clear();
                        txtTotalAmount.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Booking failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
            isCalculated = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookARoom bookARoom = new BookARoom();
            bookARoom.Show();
            this.Hide();
        }

        

        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboard Userdashboard = new UserDashboard();
            Userdashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

        }
    }
}