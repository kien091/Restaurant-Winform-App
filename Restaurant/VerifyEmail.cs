using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Restaurant;

namespace Restaurant
{
    public partial class VerifyEmail : Form
    {
        SignUp SignUp { get; set; }
        public string Email { get; set; }
        public string OTP { get; set; }
        public string Name { get; set; }

        public int Flag = 0;
        public VerifyEmail(SignUp signUp)
        {
            InitializeComponent();
            SignUp = signUp;
            Email = signUp.getEmail();
            OTP = signUp.getOTP();
            Name = signUp.getLastName() + " " + signUp.getFirstName();
        }

        public VerifyEmail(InputEmail input, int from)
        {
            InitializeComponent();
            Email = input.getEmail();
            Flag = from;
            OTP = input.getOTP();
            Name = input.getName();
        }

        public VerifyEmail(int i, string email, string name)
        {
            InitializeComponent();
            Flag = i;
            Email = email;
            Name = name;
            generateOTP();
        }

        // set time to count down
        System.Timers.Timer time;
        public static int fminute = 5, fsecond = 0;
        int minute = fminute, second = fsecond;
        private void VerifyEmail_Load(object sender, EventArgs e)
        {
            lbNotice.Text = lbNotice.Text + Email;

            // start count down
            time = new System.Timers.Timer();
            time.Interval = 1000;
            time.Elapsed += onTimeEvent;
            time.Start();
        }

        // function to count down
        private void onTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (second == 0)
                {
                    second = 60;
                    minute -= 1;
                }
                second -= 1;
                lbCount.Text = string.Format("{0}:{1}", minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            }));
            if (lbCount.Text == "00:00")
            {
                time.Stop();
                lbDanger.Text = "Your OTP code has expired!";
                lbDanger.ForeColor = Color.Red;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lbCount.Text != "00:00")
            {
                if (txtOTP.Text != OTP)
                {
                    lbDanger.Text = "Your OTP isn't correct!";
                    lbDanger.ForeColor = Color.Red;
                }
                else if (Flag == 0)
                {
                    lbDanger.Text = "";

                    // create user and passenger
                    string password = SecurityUtils.SaltedHash(SignUp.getPassword());
                    UserModel user = new UserModel(SignUp.getFirstName(), SignUp.getLastName(), SignUp.getDoB(), SignUp.getGender(), SignUp.getPhoneNumber(), SignUp.getEmail(), password, 0);
                    SqlConnection connection = ConnectionSingleton.GetConnection();
                    user.InsertUser(connection);

                    string ID_Passenger = user.getIdFromDB(connection);
                    UserModel passenger = new UserModel(ID_Passenger, "Normal");
                    passenger.InsertPassenger(connection);

                    this.Hide();
                    Login login = new Login();
                    login.Closed += (s, args) => this.Close();

                    MessageBox.Show("Registration successful!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    login.Show();
                }
                else if (Flag == 1)
                {
                    // go to reset password
                    this.Hide();
                    ResetPassword reset = new ResetPassword(this.Email);
                    reset.Closed += (s, args) => this.Close();
                    reset.Show();
                }else if(Flag == 2){
                    this.Hide();
                    profile pro = new profile(Email, Flag);
                    pro.Closed += (s, args) => this.Close();
                    pro.Show();
                }
                else if(Flag == 3)
                {
                    this.Hide();
                    ResetPassword reset = new ResetPassword(Email, Flag);
                    reset.Closed += (s, args) => this.Close();
                    reset.Show();
                }
            }
        }

        int otp;
        Random random = new Random();

        // resend OTP code to email
        private void btnResend_Click(object sender, EventArgs e)
        {
            lbDanger.Text = "";
            time.Stop();

            minute = fminute;
            second = fsecond;

            time = new System.Timers.Timer();
            time.Interval = 1000;
            time.Elapsed += onTimeEvent;
            time.Start();

            generateOTP();
        }

        private void generateOTP()
        {
            try
            {
                otp = random.Next(100000, 1000000);
                OTP = otp.ToString();
                var fromAddress = new MailAddress("nguyntrungkin091@gmail.com", "Restaurant Application");
                var toAddress = new MailAddress(Email.ToLower());
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
                    Body = "Hey " + Name + "\n\nYou recently registered for Restaurant application. To complete your Restaurant registration, please confirm your account." + "\n\nYou may be asked to enter this confirmation code:" + " " + " R-" + otp.ToString()
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
