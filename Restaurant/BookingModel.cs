using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Restaurant
{
    internal class BookingModel
    {
        public string ID_Table { get; set; }
        public int NumPerson { get; set; }
        public string Time { get; set; }
        public string Note { get; set; }

        public string ID_Account { get; set; }
        public string ID_Booking { get; set; }
        public BookingModel(string id_Booking) 
        {
            ID_Booking = id_Booking;
        }
        public BookingModel(string iD_Table, int numPerson, string time, string note, string id_Account)
        {
            ID_Table = iD_Table;
            NumPerson = numPerson;
            Time = time;
            Note = note;
            ID_Account = id_Account;
        }

        public void InsertBooking(SqlConnection connection)
        {
            string query = "INSERT INTO Booking (ID_Table, numPerson, time, note, ID_Account) " +
                           "VALUES (@ID_Table, @NumPerson, @Time, @Note, @ID_Account)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Table", ID_Table);
                command.Parameters.AddWithValue("@NumPerson", NumPerson);
                command.Parameters.AddWithValue("@Time", Time);
                command.Parameters.AddWithValue("@Note", Note);
                command.Parameters.AddWithValue("@ID_Account", ID_Account);

                command.ExecuteNonQuery();
            }
        }

        public List<string> getTableBookingWithTime(SqlConnection connection)
        {
            string query = "SELECT ID_Table FROM Booking WHERE @Time BETWEEN" +
                " DATEADD(MINUTE, -30, time) and DATEADD(MINUTE, 90, time)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Time", Time);

                List<string> list = new List<string>();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                reader.Close();
                return list;
            }
        }

        public List<BookingInfo> getBooking(SqlConnection connection)
        {
            string query = "SELECT numPerson, time, note FROM Booking" +
                " WHERE ID_Account = @ID_Account";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Account", ID_Account);

                List<BookingInfo> list = new List<BookingInfo>();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BookingInfo info = new BookingInfo(reader.GetInt32(0).ToString(), reader.GetDateTime(1).ToString(), reader.GetString(2));
                    list.Add(info);
                }
                reader.Close();
                return list;
            }
        }

        public void updateBooking(SqlConnection connection)
        {
            string query = "UPDATE Booking SET numPerSon = @numPerson, time = @Time " +
                           "WHERE ID_Table = @ID_Table";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Table", ID_Table);
                command.Parameters.AddWithValue("@numPerson", NumPerson);
                command.Parameters.AddWithValue("@Time", Time);

                command.ExecuteNonQuery();
            }
        }

        //
        public string getIdBooking(SqlConnection connection)
        {
            string query = "SELECT ID_Booking FROM Booking" +
                " WHERE ID_Table = @ID_Table and time = @Time";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Table", ID_Table);
                command.Parameters.AddWithValue("@Time", Time);

                string id = "";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetString(0);
                }
                reader.Close();
                return id;
            }
        }

        public void deleteBooking(SqlConnection connection)
        {
            string query = "DELETE FROM Booking WHERE ID_Booking = @ID_Booking";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Booking", ID_Booking);

                command.ExecuteNonQuery();
            }
        }
        /*
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
