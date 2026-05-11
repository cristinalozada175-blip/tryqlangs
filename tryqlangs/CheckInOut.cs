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
    public partial class CheckInOut : Form
    {
        bool isLoading = false;
        
        public CheckInOut()
        {
            InitializeComponent();
            LoadReservations();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadReservations()
        {
            DBConnect db = new DBConnect();

            try
            {
                isLoading = true;

                db.Open();

                string query = @"
SELECT 
    r.reservation_id,
    u.username,
    u.email,
    u.mobile,
    r.room_number,
    r.room_id,
    rm.room_type,
    r.check_in,
    r.check_out,
    r.night,
    r.status,
    r.total_amount,
    COALESCE(p.payment_status, 'No Payment') AS payment_status

FROM reservationstbl r

INNER JOIN userstbl u
    ON r.user_id = u.user_id

LEFT JOIN roomstbl rm
    ON r.room_id = rm.room_id

LEFT JOIN paymentstbl p
    ON r.reservation_id = p.reservation_id

GROUP BY r.reservation_id

ORDER BY r.reservation_id DESC";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, db.Connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSummary.DataSource = dt;

                dgvSummary.Columns["reservation_id"].HeaderText = "Reservation ID";
                dgvSummary.Columns["username"].HeaderText = "Guest Name";
                dgvSummary.Columns["email"].HeaderText = "Email";
                dgvSummary.Columns["mobile"].HeaderText = "Contact Number";
                dgvSummary.Columns["room_number"].HeaderText = "Room Number";
                dgvSummary.Columns["room_type"].HeaderText = "Room Type";
                dgvSummary.Columns["check_in"].HeaderText = "Check In";
                dgvSummary.Columns["check_out"].HeaderText = "Check Out";
                dgvSummary.Columns["night"].HeaderText = "Nights";
                dgvSummary.Columns["status"].HeaderText = "Status";
                dgvSummary.Columns["total_amount"].HeaderText = "Total Amount";
                dgvSummary.Columns["payment_status"].HeaderText = "Payment Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                isLoading = false;
                db.Close();
            }
        }



        private void CheckInOut_Load(object sender, EventArgs e)
        {
            // STATUS COMBOBOX
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("PENDING");
            cmbStatus.Items.Add("CHECKED-IN");
            cmbStatus.Items.Add("CHECKED-OUT");
            cmbStatus.Items.Add("CANCELLED");

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // PAYMENT STATUS COMBOBOX
            cmbPaymentStatus.Items.Clear();

            cmbPaymentStatus.Items.Add("No Payment");
            cmbPaymentStatus.Items.Add("PENDING");
            cmbPaymentStatus.Items.Add("PAID");
            cmbPaymentStatus.Items.Add("FAILED");

            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadReservations();
        }

        private void dgvSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            isLoading = true;

            DataGridViewRow row = dgvSummary.Rows[e.RowIndex];

            txtReservationId.Text =
                row.Cells["reservation_id"].Value?.ToString();

            txtGuestName.Text =
                row.Cells["username"].Value?.ToString();

            txtEmail.Text =
                row.Cells["email"].Value?.ToString();

            txtContactNumber.Text =
                row.Cells["mobile"].Value?.ToString();

            txtRoomNumber.Text =
                row.Cells["room_number"].Value?.ToString();

            txtRoomType.Text =
                row.Cells["room_type"].Value?.ToString();

            txtNight.Text =
                row.Cells["night"].Value?.ToString();

            cmbPaymentStatus.Text =
             row.Cells["payment_status"].Value?.ToString() ?? "No Payment";

           dtpCheckIn.Value =
                Convert.ToDateTime(row.Cells["check_in"].Value);

            dtpCheckOut.Value =
                Convert.ToDateTime(row.Cells["check_out"].Value);

            isLoading = false;
        }



        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReservationId.Text))
            {
                MessageBox.Show("Please select reservation first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to CHECK-IN this guest?",
                "Check-In Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UpdateStatus("CHECKED-IN");

                MessageBox.Show(
                    "Guest successfully checked-in!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            if (cmbStatus.Text != "CHECKED-IN")
            {
                MessageBox.Show(
                    "Guest must be CHECKED-IN first before CHECK-OUT.",
                    "Invalid Action",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtReservationId.Text))
            {
                MessageBox.Show("Please select reservation first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to CHECK-OUT this guest?",
                "Check-Out Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UpdateStatus("CHECKED-OUT");

                MessageBox.Show(
                    "Guest successfully checked-out!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void UpdateStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(txtReservationId.Text))
            {
                MessageBox.Show("Please select reservation first.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                int reservationId = Convert.ToInt32(txtReservationId.Text);

                int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
                if (nights < 1) nights = 1;
                string query = @"
        UPDATE reservationstbl
        SET status = @status,
            night = @night
        WHERE reservation_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@night", nights);
                cmd.Parameters.AddWithValue("@id", reservationId);

                cmd.ExecuteNonQuery();
                LoadReservations();
           
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

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (txtReservationId.Text == "") return;

            UpdateStatus(cmbStatus.Text);
        }



        private void btnVewDetails_Click(object sender, EventArgs e)
        {
            if (txtReservationId.Text == "")
            {
                MessageBox.Show("Please select reservation first.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                SELECT 
                    r.reservation_id,
                    u.username,
                    u.email,
                    u.mobile,
                    r.room_number,
                    rm.room_type,
                    r.check_in,
                    r.check_out,
                    r.night,
                    r.status,
                    r.total_amount,
                    p.payment_status

                FROM reservationstbl r

                INNER JOIN userstbl u
                    ON r.user_id = u.user_id

                LEFT JOIN roomstbl rm
                    ON r.room_id = rm.room_id

                LEFT JOIN paymentstbl p
                    ON r.reservation_id = p.reservation_id

                WHERE r.reservation_id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue(
                    "@id",
                    Convert.ToInt32(txtReservationId.Text)
                );

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtGuestName.Text =
                        reader["username"].ToString();

                    txtContactNumber.Text =
                        reader["mobile"].ToString();

                    txtEmail.Text =
                        reader["email"].ToString();

                    txtRoomNumber.Text =
                        reader["room_number"].ToString();

                    txtRoomType.Text =
                        reader["room_type"].ToString();

                    txtNight.Text =
                        reader["night"].ToString();

                    isLoading = true;

                    cmbStatus.Text =
                        reader["status"].ToString();

                    cmbPaymentStatus.Text =
                        reader["payment_status"] == DBNull.Value
                        ? "No Payment"
                        : reader["payment_status"].ToString();

                    isLoading = false;

                    dtpCheckIn.Value =
                        Convert.ToDateTime(reader["check_in"]);

                    dtpCheckOut.Value =
                        Convert.ToDateTime(reader["check_out"]);
                }
                else
                {
                    MessageBox.Show("Reservation not found.");
                }

                reader.Close();
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



        private void btnRoomStatus_Click(object sender, EventArgs e)
        {
            RoomStatus roomStatusForm = new RoomStatus();
            roomStatusForm.ShowDialog();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            StaffDashboards staffDashboardForm = new StaffDashboards();
            staffDashboardForm.ShowDialog();
            this.Hide();
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            CheckInOut checkInOutForm = new CheckInOut();
            checkInOutForm.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void UpdatePaymentStatus()
        {
            if (string.IsNullOrWhiteSpace(txtReservationId.Text))
                return;

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                int reservationId = Convert.ToInt32(txtReservationId.Text);

                // CHECK IF PAYMENT EXISTS
                string checkQuery = @"
        SELECT COUNT(*) 
        FROM paymentstbl 
        WHERE reservation_id = @id";

                MySqlCommand checkCmd =
                    new MySqlCommand(checkQuery, db.Connection);

                checkCmd.Parameters.AddWithValue("@id", reservationId);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                string query;

                if (count > 0)
                {
                    query = @"
            UPDATE paymentstbl
            SET payment_status = @status
            WHERE reservation_id = @id";
                }
                else
                {
                    query = @"
            INSERT INTO paymentstbl
            (reservation_id, payment_status)
            VALUES
            (@id, @status)";
                }

                MySqlCommand cmd =
                    new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@id", reservationId);
                cmd.Parameters.AddWithValue("@status", cmbPaymentStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment status updated!");

                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void cmbPaymentStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (string.IsNullOrWhiteSpace(txtReservationId.Text))
                return;

            UpdatePaymentStatus();
        }

       
    }
}
