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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
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


        private void btnMyReservation_Click(object sender, EventArgs e)
        {

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

        private void Profile_Load_1(object sender, EventArgs e)
        {
            takbo();
        }

        private void takbo()
        {
            //DITTOOOO SAAAA TAAASS NGGG DBCOONEECTT
            int currentId = tryqlangs.LogIn.UserSession.userstblID;
            int currentId1 = tryqlangs.Register.UserSession.userstblID;
            DBConnect db = new DBConnect();

            try
            {

                db.Open();

                string query = "SELECT username FROM userstbl WHERE user_id = @user_id";
                string query1 = "SELECT email FROM userstbl WHERE user_id = @user_id";
                string query2 = "SELECT mobile FROM userstbl WHERE user_id = @user_id";
                string query3 = "SELECT password FROM userstbl WHERE user_id = @user_id";





                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlCommand cmd1 = new MySqlCommand(query1, db.Connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, db.Connection);
                MySqlCommand cmd3 = new MySqlCommand(query3, db.Connection);








                cmd.Parameters.AddWithValue("@user_id", currentId);
                cmd1.Parameters.AddWithValue("@user_id", currentId);
                cmd2.Parameters.AddWithValue("@user_id", currentId);
                cmd3.Parameters.AddWithValue("@user_id", currentId);





                object result = cmd.ExecuteScalar();
                object result1 = cmd1.ExecuteScalar();
                object result2 = cmd2.ExecuteScalar();
                object result3 = cmd3.ExecuteScalar();




                if (result != null && result != DBNull.Value && result1 != null && result1 != DBNull.Value && result2 != null && result2 != DBNull.Value && result3 != null && result3 != DBNull.Value)
                {
                    textBox1.Text = result.ToString();
                    textBox2.Text = result1.ToString();
                    textBox4.Text = result2.ToString();
                    textBox3.Text = result3.ToString();




                }
                else
                {
                    MessageBox.Show("No data found for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching address: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            int currentId = LogIn.UserSession.userstblID;

            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (!textBox2.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
        UPDATE userstbl
        SET 
            username = @username,
            email = @email,
            mobile = @mobile,
            password = @password
        WHERE user_id = @user_id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@email", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@user_id", currentId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Profile updated successfully!");

                    // reload data
                    takbo();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnMyReservation_Click_1(object sender, EventArgs e)
        {
            UserDashboards userDashboardsForm = new UserDashboards();   
            userDashboardsForm.Show();
            this.Hide();
        }
    }
}