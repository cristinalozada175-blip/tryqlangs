using MySqlX.XDevAPI.Common;
using System.Text.RegularExpressions;
using static tryqlangs.DbConnect;

namespace tryqlangs
{
    public partial class LogIn : Form
    {
        public static class Session
        {
            public static int userstblID { get; set; }
        }
        public static class UserSession
        {
            public static int userstblID { get; set; }

        }

        public LogIn()
        {
            InitializeComponent();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter email");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password");
                return;
            }

            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            DBConnect dB = new DBConnect();

            try
            {
                dB.Open();

                // Select BOTH ID and role
                string query = "SELECT user_id, role FROM userstbl WHERE email = @email AND password = @password";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dB.Connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Save user ID into session
                            UserSession.userstblID = Convert.ToInt32(reader["user_id"]);

                            // Get role
                            string role = reader["role"].ToString();

                            // Redirect based on role
                            switch (role)
                            {
                                case "staff":
                                    StaffDashboards staffDash = new StaffDashboards();
                                    staffDash.Show();
                                    this.Hide();
                                    break;

                                case "customer":
                                    UserDashboards userDashboardsForm = new UserDashboards();
                                    userDashboardsForm.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid email or password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
            finally
            {
                dB.Close();
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {

                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
