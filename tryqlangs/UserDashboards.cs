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
    public partial class UserDashboards : Form
    {
        public UserDashboards()
        {
            InitializeComponent();
        }

        // ================= LOAD USER RESERVATIONS =================
        private void LoadMyReservations()
        {
            int userId = LogIn.UserSession.userstblID;

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                SELECT 
                    r.reservation_id,
                    rm.room_type,
                    r.check_in,
                    r.check_out,
                    r.status

                FROM reservationstbl r

                INNER JOIN roomstbl rm
                    ON r.room_id = rm.room_id

                WHERE r.user_id = @userid

                ORDER BY r.reservation_id DESC
                ";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@userid", userId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvReservations.DataSource = table;

                // ===== HEADERS =====
                dgvReservations.Columns["reservation_id"].HeaderText = "Reservation ID";
                dgvReservations.Columns["room_type"].HeaderText = "Room Type";
                dgvReservations.Columns["check_in"].HeaderText = "Check-In";
                dgvReservations.Columns["check_out"].HeaderText = "Check-Out";
                dgvReservations.Columns["status"].HeaderText = "Status";
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

        // ================= FORM LOAD =================
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadMyReservations();
        }



        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboards userDashboardsForm = new UserDashboards();
            userDashboardsForm.Show();
            this.Hide();
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReservations.Rows[e.RowIndex];

                MessageBox.Show(
                    "Reservation ID: " + row.Cells["reservation_id"].Value.ToString() +
                    "\nRoom Type: " + row.Cells["room_type"].Value.ToString() +
                    "\nCheck-In: " + row.Cells["check_in"].Value.ToString() +
                    "\nCheck-Out: " + row.Cells["check_out"].Value.ToString() +
                    "\nStatus: " + row.Cells["status"].Value.ToString()
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyReservations();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Show();
            this.Hide();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookARoom bookARoomForm = new BookARoom();
            bookARoomForm.Show();
            this.Hide();
        }
    }
}
