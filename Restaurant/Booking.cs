using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Restaurant
{
    public partial class Booking : UserControl
    {
        public quickBooking Quick { get; set; }
        public string tableName { get; set; }
        public Booking()
        {
            InitializeComponent();
        }

        public Booking(quickBooking quick)
        {
            InitializeComponent();
            Quick = quick;
        }

        Color[] containColor;
        int Flag = 0;
        int Person;

        private void storeStatusColor(Button button, int buttonCount, IOrderedEnumerable<Button> sortedButtons)
        {
            for (int i = 0; i < buttonCount; i++)
            {
                button = sortedButtons.ElementAt(i);
                containColor[i] = button.BackColor;
            }
        }

        private bool existGrayColor(Button button, int buttonCount, IOrderedEnumerable<Button> sortedButtons)
        {
            for (int i = 0; i < buttonCount; i++)
            {
                button = sortedButtons.ElementAt(i);
                if (button.BackColor == Color.DarkGray)
                    return true;
            }
            return false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // find button click and check number seat of it
            Button btn = (Button)sender;
            int nSeat;
            if (btn.Text.StartsWith("A"))
                nSeat = 6;
            else
                nSeat = 4;

            // store Color to containColor
            int buttonCount = panelBooking.Controls.OfType<Button>().Count();
            var sortedButtons = panelBooking.Controls.OfType<Button>().OrderBy(p => p.TabIndex);
            Button button = new Button();

            // template contain backColor of button
            if (Flag == 0)
            {
                Flag = 1;
                containColor = new Color[buttonCount];
            }

            // convert color and modify person when click
            if (btn.BackColor == Color.ForestGreen)
            {
                btn.BackColor = Color.DodgerBlue;
                Person -= nSeat;
                tableName = tableName + " " + btn.Text;
                storeStatusColor(button, buttonCount, sortedButtons);
            }
            else
            {
                Person += nSeat;

                if (Person > 0)
                {
                    changeColorWithPeson(Person);
                }
                btn.BackColor = Color.ForestGreen;

                if (!existGrayColor(button, buttonCount, sortedButtons))
                    storeStatusColor(button, buttonCount, sortedButtons);

                string[] table = tableName.Split(' ');
                string str = "";
                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i] == btn.Text)
                        continue;
                    str += " " + table[i];
                }
                tableName = str;
            }

            if (Person <= 0)
            {
                changeColorWithPeson(Person);
            }
            lbSelect.Text = tableName;
            if (Person < 0)
                btnContinue.Enabled = true;
            else
                btnContinue.Enabled = false;
        }

        // if Person > 0 changeColor else change color to status before
        private void changeColorWithPeson(int Person)
        {
            int buttonCount = panelBooking.Controls.OfType<Button>().Count();
            var sortedButtons = panelBooking.Controls.OfType<Button>().OrderBy(p => p.TabIndex);
            Button button;

            // convert backColor to gray when numSeat > numPerson
            if (Person <= 0)
            {
                for (int i = 0; i < buttonCount; i++)
                {
                    button = sortedButtons.ElementAt(i);
                    //containColor[i] = button.BackColor;
                    if (button.BackColor != Color.DodgerBlue)
                    {
                        button.BackColor = Color.DarkGray;
                        button.Enabled = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < buttonCount; i++)
                {
                    button = sortedButtons.ElementAt(i);
                    Color colorFirst = button.BackColor;
                    button.BackColor = containColor[i];
                    Color colorBehind = button.BackColor;
                    if (button.BackColor != Color.Red)
                        button.Enabled = true;
                    if (colorFirst == Color.DarkGray && colorBehind == Color.DodgerBlue)
                        button.BackColor = Color.ForestGreen;

                }
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            Person = Quick.numAdult + Quick.numChildren;

            // Load all table was booking follow to time 
            List<string> list = new List<string>();
            BookingModel check = new BookingModel("", 0, Quick.Time, "", Quick.Home.Email);
            SqlConnection connection = ConnectionSingleton.GetConnection();

            int buttonCount = panelBooking.Controls.OfType<Button>().Count();
            var sortedButtons = panelBooking.Controls.OfType<Button>().OrderBy(p => p.TabIndex);
            Button button = new Button();

            // find and convert color which was booking
            list = check.getTableBookingWithTime(connection);
            if (list.Count() > 0)
            {
                for (int i = 0; i < buttonCount; i++)
                {
                    button = sortedButtons.ElementAt(i);
                    for (int j = 0; j < list.Count(); j++)
                    {
                        if (button.Text == list.ElementAt(j).ToString())
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                    }
                }
            }

            btnContinue.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // create new panel "confirmBooking" and open it
            if (Home.Instance.pnlBooking.Controls.ContainsKey("confirmBooking"))
            {
                Home.Instance.pnlBooking.Controls.Remove(Home.Instance.pnlBooking.Controls["confirmBooking"]);
            }
            confirmBooking confirm = new confirmBooking(this);
            confirm.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(confirm);
            Home.Instance.pnlBooking.Controls["confirmBooking"].BringToFront();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // create new panel "InformationBooking" and open it
            if (Home.Instance.pnlBooking.Controls.ContainsKey("quickBooking"))
            {
                Home.Instance.pnlBooking.Controls.Remove(Home.Instance.pnlBooking.Controls["quickBooking"]);
            }
            quickBooking quick = new quickBooking(Quick.Home);
            quick.Dock = DockStyle.Fill;
            Home.Instance.pnlBooking.Controls.Add(quick);
            Home.Instance.pnlBooking.Controls["quickBooking"].BringToFront();
        }
    }
}
