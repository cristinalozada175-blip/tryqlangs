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
    public partial class StaffDashboards : Form
    {
        public StaffDashboards()
        {
            InitializeComponent();
            LoadStaffReservations();
        }

        private void StaffDashboards_Load(object sender, EventArgs e)
        {

        }

        private void LoadStaffReservations()
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
    r.room_number,
    rm.price,
    r.check_in,
    r.check_out,
    r.night,
    r.total_amount,
    COALESCE(r.status, 'PENDING') AS reservation_status,
    COALESCE(MAX(p.payment_status), 'No Payment') AS payment_status

FROM reservationstbl r

JOIN roomstbl rm
    ON r.room_id = rm.room_id

JOIN userstbl u
    ON r.user_id = u.user_id

LEFT JOIN paymentstbl p
    ON r.reservation_id = p.reservation_id

GROUP BY r.reservation_id

ORDER BY r.reservation_id DESC";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                    new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentReservation.DataSource = table;

                dgvRecentReservation.Columns["username"].HeaderText = "Guest Name";
                dgvRecentReservation.Columns["email"].HeaderText = "Email";
                dgvRecentReservation.Columns["room_number"].HeaderText = "Room";
                dgvRecentReservation.Columns["price"].HeaderText = "Room Price";
                dgvRecentReservation.Columns["check_in"].HeaderText = "Check-in";
                dgvRecentReservation.Columns["check_out"].HeaderText = "Check-out";
                dgvRecentReservation.Columns["night"].HeaderText = "Nights";
                dgvRecentReservation.Columns["total_amount"].HeaderText = "Total Amount";
                dgvRecentReservation.Columns["reservation_status"].HeaderText = "Status";
                dgvRecentReservation.Columns["payment_status"].HeaderText = "Payment";

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

        private void btnViewQrCode_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStaffReservations();
        }

        private void btnRoomStatus_Click(object sender, EventArgs e)
        {
            RoomStatus roomStatusForm = new RoomStatus();
            roomStatusForm.ShowDialog();
            this.Hide();

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            LoadStaffReservations();
        }

        private void btnCheckInCheckOut_Click(object sender, EventArgs e)
        {
            CheckInOut checkInOutForm = new CheckInOut();
            checkInOutForm.ShowDialog();
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

        private void dgvRecentReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
