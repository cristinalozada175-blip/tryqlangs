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

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {

                txtEnterPassword.PasswordChar = '\0';
                txtEnterPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtEnterPassword.PasswordChar = '*';
                txtEnterPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnUpgradeProfile_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string phonenumber = txtPhoneNumber.Text.Trim();


            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phonenumber))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {

                db.Open();
                string query = "UPDATE userstbl SET fullname = @fullname, email = @email, phonenumber = @phonenumber, password = @password WHERE id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully.");

                    txtFullName.Clear();
                    txtEmailAddress.Clear();
                    txtPhoneNumber.Clear();
                }
                else
                {
                    MessageBox.Show("No changes were made to the profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        


    }
}
