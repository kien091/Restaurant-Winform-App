using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restaurant;

namespace Restaurant
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public string getFirstName()
        {
            return txtFirst.Text;
        }
        public string getLastName()
        {
            return txtLast.Text;
        }
        public string getDoB()
        {
            return dtPDateOfBirth.Value.Date.ToString("yyyy/MM/dd");
        }
        public string getGender()
        {
            if (ckMale.Checked) return "Male";
            else return "Female";
        }
        public string getPhoneNumber()
        {
            return txtPhoneNumber.Text;
        }
        public string getEmail()
        {
            return txtEmail.Text.ToLower();
        }
        public string getPassword()
        {
            return txtPassword.Text;
        }

        public string getOTP()
        {
            return otp.ToString();
        }

        int otp;
        Random random = new Random();
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string dateNow = DateTime.Now.Date.ToString("yyyy/MM/dd");
            string dOB = dtPDateOfBirth.Value.Date.ToString("yyyy/MM/dd");
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtFirst.Text.Length == 0)
            {
                lbDanger.Text = "Please enter your first name!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (txtLast.Text.Length == 0)
            {
                lbDanger.Text = "Please enter your last name!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (dateNow == dOB)
            {
                lbDanger.Text = "Please enter your date of birth again!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (!ckMale.Checked && !ckFemale.Checked)
            {
                lbDanger.Text = "Please choose gender!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (txtPhoneNumber.Text.Length < 10)
            {
                lbDanger.Text = "Your phone number isn't correct!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (!reg.IsMatch(txtEmail.Text))
            {
                lbDanger.Text = "Your email isn't correct!";
                lbDanger.ForeColor = Color.Red;
            }
            else if (txtPassword.Text.Length == 0)
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
                UserModel checkEmail = new UserModel(txtEmail.Text);
                SqlConnection connection = ConnectionSingleton.GetConnection();

                if (checkEmail.CheckIfUserExists(connection))
                {
                    lbDanger.Text = "Email was used. Please enter another email!";
                    lbDanger.ForeColor = Color.Red;
                }
                else
                {
                    lbDanger.Text = string.Empty;

                    try
                    {
                        txtEmail.Text = txtEmail.Text.ToLower();

                        otp = random.Next(100000, 1000000);
                        var fromAddress = new MailAddress("nguyntrungkin091@gmail.com", "Restaurant Application");
                        var toAddress = new MailAddress(txtEmail.ToString());
                        const string frompass = "hhqdwyrolhzlvkbj";

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, frompass),
                            Timeout = 20000,
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = "R-" + otp.ToString() + " is your Restaurant application confirmation code",
                            Body = "Hey " + txtLast.Text + " " + txtFirst.Text + "\n\nYou recently registered for Restaurant application. To complete your Restaurant registration, please confirm your account." + "\n\nYou may be asked to enter this confirmation code:" + " " + " R-" + otp.ToString()
                        })
                        {
                            smtp.Send(message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    this.Hide();
                    VerifyEmail verify = new VerifyEmail(this);
                    verify.Closed += (s, args) => this.Close();
                    verify.Show();

                }
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
        private void btnCloseEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnOpenEye.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }
        private void btnOpenEyeConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirm.PasswordChar == '•')
            {
                btnCloseEyeConfirm.BringToFront();
                txtConfirm.PasswordChar = '\0';
            }
        }

        private void btnCloseEyeConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirm.PasswordChar == '\0')
            {
                btnOpenEyeConfirm.BringToFront();
                txtConfirm.PasswordChar = '•';
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            txtConfirm.PasswordChar = '•';
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
