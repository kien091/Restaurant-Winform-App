using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Home : Form
    {
        public string Email { get; set; }
        public string Password { get; set; }

        static Home _obj;

        public static Home Instance
        {
            get
            {
                if (_obj is null)
                {
                    _obj = new Home();
                }
                return _obj;
            }
        }
        public Panel pnlBooking
        {
            get { return panelBooking; }
            set { panelBooking = value; }
        }
        public Home()
        {
            InitializeComponent();
        }
        public Home(string email, string password)
        {
            Email = email;
            Password = password;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            _obj = this;

            panelNavBooking.Visible = false;
            btnMenu.Location = new Point(0, 234);

            Main main = new Main();
            main.Dock = DockStyle.Fill;
            panelBooking.Controls.Add(main);

        }

        int flag = 0;
        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                flag = 1;
                panelNavBooking.Visible = true;
                btnMenu.Location = new Point(0, 366);
            }
            else
            {
                flag = 0;
                panelNavBooking.Visible = false;
                btnMenu.Location = new Point(0, 234);
            }
        }

        private void btnQuickBook_Click(object sender, EventArgs e)
        {

            foreach (Control control in panelBooking.Controls)
            {
                panelBooking.Controls.Remove(control);
                control.Dispose();
            }
            quickBooking quick = new quickBooking(this);
            quick.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(quick);
            Home.Instance.pnlBooking.Controls["quickBooking"]?.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelBooking.Controls)
            {
                panelBooking.Controls.Remove(control);
                control.Dispose();
            }
            UserBookingInfo info = new UserBookingInfo(this);
            info.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(info);
            Home.Instance.pnlBooking.Controls["quickBooking"]?.BringToFront();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!panelBooking.Controls.ContainsKey("Main"))
            {
                foreach (Control control in panelBooking.Controls)
                {
                    panelBooking.Controls.Remove(control);
                    control.Dispose();
                }
                Main main = new Main();
                main.Dock = DockStyle.Fill;
                panelBooking.Controls.Add(main);
                Home.Instance.pnlBooking.Controls["Main"]?.BringToFront();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile profile = new profile(this.Email, this.Password);
            profile.Closed += (s, args) => this.Close();
            profile.Show();
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/k4_kien/");
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/kienk4.me/");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/nguyntrungkin");
        }
    }
}
