using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static tryqlangs.DbConnect;

namespace tryqlangs
{
    public partial class RoomStatus : Form
    {
        DBConnect db = new DBConnect();

        public RoomStatus()
        {
            InitializeComponent();
            LoadReservations();
        }

        private void LoadReservations()
        {
            try
            {
                db.Open();

                string query = @" 
                    SELECT 
    r.reservation_id,
    r.check_in,
    r.check_out,
    r.status,
    r.night,
    r.total_amount,
    r.room_number,

    rm.room_id,

    rm.room_type,
    rm.price,
    rm.guest_limit

                FROM reservationstbl r

                INNER JOIN roomstbl rm 
                    ON r.room_id = rm.room_id

                WHERE 
                    CAST(r.reservation_id AS CHAR) LIKE @search
                    OR CAST(r.room_number AS CHAR) LIKE @search

                ORDER BY r.reservation_id DESC";

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text.Trim() + "%"
                );

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRoomStatus.DataSource = table;

                dgvRoomStatus.Columns["reservation_id"].HeaderText = "Reservation ID";
                dgvRoomStatus.Columns["room_number"].HeaderText = "Room Number";
                dgvRoomStatus.Columns["room_type"].HeaderText = "Room Type";
                dgvRoomStatus.Columns["check_in"].HeaderText = "Check In";
                dgvRoomStatus.Columns["check_out"].HeaderText = "Check Out";
                dgvRoomStatus.Columns["night"].HeaderText = "Nights";
                dgvRoomStatus.Columns["total_amount"].HeaderText = "Total Amount";
                dgvRoomStatus.Columns["price"].HeaderText = "Room Price";
                dgvRoomStatus.Columns["status"].HeaderText = "Reservation Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }


        }

        private void txtRoomStatus_Click(object sender, EventArgs e)
        {
            RoomStatus roomStatus = new RoomStatus();
            roomStatus.Show();
            this.Close();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            StaffDashboards staffDashboards = new StaffDashboards();
            staffDashboards.Show();
            this.Close();
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            CheckInOut checkInOut = new CheckInOut();
            checkInOut.Show();
            this.Close();
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

        private void RoomStatus_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("PENDING");
            cmbStatus.Items.Add("CHECKED-IN");
            cmbStatus.Items.Add("CHECKED-OUT");
            cmbStatus.Items.Add("CANCELLED");

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void dgvRoomStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvRoomStatus.Rows[e.RowIndex];

            txtSearch.Text = row.Cells["reservation_id"].Value?.ToString();
            txtRoomType.Text = row.Cells["room_type"].Value?.ToString();
            txtRoomNumber.Text = row.Cells["room_number"].Value?.ToString();
            cmbStatus.Text = row.Cells["status"].Value?.ToString();
            txtNumberOfGuest.Text =
            Convert.ToInt32(row.Cells["night"].Value ?? 0).ToString();
            txtTotalAmount.Text = row.Cells["total_amount"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["check_in"].Value?.ToString(), out DateTime inDate))
                dtpCheckIn.Value = inDate;

            if (DateTime.TryParse(row.Cells["check_out"].Value?.ToString(), out DateTime outDate))
                dtpCheckOut.Value = outDate;
        }
        private int GetRoomId(string roomType)
        {
            int roomId = 0;

            try
            {
                db.Open();

                string query =
                    "SELECT room_id FROM roomstbl WHERE room_type=@type LIMIT 1";

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@type", roomType);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    roomId = Convert.ToInt32(result);
                }
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }

