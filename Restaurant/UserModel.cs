using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Net;
using System.Security.Policy;

namespace Restaurant
{
    internal class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string ID_Account { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public string Postition { get; set; }
        public int Salary { get; set; }
        public string DayStart { get; set; }

        public UserModel() { }

        public UserModel(string firstName, string lastName, string dateOfBirth,
            string gender, string phoneNumber, string email, string password,
            int role)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Email = email;
            Password = password;
            Role = role;
        }
        public UserModel(string firstName, string lastName, string dateOfBirth,
            string gender, string phoneNumber, string email,
            int role, string iD_Account)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Email = email;
            Role = role;
            ID_Account = iD_Account;
        }
        public UserModel(string email)
        {
            Email = email;
        }

        public UserModel(string iD_Account, string note)
        {
            ID_Account = iD_Account;
            Note = note;
        }
        public UserModel(string address, string postition, int salary, string dayStart)
        {
            Address = address;
            Postition = postition;
            Salary = salary;
            DayStart = dayStart;
        }

        public void InsertUser(SqlConnection connection)
        {
            string query = "INSERT INTO Account (firstName, lastName, dateOfBirth, phoneNumber, gender, email, password, role) " +
                           "VALUES (@FirstName, @LastName, @DateOfBirth, @PhoneNumber, @Gender, @Email, @Password, @Role)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Role", Role);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateInfo(SqlConnection connection)
        {
            string query = "UPDATE Account SET firstName = @FirstName, lastName = @LastName, dateOfBirth = @DateOfBirth,"+
                " phoneNumber = @PhoneNumber, gender = @Gender, email = @Email, role = @Role " +
                           "WHERE ID_Account = @ID_Account";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Role", Role);
                command.Parameters.AddWithValue("@ID_Account", ID_Account);

                command.ExecuteNonQuery();
            }
        }
        public string getIdFromDB(SqlConnection connection)
        {
            string query = "SELECT ID_Account FROM Account WHERE email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                SqlDataReader reader = command.ExecuteReader();
                string id = "";
                if (reader.Read())
                {
                    id = reader.GetString(0);
                }
                reader.Close();
                return id;
            }
        }
        public void InsertPassenger(SqlConnection connection)
        {
            string query = "INSERT INTO Passenger " +
                           "VALUES (@ID_Account, @Note)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Account", ID_Account);
                command.Parameters.AddWithValue("@Note", Note);

                command.ExecuteNonQuery();
            }
        }
        public void InsertEmpoyee(SqlConnection connection)
        {
            string query = "INSERT INTO Employee " +
                           "VALUES (@ID_Account, @Address, @Salary, @DayStart)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Account", ID_Account);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Salary", Salary);
                command.Parameters.AddWithValue("@DayStart", DayStart);

                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfUserExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public string getNameOfUser(SqlConnection connection)
        {
            string query = "SELECT lastName + ' ' + firstName FROM Account WHERE email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                SqlDataReader reader = command.ExecuteReader();
                string name = "";
                if (reader.Read())
                {
                    name = reader.GetString(0);
                }
                reader.Close();
                return name;
            }
        }

        public void UpdatePassword(SqlConnection connection)
        {
            string query = "UPDATE Account SET password = @Password WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Email", Email);

                command.ExecuteScalar();
            }
        }
        public bool CheckIfNewPasswordIsSameAsOld(SqlConnection connection)
        {
            string query = "SELECT password FROM Account WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                string oldPassword = (string)command.ExecuteScalar();

                return Password == oldPassword;
            }
        }

        public List<infoUser> getInfomation(SqlConnection connection)
        {
            string query = "SELECT firstName, lastName, dateOfBirth, gender, phoneNumber, role, ID_Account"
                + " FROM Account WHERE email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                SqlDataReader reader = command.ExecuteReader();

                List<infoUser> info = new List<infoUser>();

                if (reader.Read())
                {
                    infoUser user = new infoUser(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2),
                        reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6));
                    info.Add(user);
                }
                reader.Close();
                return info;
            }
        }


        /*

        public void UpdatePassword(SqlConnection connection)
        {
            string query = "UPDATE users SET password = @Password WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Email", Email);

                command.ExecuteScalar();
            }
        }*/

    }
}
