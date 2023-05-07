using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class quickBooking : UserControl
    {
        public int numAdult { get; set; }
        public int numChildren { get; set; }
        public string Time { get; set; }

        public Home Home { get; set; }

        public quickBooking()
        {
            InitializeComponent();
        }
        public quickBooking(Home home)
        {
            InitializeComponent();
            Home = home;
        }

        private Button[] btnDown = new Button[2];
        private TextBox[] txtPerson = new TextBox[2];
        private Panel[] panel = new Panel[2];
        private Button[] btnAdd = new Button[2];
        private TextBox[] txtNum = new TextBox[2];
        private Button[] btnMinus = new Button[2];
        private void quickBooking_Load(object sender, EventArgs e)
        {
            // set button to list and set format of time
            btnDown[0] = btnDown1;
            btnDown[1] = btnDown2;
            txtPerson[0] = txtAdults;
            txtPerson[1] = txtChildren;
            panel[0] = panelAdults;
            panel[1] = panelChildren;
            btnAdd[0] = btnAdd1;
            btnAdd[1] = btnAdd2;
            txtNum[0] = txtNum1;
            txtNum[1] = txtNum2;
            btnMinus[0] = btnMinus1;
            btnMinus[1] = btnMinus2;

            dtpDate.CustomFormat = "MMM dd,yyyy";
            dtpHour.CustomFormat = "hh:mm tt";

            btnContinue.Enabled = false;
        }


        private void btnDown_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = Array.IndexOf(btnDown, btn);
            if (!panel[index].Visible)
            {
                panel[index].Visible = true;
                int num = int.Parse(txtPerson[index].Text.Split(' ')[0]);
                txtNum[index].Text = num.ToString();
            }
            else
            {
                panel[index].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = Array.IndexOf(btnAdd, btn);
            int count = int.Parse(txtNum[index].Text);
            count++;
            txtNum[index].Text = count.ToString();
            txtPerson[index].Text = count.ToString() + " person";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = Array.IndexOf(btnMinus, btn);
            int count = int.Parse(txtNum[index].Text);
            if (count <= 0)
            {
                count = 0;
            }
            else
            {
                count--;
            }
            if (index == 0 && count == 0)
            {
                count = 1;
            }
            txtNum[index].Text = count.ToString();
            txtPerson[index].Text = count.ToString() + " person";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            numAdult = int.Parse(txtAdults.Text.Split(' ')[0]);
            numChildren = int.Parse(txtChildren.Text.Split(' ')[0]);
            Time = dtpDate.Text + ' ' + dtpHour.Text;

            panelAdults.Visible = false;
            panelChildren.Visible = false;

            // create a new 'Booking' and open it
            if (Home.Instance.pnlBooking.Controls.ContainsKey("Booking"))
            {
                Home.Instance.pnlBooking.Controls.Remove(Home.Instance.pnlBooking.Controls["Booking"]);
            }
            Booking book = new Booking(this);
            book.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(book);
            Home.Instance.pnlBooking.Controls["Booking"].BringToFront();
        }

        private void dtpHour_ValueChanged(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
            DateTime Day = dtpDate.Value;
            DateTime Hour = new DateTime(Day.Year, Day.Month, Day.Day, dtpDate.Value.Hour, dtpDate.Value.Minute, 0);
            if (Hour.AddMinutes(-29) <= DateTime.Now)
            {
                btnContinue.Enabled = false;
                lbDanger.Text = "Please chose another times";
                lbDanger.ForeColor = Color.Red;
                dtpHour.CustomFormat = "hh:mm tt";
            }
            else
            {
                TimeSpan openTime = new TimeSpan(7, 0, 0);
                TimeSpan closeTime = new TimeSpan(21, 0, 0);
                if (Hour.TimeOfDay < openTime)
                {
                    lbDanger.Text = "Your are booking too early. \nPlease choose another time to booking";
                    lbDanger.ForeColor = Color.Red;
                    btnContinue.Enabled = false;
                }
                else if (Hour.TimeOfDay > closeTime)
                {
                    lbDanger.Text = "Your are booking too late. \nPlease choose another time to booking";
                    lbDanger.ForeColor = Color.Red;
                    btnContinue.Enabled = false;
                }
                else
                {
                    lbDanger.Text = "";
                    btnContinue.Enabled = true;
                }
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            txtAdults.Text = txtNum1.Text + " person";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            txtChildren.Text = txtNum2.Text + " person";
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Value.Day < DateTime.Now.Day)
            {
                lbDanger.Text = "Please chose another day";
                lbDanger.ForeColor = Color.Red;
                btnContinue.Enabled = false;
            }
            else
            {
                btnContinue.Enabled = true;
                lbDanger.Text = "";
            }
        }
    }
}
