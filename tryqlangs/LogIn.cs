using System.Text.RegularExpressions;
using static tryqlangs.DbConnect;

namespace tryqlangs
{
    public partial class LogIn : Form
    {
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

            // Validate email and password fields//
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

            // Validate email format using regular expression//
            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid email format.");
            }

            // Check if email and password are empty//
            if (email == "" | password == "")
            {

                MessageBox.Show("Please enter email or pasword");
                return;
            }

            // In your Login button click event

            DBConnect dB = new DBConnect();
            try
            {
                dB.Open();
                string query = "SELECT role FROM userstbl WHERE email = @email AND password = @password";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dB.Connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    string role = cmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(role))
                    {
                        // Redirect based on role
                        switch (role)
                        {
                            case "admin":
                                AdminDashboards adminDash = new AdminDashboards();
                                adminDash.Show();
                                this.Hide();
                                break;
                            case "staff":
                                StaffDashboards staffDash = new StaffDashboards();
                                staffDash.Show();
                                this.Hide();
                                break;
                            case "customer":
                                UserDashboard userDash = new UserDashboard();
                                userDash.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


