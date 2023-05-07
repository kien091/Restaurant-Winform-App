using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class infoUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string phoneNumber { get; set; }

        public int role { get; set; }
        public string ID_Account { get; set; }

        public infoUser(string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, int role, string iD_Account)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.role = role;
            this.ID_Account = iD_Account;
        }
    }
}
