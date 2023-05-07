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

namespace Restaurant
{
    public partial class ResetPassword : Form
    {
        public string Email { get; set; }
        public int Flag { get; set; }
        public ResetPassword(string email)
        {
            InitializeComponent();
            Email = email;
            Flag = 0;
        }
        public ResetPassword(string email, int flag)
        {
            InitializeComponent();
            Email = email;
            Flag = flag;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                lbDanger.Text = "Your password enter password!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (txtPassword.Text.Length < 7)
            {
                lbDanger.Text = "Your password is too short!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                lbDanger.Text = "Your password confirm isn't correct!";
                lbDanger.ForeColor = Color.Red;
            }
            else
            {
                string password = SecurityUtils.SaltedHash(txtPassword.Text);
                UserModel user = new UserModel("", "", "", "", "", Email, password, 0);
                SqlConnection connection = ConnectionSingleton.GetConnection();
                if (user.CheckIfNewPasswordIsSameAsOld(connection))
                {
                    lbDanger.Text = "Password is same old.\nPlease choose another password!";
                    lbDanger.ForeColor = Color.Red;
                }
                else
                {
                    user.UpdatePassword(connection);
                    this.Hide();
                    if(Flag == 0)
                    {
                        Login login = new Login();
                        login.Closed += (s, args) => this.Close();

                        MessageBox.Show("Successful to reset password!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        login.Show();
                    }
                    else if(Flag == 3)
                    {
                        profile pro = new profile(Email, 3, txtPassword.Text);
                        pro.Closed += (s, args) => this.Close();

                        MessageBox.Show("Successful to reset password!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pro.Show();
                    }
                }
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            txtConfirm.PasswordChar = '•';
            if(Flag == 3)
                btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
