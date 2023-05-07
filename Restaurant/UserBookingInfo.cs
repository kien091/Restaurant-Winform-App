using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Restaurant
{
    public partial class UserBookingInfo : UserControl
    {
        private Home home { get; set; }

        public string Email { get; set; }
        public UserBookingInfo()
        {
            InitializeComponent();
        }

        public UserBookingInfo(Home home)
        {
            InitializeComponent();
            LoadDataGridView();
            this.home = home;
        }

        private DataTable dataTable = new DataTable();

        private void LoadDataGridView()
        {
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("Table", typeof(string));
            dataTable.Columns.Add("Number of Person", typeof(int));
            dataTable.Columns.Add("Time", typeof(string));

            dgvInfo.DataSource = dataTable;

            dgvInfo.Columns["STT"].Width = 40;
            dgvInfo.Columns["Table"].Width = 105;
            dgvInfo.Columns["Number of Person"].Width = 170;
            dgvInfo.Columns["Time"].Width = 200;
            dgvInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private string idTable = "";
        private List<BookingInfo> input = new List<BookingInfo>();
        private List<findInfoTableWithList> status = new List<findInfoTableWithList>();

        int stt = 0;
        private void UserBookingInfo_Load(object sender, EventArgs e)
        {
            UserModel user = new UserModel(home.Email);
            SqlConnection connection = ConnectionSingleton.GetConnection();
            string id_Account = user.getIdFromDB(connection);

            BookingModel booking = new BookingModel("", 0, "", "", id_Account);
            List<BookingInfo> list = booking.getBooking(connection);
            input = list;

            txtNum.Enabled = false;
            dtpDate.Enabled = false;
            dtpHour.Enabled = false;

            dtpDate.CustomFormat = "MMM dd,yyyy";
            dtpHour.CustomFormat = "hh:mm tt";

            if (list.Count == 0)
            {
                lbDanger.Text = "You don't booking yet!";
                lbDanger.ForeColor = Color.Red;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnModify.Enabled = false;
            }
            else
            {
                lbDanger.Text = "";
                btnDelete.Enabled = true;
                btnUpdate.Enabled = false;
                btnModify.Enabled = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (idTable == list.ElementAt(i).Table)
                        continue;
                    else
                    {
                        idTable = list.ElementAt(i).Table;
                        dataTable.Rows.Add(stt += 1, list.ElementAt(i).Table, list.ElementAt(i).NumPerson, list.ElementAt(i).Time);
                        status.Add(new findInfoTableWithList(idTable, i, stt));
                    }
                }
                dgvInfo.DataSource = dataTable;
                dgvInfo.RowHeadersVisible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string idTable = input.ElementAt(status.ElementAt(i).numInList).Table;
            string[] id = idTable.Split(' ');
            for(int j=0; j<id.Length; j++)
            {
                UserModel user = new UserModel(home.Email);
                SqlConnection connection = ConnectionSingleton.GetConnection();
                string id_Account = user.getIdFromDB(connection);
                BookingModel booking = new BookingModel(id[j], int.Parse(txtNum.Text), dtpHour.Value.ToString(), input.ElementAt(i).Table, id_Account);
                booking.updateBooking(connection);
            }
            MessageBox.Show("Successful to update table!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idTable = input.ElementAt(status.ElementAt(i).numInList).Table;
            string[] id = idTable.Split(' ');
            for (int j = 0; j < id.Length; j++)
            { 
                SqlConnection connection = ConnectionSingleton.GetConnection();
                BookingModel findIdBooking = new BookingModel(id[j], 0, input.ElementAt(status.ElementAt(i).numInList).Time, "", "");
                string id_Booking = findIdBooking.getIdBooking(connection);
                BookingModel del = new BookingModel(id_Booking);
                del.deleteBooking(connection);
            }
            MessageBox.Show("Successful to delete!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtNum.Enabled = true;
            dtpDate.Enabled = true;
            dtpHour.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Value.Day < DateTime.Now.Day)
            {
                btnUpdate.Enabled = false;
                lbDanger.Text = "Please chose another day";
                lbDanger.ForeColor = Color.Red;
            }
            else lbDanger.Text = "";
        }

        private void dtpHour_ValueChanged(object sender, EventArgs e)
        {
            DateTime Day = dtpDate.Value;
            DateTime Hour = new DateTime(Day.Year, Day.Month, Day.Day, dtpDate.Value.Hour, dtpDate.Value.Minute, 0);
            if (Hour.AddMinutes(-29) <= DateTime.Now)
            {
                btnModify.Enabled = false;
                btnUpdate.Enabled = false;
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
                    btnModify.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else if (Hour.TimeOfDay > closeTime)
                {
                    lbDanger.Text = "Your are booking too late. \nPlease choose another time to booking";
                    lbDanger.ForeColor = Color.Red;
                    btnModify.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lbDanger.Text = "";
                    btnModify.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
        }

        int i;
        private void txtOrd_TextChanged(object sender, EventArgs e)
        {
            int number;

            if(int.TryParse(txtOrd.Text,out number))
            {
                if(number <= stt)
                {

                    for (i = 0; i < status.Count; i++)
                    {
                        if (status.ElementAt(i).numInOrd == int.Parse(txtOrd.Text)) break;
                    }

                    int index = status.ElementAt(i).numInList;

                    txtNum.Text = input.ElementAt(index).NumPerson.ToString();
                    string time = input.ElementAt(index).Time;
                    DateTime t = DateTime.Parse(time);
                    dtpDate.Value = t;
                    dtpHour.Value = t;

                    dtpDate.CustomFormat = "MMM dd,yyyy";
                    dtpHour.CustomFormat = "hh:mm tt";

                    if (lbDanger.Text != "")
                        lbDanger.Text = "";
                    if (t > DateTime.Now)
                    {
                        btnModify.Enabled = true;
                        btnUpdate.Enabled = true;
                    }
                }
                else
                {
                    btnModify.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            else
            {
                btnModify.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtNum.Text, out number))
            {
                if(number < 1)
                {
                    txtNum.Text = "1";
                }
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
