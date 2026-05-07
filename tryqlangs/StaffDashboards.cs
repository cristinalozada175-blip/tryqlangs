using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryqlangs
{
    public partial class StaffDashboards : Form
    {
        public StaffDashboards()
        {
            InitializeComponent();
        }

        private void StaffDashboards_Load(object sender, EventArgs e)
        {
            DbConnect db = new DbConnect();

            try
            {
                db.Open();
                db.Connection();
                db.Close();
            }
        }
    }
}