            return roomId;
        }

        private void CalculateTotalAmount()
        {
            if (string.IsNullOrWhiteSpace(txtRoomType.Text))
                return;

            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;

            if (checkOut <= checkIn)
            {
                txtTotalAmount.Text = "0.00";
                txtNumberOfGuest.Text = "0";
                return;
            }

            int nights = (checkOut - checkIn).Days;

            txtNumberOfGuest.Text = nights.ToString();

            try
            {
                db.Open();

                string query =
                    "SELECT price FROM roomstbl WHERE room_type=@roomtype";

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue(
                    "@roomtype",
                    txtRoomType.Text.Trim()
                );

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal price =
                        Convert.ToDecimal(result);

                    decimal total = price * nights;

                    txtTotalAmount.Text =
                        total.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Calculation error: " + ex.Message
                );
            }
            finally
            {
                db.Close();
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(
        txtNumberOfGuest.Text,
        out int night))
            {
                MessageBox.Show("Invalid number of nights.");
                return;
            }

            if (!decimal.TryParse(
                txtTotalAmount.Text,
                out decimal amount))
            {
                MessageBox.Show("Invalid total amount.");
                return;
            }

            int roomId =
                GetRoomId(txtRoomType.Text.Trim());

            if (roomId == 0)
            {
                MessageBox.Show("Room not found.");
                return;
            }

            try
            {
                db.Open();

                MySqlCommand cmd;

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    string updateQuery = @"
UPDATE reservationstbl SET
    room_id=@roomid,
    check_in=@checkin,
    check_out=@checkout,
    night=@night,
    total_amount=@amount,
    room_number=@room_number,
    status=@status
WHERE reservation_id=@id";

                    cmd = new MySqlCommand(updateQuery, db.Connection);

                    cmd.Parameters.AddWithValue("@id", txtSearch.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                }

                else
                {
                    string insertQuery = @"
            INSERT INTO reservationstbl
            (
                room_id,
                check_in,
                check_out,
                status,
                night,
                total_amount,
                room_number
            )
            VALUES
            (
                @roomid,
                @checkin,
                @checkout,
                @status,
                @night,
                @amount,
                @room_number
            )";

                    cmd = new MySqlCommand(insertQuery, db.Connection);

                    cmd.Parameters.AddWithValue("@status", "Reserved");
                }

                cmd.Parameters.AddWithValue("@roomid", roomId);
                cmd.Parameters.AddWithValue("@checkin", dtpCheckIn.Value.Date);
                cmd.Parameters.AddWithValue("@checkout", dtpCheckOut.Value.Date);
                cmd.Parameters.AddWithValue("@night", night);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@room_number", txtRoomNumber.Text.Trim());

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Saved successfully!");

                    LoadReservations();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Operation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Delete this reservation?",
                "Confirm",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                return;

            try
            {
                db.Open();

                string query =
                    "DELETE FROM reservationstbl WHERE reservation_id=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtSearch.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@room_number",
                    txtRoomNumber.Text.Trim()
                );

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Deleted!");

                    LoadReservations();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete error: " + ex.Message
                );
            }
            finally
            {
                db.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadReservations();
            ClearFields();
        }

        private void ClearFields()
        {
            txtSearch.Clear();

            txtRoomType.Clear();
            txtNumberOfGuest.Clear();
            txtTotalAmount.Clear();

            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
        }

        private void btnUpdateRoomNumber_Click(object sender, EventArgs e)
        {
            if (!IsRoomNumberAvailable(
                txtRoomNumber.Text.Trim(),
                txtSearch.Text.Trim()))
            {
                MessageBox.Show("Room number is already occupied.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Please enter room number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please select a reservation first.");
                return;
            }

            try
            {
                db.Open();

                string query = @"
        UPDATE reservationstbl 
        SET room_number = @room_number
        WHERE reservation_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@room_number", txtRoomNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@id", txtSearch.Text.Trim());

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Room number updated successfully!");
                    LoadReservations();
                }
                else
                {
                    MessageBox.Show("Update failed. No record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private bool IsRoomNumberAvailable(string roomNumber, string reservationId)
        {
            bool available = true;

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
        SELECT COUNT(*) 
        FROM reservationstbl
        WHERE room_number = @room_number
        AND reservation_id <> @reservation_id
        AND status <> 'CHECKED-OUT'
        AND status <> 'CANCELLED'";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@room_number", roomNumber);
                cmd.Parameters.AddWithValue("@reservation_id", reservationId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    available = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

            return available;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRoomStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
