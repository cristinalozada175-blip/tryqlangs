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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmailID.Text.Trim();
            string password = txtPassword.Text.Trim();
            string mobile = txtMobileNumber.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";

            DBConnect dB = new DBConnect();
            try
            {
                // Validate inputs
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please fill all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                dB.Open();

                // Check if user already exists
                string checkQuery = "SELECT COUNT(*) FROM userstbl WHERE email = @email OR username = @username";
                using (var checkCmd = new MySql.Data.MySqlClient.MySqlCommand(checkQuery, dB.Connection))
                {
                    checkCmd.Parameters.AddWithValue("@email", email);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("User already exists with this email or username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (role == "admin" || role == "staff" || role == "customer")
                {
                    // Insert into main users table first
                    string userQuery = "INSERT INTO userstbl (username, password, email, mobile, role) VALUES (@username, @password, @email, @mobile, @role)";
                    using (var userCmd = new MySql.Data.MySqlClient.MySqlCommand(userQuery, dB.Connection))
                    {
                        userCmd.Parameters.AddWithValue("@username", username);
                        userCmd.Parameters.AddWithValue("@password", password); // Consider hashing password in production
                        userCmd.Parameters.AddWithValue("@email", email);
                        userCmd.Parameters.AddWithValue("@mobile", mobile);
                        userCmd.Parameters.AddWithValue("@role", role);
                        userCmd.ExecuteNonQuery();

                        MessageBox.Show("Customer registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogIn userDash = new LogIn();
                        userDash.Show();

                        this.Hide(); // Hide registration form
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid role (Admin, Staff, or Customer)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dB.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }
    }
}
