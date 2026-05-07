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
            UserDashboard userDashboardForm = new UserDashboard();
            userDashboardForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            logInForm.Show();
            this.Hide();
        }
    }
}
