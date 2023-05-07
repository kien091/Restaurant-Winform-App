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

namespace Restaurant
{
    public partial class profile : Form
    {
        public string Email { get; set; }

        public int changePassFlag { get; set; }

        private string Password { get; set; }
        private int Role { get; set; }
        private string id_Account { get; set; }
        public profile(string email, string password)
        {
            InitializeComponent();
            this.Email = email;
            changePassFlag = 0;
            this.Password = password;
        }

        public profile(string email, int change)
        {
            InitializeComponent();
            Email = email;
            changePassFlag = change;
        }

        public profile(string email, int change, string password)
        {
            InitializeComponent();
            Email = email;
            changePassFlag = change;
            Password = password;
        }

        private void profile_Load(object sender, EventArgs e)
        {
            UserModel user = new UserModel(Email);
            SqlConnection connection = ConnectionSingleton.GetConnection();
            List<infoUser> info = user.getInfomation(connection);

            txtFirst.Text = info.ElementAt(0).firstName;
            txtLast.Text = info.ElementAt(0).lastName;
            dtPDateOfBirth.Value = info.ElementAt(0).dateOfBirth;
            dtPDateOfBirth.CustomFormat = "MMM dd,yyyy";
            if (info.ElementAt(0).gender == "Male")
            {
                ckMale.Checked = true;
            }
            else
            {
                ckFemale.Checked = true;
            }
            txtPhoneNumber.Text = info.ElementAt(0).phoneNumber;
            txtEmail.Text = Email;
            Role = info.ElementAt(0).role;
            if(changePassFlag == 0)
            {
                foreach (Control control in grpInfo.Controls)
                {
                    control.Enabled = false;
                }
                ckMale.Enabled = false;
                ckFemale.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnModify.Enabled = false;
            }
            id_Account = user.getIdFromDB(connection);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            foreach (Control control in grpInfo.Controls)
            {
                control.Enabled = true;
            }
            ckFemale.Enabled = true;
            ckMale.Enabled = true;
            btnUpdate.Enabled = true;

            this.Hide();
            VerifyEmail verify = new VerifyEmail(2, Email, txtLast.Text + " " + txtFirst.Text);
            verify.Closed += (s, args) => this.Close();
            verify.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel(txtFirst.Text, txtLast.Text, dtPDateOfBirth.Value.ToString(), ckMale.Checked?"Male":"Female", txtPhoneNumber.Text, txtEmail.Text, Role, id_Account);
            SqlConnection connection = ConnectionSingleton.GetConnection();
            user.UpdateInfo(connection);
            MessageBox.Show("Successful to reset information!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Control control in grpInfo.Controls)
            {
                control.Enabled = false;
            }
            ckMale.Enabled = false;
            ckFemale.Enabled = false;
            btnUpdate.Enabled = false;
            btnModify.Enabled = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerifyEmail verify = new VerifyEmail(3, Email, txtLast.Text + " " + txtFirst.Text);
            verify.Closed += (s, args) => this.Close();
            verify.Show();

            foreach (Control control in grpInfo.Controls)
            {
                control.Enabled = false;
            }
            ckMale.Enabled = false;
            ckFemale.Enabled = false;
            btnUpdate.Enabled = false;
            btnModify.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(Email, Password);
            home.Closed += (s, args) => this.Close();
            home.Show();
        }
    }
}
