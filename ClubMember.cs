using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_4
{
    public class ClubMember
    {
        static int currentID = 15416;
        public int memberID;
        int age;
        string firstName;
        string lastName;
        public string memberEmail;
        DateTime dob;

        public string GetName()
        {
            string memberName = lastName + ", " + firstName;
            return memberName;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Today;
            int currentYear = currentDate.Year;
            int age = currentYear - dob.Year;
            if (dob.Month <= currentDate.Month &&
                dob.Day > currentDate.Day)
            {
                age--;
            }
            return age;
        }
        public void SetAllData(string first, string last,
            string email, DateTime birthday)
        {
            currentID++;
            memberID = currentID;
            firstName = first;
            lastName = last;
            memberEmail = email;
            dob = birthday; 
        }


        
    }
}
