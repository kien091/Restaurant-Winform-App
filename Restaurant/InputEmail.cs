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
    public partial class InputEmail : Form
    {
        public InputEmail()
        {
            InitializeComponent();
        }

        public string getOTP()
        {
            return otp.ToString();
        }
        public string getEmail()
        {
            return txtEmail.Text;
        }
        public string getName()
        {
            return name;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        int otp;
        Random random = new Random();
        string name;
        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (!reg.IsMatch(txtEmail.Text))
            {
                txtEmail.Text = "";
                lbDanger.Text = "Your email isn't correct!";
                lbDanger.ForeColor = Color.Red;
            }
            else
            {
                UserModel user = new UserModel(txtEmail.Text);
                SqlConnection connection = ConnectionSingleton.GetConnection();
                name = user.getNameOfUser(connection);
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
                        Body = "Hey " + name + "\n\nYou recently registered for Restaurant application. To complete your Restaurant registration, please confirm your account." + "\n\nYou may be asked to enter this confirmation code:" + " " + " R-" + otp.ToString()
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
                VerifyEmail email = new VerifyEmail(this, 1);
                email.Closed += (s, args) => this.Close();
                email.Show();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbDanger.Text = "";
        }
    }
}
