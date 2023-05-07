using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = SecurityUtils.SaltedHash(txtPassword.Text);
            UserModel user = new UserModel("", "", "", "", "", txtEmail.Text, password, 0);
            SqlConnection connection = ConnectionSingleton.GetConnection();

            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmail.Text.Length == 0)
            {
                lbDanger.Text = "Please enter your email!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (txtPassword.Text.Length == 0)
            {
                lbDanger.Text = "Please enter your password!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (!reg.IsMatch(txtEmail.Text))
            {
                lbDanger.Text = "Email isn't valid. Please enter again!";
                lbDanger.ForeColor = Color.Red;
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else if (!user.CheckIfUserExists(connection))
            {
                lbDanger.Text = "Account isn't exist. Please sign up!";
                lbDanger.ForeColor = Color.Red;
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else if (user.CheckIfUserExists(connection))
            {
                this.Hide();
                Home home = new Home(txtEmail.Text, txtPassword.Text);
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
        }

        private void btnCloseEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnOpenEye.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnOpenEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                btnCloseEye.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void lbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Closed += (s, args) => this.Close();
            signUp.Show();
        }

        private void llbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            InputEmail input = new InputEmail();
            input.Closed += (s, args) => this.Close();
            input.Show();
        }
    }
}
