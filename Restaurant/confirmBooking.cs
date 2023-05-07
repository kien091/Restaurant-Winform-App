using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Restaurant
{
    public partial class confirmBooking : UserControl
    {
        private Booking Book { get; set; }
        public confirmBooking()
        {
            InitializeComponent();
        }
        public confirmBooking(Booking book)
        {
            InitializeComponent();
            Book = book;
        }

        private void confirmBooking_Load(object sender, EventArgs e)
        {
            lbAdults.Text = Book.Quick.numAdult.ToString() + " person";
            lbChildren.Text = Book.Quick.numChildren.ToString() + " person";
            lbTime.Text = Book.Quick.Time;
            lbTable.Text = Book.tableName;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (Home.Instance.pnlBooking.Controls.ContainsKey("quickBooking"))
            {
                Home.Instance.pnlBooking.Controls.Remove(Home.Instance.pnlBooking.Controls["quickBooking"]);
            }
            quickBooking quick = new quickBooking(Book.Quick.Home);
            quick.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(quick);
            Home.Instance.pnlBooking.Controls["quickBooking"].BringToFront();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int numPerson = int.Parse(lbAdults.Text.Split(' ')[0]) + int.Parse(lbChildren.Text.Split(' ')[0]);
            SqlConnection connection = ConnectionSingleton.GetConnection();
            UserModel user = new UserModel(Book.Quick.Home.Email);
            string id_Account = user.getIdFromDB(connection);


            string[] table = lbTable.Text.Split(' ');
            int numSeat;
            for (int i = 1; i < table.Length; i++)
            {
                if (table[i].StartsWith("A")) numSeat = 6;
                else numSeat = 4;

                BookingModel booking = new BookingModel(table[i], numSeat, lbTime.Text, lbTable.Text, id_Account);
                booking.InsertBooking(connection);
            }
            MessageBox.Show("Successful Booking!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Home.Instance.pnlBooking.Controls.ContainsKey("quickBooking"))
            {
                Home.Instance.pnlBooking.Controls.Remove(Home.Instance.pnlBooking.Controls["quickBooking"]);
            }
            quickBooking quick = new quickBooking(Book.Quick.Home);
            quick.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(quick);
            Home.Instance.pnlBooking.Controls["quickBooking"].BringToFront();
        }
    }
}
