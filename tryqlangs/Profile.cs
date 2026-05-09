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
            LogIn logInForm = new LogIn();
            logInForm.Show();
            this.Hide();
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


    }
}