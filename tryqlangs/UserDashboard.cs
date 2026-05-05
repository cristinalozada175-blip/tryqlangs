using Org.BouncyCastle.Pqc.Crypto.Lms;
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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                SELECT r.reservation_id,
       rm.room_number,
       r.check_in,
       r.check_out,
       r.status
FROM reservationstbl r
JOIN roomstbl rm ON r.room_id = rm.room_id";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                    new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentReservation.DataSource = table;

                // COLUMN HEADER
                dgvRecentReservation.Columns["reservation_id"].HeaderText = "Reservation ID";
                dgvRecentReservation.Columns["room_number"].HeaderText = "Room";
                dgvRecentReservation.Columns["check_in"].HeaderText = "Check-in";
                dgvRecentReservation.Columns["check_out"].HeaderText = "Check-out";
                dgvRecentReservation.Columns["status"].HeaderText = "Status";




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


        private void btnMyQrCode_Click(object sender, EventArgs e)
        {
            MyQrCode myQrCodeForm = new MyQrCode();
            myQrCodeForm.Show();
            this.Hide();
        }

        private void btnViewQrCode_Click(object sender, EventArgs e)
        {
            MyQrCode myQrCodeForm = new MyQrCode();
            myQrCodeForm.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile myProfileForm = new Profile();
            myProfileForm.Show();
            this.Hide();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookARoom bookARoomForm = new BookARoom();
            bookARoomForm.Show();
            this.Hide();
        }

        private void btnMyReservation_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboardForm = new UserDashboard();
            userDashboardForm.Show();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
             LoadReservations();
        }
    }
}
