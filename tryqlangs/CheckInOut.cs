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
                db.Open();

                string query = @"
        SELECT 
            r.reservation_id,
            u.username,
            u.email,
            u.mobile,
            rm.room_number,
            rm.room_type,
            r.check_in,
            r.check_out,
            r.night,
            r.status,
            r.total_amount,
            COALESCE(p.payment_status, 'No Payment') AS payment_status
        FROM reservationstbl r
        INNER JOIN userstbl u ON r.user_id = u.user_id
        LEFT JOIN roomstbl rm ON r.room_id = rm.room_id
        LEFT JOIN paymentstbl p ON r.reservation_id = p.reservation_id
        ORDER BY r.reservation_id DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, db.Connection);
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
                db.Close();
            }
        }



        private void CheckInOut_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void dgvSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgvSummary.Rows[e.RowIndex];

                txtReservationId.Text = row.Cells["reservation_id"].Value?.ToString();
                txtGuestName.Text = row.Cells["username"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtContactNumber.Text = row.Cells["mobile"].Value?.ToString();
                txtRoomNumber.Text = row.Cells["room_number"].Value?.ToString();
                txtRoomType.Text = row.Cells["room_type"].Value?.ToString();
                txtStatus.Text = row.Cells["status"].Value?.ToString();
                txtNight.Text = row.Cells["night"].Value?.ToString();

                isLoading = true;

                cmbPaymentStatus.Text =
                    row.Cells["payment_status"].Value?.ToString() ?? "No Payment";

                isLoading = false;

                dtpCheckIn.Value = Convert.ToDateTime(row.Cells["check_in"].Value);
                dtpCheckOut.Value = Convert.ToDateTime(row.Cells["check_out"].Value);
            }
        }

        

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            UpdateStatus("Checked-In");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            UpdateStatus("Checked-Out");
        }

        private void UpdateStatus(string status)
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

                int reservationId = Convert.ToInt32(txtReservationId.Text);

                int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
                if (nights < 1) nights = 1;

                string query;

                if (status == "Checked-Out")
                {
                    query = @"
            UPDATE reservationstbl
            SET status=@status,
                night=@night
            WHERE reservation_id=@id";
                }
                else
                {
                    query = @"
            UPDATE reservationstbl
            SET status=@status
            WHERE reservation_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", reservationId);
                cmd.Parameters.AddWithValue("@night", nights);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Success: " + status);

                    txtStatus.Text = status;

                    LoadReservations();
                    dgvSummary.Refresh();// 🔥 IMPORTANT FIX (refresh grid)
                }
                else
                {
                    MessageBox.Show("Reservation not found.");
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
        }


        private void btnVewDetails_Click(object sender, EventArgs e)
        {
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

            rm.room_number,
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

        WHERE r.reservation_id = @id
        ";

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

                    // ROOM NUMBER
                    txtRoomNumber.Text =
                        reader["room_number"].ToString();

                    // ROOM TYPE
                    txtRoomType.Text =
                        reader["room_type"].ToString();

                    txtStatus.Text =
                        reader["status"].ToString();

                    // NIGHTS (INT FIX)
                    txtNight.Text =
                        reader["night"].ToString();

                    // PAYMENT STATUS (NEW)
                    cmbPaymentStatus.Text =
                    reader["payment_status"] == DBNull.Value
                    ? "No Payment"
                    : reader["payment_status"].ToString();


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

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (txtReservationId.Text == "") return;

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
        UPDATE paymentstbl
        SET payment_status = @status
        WHERE reservation_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@status", cmbPaymentStatus.Text);
                cmd.Parameters.AddWithValue("@id", txtReservationId.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                {
                    // optional: insert if wala pa record
                    string insert = @"
            INSERT INTO paymentstbl (reservation_id, payment_status)
            VALUES (@id, @status)";

                    MySqlCommand cmd2 = new MySqlCommand(insert, db.Connection);
                    cmd2.Parameters.AddWithValue("@id", txtReservationId.Text);
                    cmd2.Parameters.AddWithValue("@status", cmbPaymentStatus.Text);
                    cmd2.ExecuteNonQuery();
                }

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
    }
}
